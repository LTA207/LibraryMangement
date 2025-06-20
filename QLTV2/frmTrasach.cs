using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmTrasach : Form
    {
        public frmTrasach()
        {
            InitializeComponent();
        }

        private void frmTrasach_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            if (cmbDocGia.Items.Count > 0)
            {
                cmbDocGia.SelectedIndex = 0; // Chọn độc giả đầu tiên
                int maDG = Convert.ToInt32(cmbDocGia.SelectedValue);
                LoadDanhSachSachChuaTra(maDG);
            }
            cmbDocGia.SelectedIndexChanged += cmbDocGia_SelectedIndexChanged;
        }

        private void LoadDocGia()
        {
            DataTable dtDocGia = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "SELECT MADG, CONCAT(HODG, ' ', TENDG) AS TENDG FROM DOCGIA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtDocGia);
            }

            cmbDocGia.DataSource = dtDocGia;
            cmbDocGia.DisplayMember = "TENDG";
            cmbDocGia.ValueMember = "MADG";
        }

        private void cmbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocGia.SelectedValue == null) return;

            int maDG;
            if (int.TryParse(cmbDocGia.SelectedValue.ToString(), out maDG))
            {
                LoadDanhSachSachChuaTra(maDG);
            }
        }

        private void LoadDanhSachSachChuaTra(int maDG)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = @"
                    SELECT 
                        s.MASACH,
                        ds.TENSACH,
                        s.CHOMUON,
                        s.MANGANTU,
                        pm.MAPHIEU
                    FROM PHIEUMUON pm
                    JOIN CT_PHIEUMUON ct ON pm.MAPHIEU = ct.MAPHIEU
                    JOIN SACH s ON ct.MASACH = s.MASACH
                    JOIN DAUSACH ds ON s.ISBN = ds.ISBN
                    WHERE pm.MADG = @MaDG
                      AND ct.TRA = 0";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaDG", maDG);

                da.Fill(dt);
            }

            dgvSachMuon.DataSource = dt;

            if (dgvSachMuon.Columns.Count > 0)
            {
                dgvSachMuon.Columns["MASACH"].HeaderText = "Mã sách";
                dgvSachMuon.Columns["TENSACH"].HeaderText = "Tên sách";
                dgvSachMuon.Columns["CHOMUON"].HeaderText = "Tình trạng mượn";
                dgvSachMuon.Columns["MANGANTU"].HeaderText = "Mã ngăn tủ";

                // Ẩn MAPHIEU nếu không cần
                if (dgvSachMuon.Columns.Contains("MAPHIEU"))
                    dgvSachMuon.Columns["MAPHIEU"].Visible = false;
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn sách để trả chưa
            if (dgvSachMuon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần trả.");
                return;
            }

            // Lấy thông tin sách từ DataGridView
            string maSach = dgvSachMuon.CurrentRow.Cells["MASACH"].Value.ToString();
            int maPhieu = Convert.ToInt32(dgvSachMuon.CurrentRow.Cells["MAPHIEU"].Value);
            string maNV = Program.mId; // Mã nhân viên hiện tại

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();

                    // Bắt đầu transaction để đảm bảo tính toàn vẹn dữ liệu
                    SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //    // 1. Kiểm tra sách có đang được mượn không
                    //    string checkQuery = @"
                    //SELECT CHOMUON 
                    //FROM SACH 
                    //WHERE MASACH = @MaSach";

                    //    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                    //    {
                    //        checkCmd.Parameters.AddWithValue("@MaSach", maSach);
                    //        object chomuonResult = checkCmd.ExecuteScalar();

                    //        if (chomuonResult == null || (int)chomuonResult != 1)
                    //        {
                    //            MessageBox.Show("Sách này không đang được mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //            transaction.Rollback();
                    //            return;
                    //        }
                    //    }

                    // 2. Cập nhật bảng CT_PHIEUMUON (đánh dấu đã trả)
                    string updateCtPhieuMuonQuery = @"
                    UPDATE CT_PHIEUMUON 
                    SET NGAYTRA = GETDATE(), TRA = 1, MANVNS = @MaNV 
                    WHERE MAPHIEU = @MaPhieu AND MASACH = @MaSach";

                        using (SqlCommand updateCtPhieuMuonCmd = new SqlCommand(updateCtPhieuMuonQuery, conn, transaction))
                        {
                            updateCtPhieuMuonCmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                            updateCtPhieuMuonCmd.Parameters.AddWithValue("@MaSach", maSach);
                            updateCtPhieuMuonCmd.Parameters.AddWithValue("@MaNV", maNV);

                            int rowsAffected = updateCtPhieuMuonCmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Không tìm thấy phiếu mượn hoặc sách tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }
                        }

                        // 3. Cập nhật bảng SACH (đánh dấu sách đã trả)
                        string updateSachQuery = @"
                    UPDATE SACH 
                    SET CHOMUON = 0 
                    WHERE MASACH = @MaSach";

                        using (SqlCommand updateSachCmd = new SqlCommand(updateSachQuery, conn, transaction))
                        {
                            updateSachCmd.Parameters.AddWithValue("@MaSach", maSach);
                            updateSachCmd.ExecuteNonQuery();
                        }

                        // Commit transaction nếu mọi thứ thành công
                        transaction.Commit();

                        MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới danh sách sách chưa trả
                        int maDG = Convert.ToInt32(cmbDocGia.SelectedValue);
                        LoadDanhSachSachChuaTra(maDG);
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi trả sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
