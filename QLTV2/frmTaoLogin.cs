using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmTaoLogin : Form
    {

        public frmTaoLogin()
        {
            InitializeComponent();
            cmbUser.Enabled = true;  
            setUpQuyen();
        }

        private void setUpQuyen()
        {
            var listQuyen = new List<KeyValuePair<string, string>>()
    {
        new KeyValuePair<string, string>("dg", "Độc giả"),
        new KeyValuePair<string, string>("ad", "Thủ Thư")
    };

            cmbQuyen.DataSource = listQuyen;
            cmbQuyen.DisplayMember = "Value";
            cmbQuyen.ValueMember = "Key";      

            cmbQuyen.SelectedIndex = 0;
        }


        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu quyền là Độc giả (dg)
            if (cmbQuyen.SelectedIndex == 0)
            {
                LoadDocGiaChuaTaoTK();  // Gọi SP để tải độc giả chưa có tài khoản
            }
            else
            {
                LoadNhanVienChuaTaoTK(); // Nếu là Thủ Thư, xóa danh sách trong cmbUser
            }
        }

        private void LoadDocGiaChuaTaoTK()
        {
            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                // Mở kết nối
                conn.Open();

                // Tạo Command để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("LayDocGiaChuaTaoTK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tạo DataAdapter và DataTable để lưu trữ dữ liệu
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Thêm cột mới để gộp Họ, Tên và Mã Độc Giả
                        dt.Columns.Add("HienThi", typeof(string));
                        foreach (DataRow row in dt.Rows)
                        {
                            row["HienThi"] = $"{row["HODG"]} {row["TENDG"]} - {row["MADG"]}";
                        }

                        // Gán DataSource cho cmbUser
                        cmbUser.DataSource = dt;
                        cmbUser.DisplayMember = "HienThi";  // Cột mới để hiển thị
                        cmbUser.ValueMember = "MADG";        // Giá trị thực sự sẽ là MADG

                        cmbUser.Enabled = true;
                    }
                }
            }
        }
        private void LoadNhanVienChuaTaoTK()
        {
            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                // Mở kết nối
                conn.Open();

                // Tạo Command để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("LayNhanVienChuaTaoTK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tạo DataAdapter và DataTable để lưu trữ dữ liệu
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Thêm cột mới để gộp Họ, Tên và Mã Độc Giả
                        dt.Columns.Add("HienThi", typeof(string));
                        foreach (DataRow row in dt.Rows)
                        {
                            row["HienThi"] = $"{row["HONV"]} {row["TENNV"]} - {row["MANV"]}";
                        }

                        // Gán DataSource cho cmbUser
                        cmbUser.DataSource = dt;
                        cmbUser.DisplayMember = "HienThi";  // Cột mới để hiển thị
                        cmbUser.ValueMember = "MANV";        // Giá trị thực sự sẽ là MADG

                        cmbUser.Enabled = true;
                    }
                }
            }
        }

        private void btnTaotaikhoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra Username và Password không được để trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Lấy các giá trị cần thiết
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string quyen = cmbQuyen.SelectedValue.ToString();
            string userId = quyen + cmbUser.SelectedValue.ToString(); // Mã độc giả hoặc mã nhân viên

            try
            {
                // Kết nối vào DB master để tạo login
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();

                    // Chuyển sang context của database master
                    using (SqlCommand cmd = new SqlCommand("USE master", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Bắt đầu gọi procedure tạo login
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;

                        if (quyen == "dg")
                            cmd.CommandText = "TaoLoginDG";  // Tạo login cho Độc giả
                        else
                            cmd.CommandText = "TaoLoginAdmin"; // Tạo login cho Admin/Thủ thư

                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số
                        cmd.Parameters.AddWithValue("@LoginName", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        if (quyen == "dg")
                            cmd.Parameters.AddWithValue("@MADG", userId);
                        else
                            cmd.Parameters.AddWithValue("@MANV", userId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu nhập sau khi thành công
                    txtUsername.Clear();
                    txtPassword.Clear();

                    if (cmbQuyen.SelectedValue.ToString() == "dg")
                    {
                        LoadDocGiaChuaTaoTK();  // Gọi SP để tải độc giả chưa có tài khoản
                    }
                    else
                    {
                        LoadNhanVienChuaTaoTK(); // Nếu là Thủ Thư, xóa danh sách trong cmbUser
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
