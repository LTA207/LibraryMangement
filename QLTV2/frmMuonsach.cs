using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmMuonsach: Form
    {
        int vitri = 0; 
        private int? currentMaPhieu = null;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.THELOAITableAdapter THELOAITableAdapter = new QLTV2.DSTableAdapters.THELOAITableAdapter();
        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.DAUSACHTableAdapter DAUSACHTableAdapter = new QLTV2.DSTableAdapters.DAUSACHTableAdapter();
        private QLTV2.DSTableAdapters.NGANTUTableAdapter NGANTUTableAdapter = new QLTV2.DSTableAdapters.NGANTUTableAdapter();
        private QLTV2.DSTableAdapters.DOCGIATableAdapter DOCGIATableAdapter = new QLTV2.DSTableAdapters.DOCGIATableAdapter();
        private QLTV2.DSTableAdapters.SACHTableAdapter SACHTableAdapter = new QLTV2.DSTableAdapters.SACHTableAdapter();
        private QLTV2.DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter = new QLTV2.DSTableAdapters.NHANVIENTableAdapter();
        public frmMuonsach()
        {
            InitializeComponent();
        }

        private void pHIEUMUONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPM.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMuonsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter1.Fill(this.dS.DOCGIA);
            try
            {
                // Tắt ràng buộc tạm thời để tránh lỗi khi tải dữ liệu
                dS.EnforceConstraints = false;

                // 1. Tải dữ liệu từ các bảng cha
                this.NGONNGUTableAdapter.Fill(this.dS.NGONNGU);
                this.THELOAITableAdapter.Fill(this.dS.THELOAI);
                this.DAUSACHTableAdapter.Fill(this.dS.DAUSACH);
                this.NGANTUTableAdapter.Fill(this.dS.NGANTU);
                this.DOCGIATableAdapter.Fill(this.dS.DOCGIA); 
                this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN); 
                this.SACHTableAdapter.Fill(this.dS.SACH); 

                this.PHIEUMUONTableAdapter.Fill(this.dS.PHIEUMUON); 
                this.CT_PHIEUMUONTableAdapter.Fill(this.dS.CT_PHIEUMUON);

                dS.EnforceConstraints = true;
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Lỗi ràng buộc: " + ex.Message);

                // Kiểm tra từng bảng để tìm nguyên nhân lỗi
                foreach (DataTable table in dS.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row.HasErrors)
                        {
                            MessageBox.Show($"Lỗi trong bảng {table.TableName}: {row.RowError}");
                            foreach (DataColumn col in table.Columns)
                            {
                                string err = row.GetColumnError(col);
                                if (!string.IsNullOrEmpty(err))
                                {
                                    MessageBox.Show($"Cột {col.ColumnName}: {err}");
                                }
                            }
                        }
                    }
                }
            }

            if (bdsPM.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            SetupMaDocGiaComboBox();
            SetupNhanVienComboBox();
            SetupHinhThucComboBox();
            SetupMaSachComboBox();
            SetupNhanVienComboBoxColumn();
            SetupColunmChoMuon();
            this.gcPHIEUMUON.CellValueChanged += gcPHIEUMUON_CellValueChanged;
            this.gcPHIEUMUON.CellBeginEdit += gcPHIEUMUON_CellBeginEdit;
        }

        private void SetupNhanVienComboBoxColumn()
        {
            // 1. Tạo DataTable chứa MANV + Họ tên ghép
            DataTable dtNhanVien = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "SELECT MANV, CONCAT(HONV, ' ', TENNV, ' - ', MANV) AS DisplayText FROM NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtNhanVien);
            }

            // 2. Lấy cột combobox đã có sẵn từ DataGridView
            DataGridViewComboBoxColumn colManv = gcPHIEUMUON.Columns["cmbMANVColumn"] as DataGridViewComboBoxColumn;

            if (colManv != null)
            {
                colManv.DataSource = dtNhanVien;
                colManv.DisplayMember = "DisplayText"; // Hiển thị họ tên + mã
                colManv.ValueMember = "MANV";          // Lưu MANV vào cell
                colManv.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cột combobox 'MANV' trong DataGridView.");
            }
        }

        private void SaveCurrentRowState(string action)
        {
            if (bdsPM.Current == null) return;

            DataRowView currentRowView = (DataRowView)bdsPM.Current;
            DataRow row = currentRowView.Row;
            object[] values = (object[])row.ItemArray.Clone();

            int realIndex = dS.DAUSACH.Rows.IndexOf(row); // vị trí trong danh sách gốc

            undoStack.Push(new UndoItem
            {
                ItemArray = values,
                Action = action,
                Index = bdsPM.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                RealIndex = realIndex    // vị trí thật trong danh sách gốc
            });
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add" });
            vitri = bdsPM.Position;
            GroupBox1.Enabled = true;
            gcPHIEUMUON.Enabled = false;
            bdsPM.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = btnReload.Enabled = true;
            cmbMADG.Focus();
            dtpNgaymuon.Format = DateTimePickerFormat.Custom;
            dtpNgaymuon.CustomFormat = "dd/MM/yyyy";
            dtpNgaymuon.Value = DateTime.Now;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCT_PHIEUMUON.Count > 0)
            {
                MessageBox.Show("Đầu sách đã có sách, không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa đầu sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete");
                    bdsPM.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đầu sách.\n" + ex.Message);
                    return;
                }
            }
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtTensach.Text))
            //{
            //    MessageBox.Show("Tên nhân viên không được thiếu.");
            //    txtTensach.Focus();
            //    return;
            //}

            //string ISBN = txtISBN.Text.Trim();
            //if (bdsDS.Cast<DataRowView>().Any(r => r != bdsDS.Current && r["ISBN"].ToString() == ISBN))
            //{
            //    MessageBox.Show("Mã đầu sách này đã tồn tại. Vui lòng nhập mã khác.");
            //    txtISBN.Focus();
            //    return;
            //}
            
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();


                if (item.Action == "Add")
                {
                    if (bdsPM.Count > 0)
                    {
                        bdsPM.RemoveAt(bdsPM.Count - 1);
                    }
                }
                else if (item.Action == "Delete")
                {
                    // Tìm dòng đã bị xóa có cùng ISBN
                    var deletedRow = dS.PHIEUMUON.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["MAPHIEU", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                    if (deletedRow != null)
                    {
                        // Hủy xóa (rollback)
                        deletedRow.RejectChanges();
                    }
                    else
                    {
                        // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                        DataRow row = dS.PHIEUMUON.NewRow();
                        row.ItemArray = item.ItemArray;
                        dS.PHIEUMUON.Rows.InsertAt(row, item.Index);
                    }
                }
                else if (item.Action == "Edit")
                {
                    bdsPM.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                    DataRow current = ((DataRowView)bdsPM.Current).Row;
                    for (int i = 0; i < current.Table.Columns.Count; i++)
                    {
                        if (!current.Table.Columns[i].ReadOnly)
                        {
                            current[i] = item.ItemArray[i];
                        }
                    }
                }

                bdsPM.ResetBindings(false);
                gcPHIEUMUON.Refresh();
                MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.CT_PHIEUMUON.Clear();
            dS.PHIEUMUON.Clear();
            dS.SACH.Clear();
            dS.NHANVIEN.Clear();
            dS.DOCGIA.Clear();
            dS.NGANTU.Clear();
            dS.DAUSACH.Clear();
            dS.THELOAI.Clear();
            dS.NGONNGU.Clear();

            this.NGONNGUTableAdapter.Fill(this.dS.NGONNGU);
            this.THELOAITableAdapter.Fill(this.dS.THELOAI);
            this.DAUSACHTableAdapter.Fill(this.dS.DAUSACH);
            this.NGANTUTableAdapter.Fill(this.dS.NGANTU);
            this.DOCGIATableAdapter.Fill(this.dS.DOCGIA);
            this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
            this.SACHTableAdapter.Fill(this.dS.SACH);

            this.PHIEUMUONTableAdapter.Fill(this.dS.PHIEUMUON);
            this.CT_PHIEUMUONTableAdapter.Fill(this.dS.CT_PHIEUMUON);

        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void gcPHIEUMUON_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bdsPM.EndEdit();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        private void gcPHIEUMUON_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit");
        }
        private void SetupMaDocGiaComboBox()
        {
            DataTable dtDocGia = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "select MADG, CONCAT(HODG,' ', TENDG) as TENDG from DOCGIA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtDocGia);
            }

            cmbMADG.DataSource = dtDocGia;
            cmbMADG.DisplayMember = "TENDG";
            cmbMADG.ValueMember = "MADG";

            cmbMADG.DataBindings.Clear();
            cmbMADG.DataBindings.Add("SelectedValue", bdsPM, "MADG", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void SetupNhanVienComboBox()
        {
            DataTable dtNhanVien = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "select MANV, CONCAT(HONV,' ', TENNV, '-', MANV) as TENNV from NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtNhanVien);
            }
            cmbMANV.DataSource = dtNhanVien;
            cmbMANV.DisplayMember = "TENNV";
            cmbMANV.ValueMember = "MANV";

            cmbMANV.DataBindings.Clear();
            cmbMANV.DataBindings.Add("SelectedValue", bdsPM, "MANV", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void SetupHinhThucComboBox()
        {
            cmbHinhthuc.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Mượn về"),
                new KeyValuePair<bool, string>(false, "Mượn tại chỗ")
            };
            cmbHinhthuc.DisplayMember = "Value";
            cmbHinhthuc.ValueMember = "Key";

            cmbHinhthuc.DataBindings.Clear();
            cmbHinhthuc.DataBindings.Add("SelectedValue", bdsPM, "HINHTHUC", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private int GetSoSachChuaTra(int maDG)
        {
            int soSach = 0;

            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("DemSoSachChuaTra", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDG", maDG);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int value))
                    {
                        soSach = value;
                    }
                }
            }

            return soSach;
        }
        private void SetupMaSachComboBox()
        {
            DataTable dtSach = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = @"
            SELECT 
                s.MASACH, 
                LTRIM(RTRIM(ds.TENSACH)) AS TENSACH,
                CONCAT('[', LTRIM(RTRIM(s.MASACH)), '] ', ds.TENSACH) AS DisplayName
            FROM 
                SACH s
            JOIN 
                DAUSACH ds ON s.ISBN = ds.ISBN
            WHERE 
                s.CHOMUON = 0"; // Chỉ load sách chưa mượn
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtSach);
            }

            cmbMAS.DataSource = dtSach;
            cmbMAS.DisplayMember = "DisplayName";
            cmbMAS.ValueMember = "MASACH";

            cmbMAS.DataBindings.Clear();
            cmbMAS.DataBindings.Add("SelectedValue", bdsCT_PHIEUMUON, "MASACH", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            int maDG = Convert.ToInt32(cmbMADG.SelectedValue);
            int soSachChuaTra = GetSoSachChuaTra(maDG);

            bool isOverdue = CheckIfReaderHasOverdueBooks(maDG);

            if (string.IsNullOrWhiteSpace(cmbMAS.Text))
            {
                MessageBox.Show("Mã sách không được thiếu.");
                cmbMAS.Focus();
                return;
            }

            if (isOverdue)
            {
                MessageBox.Show("Độc giả này có sách mượn quá hạn, không thể mượn thêm.");
                return;
            }

            if (soSachChuaTra == 3)
            {
                MessageBox.Show("Độc giả này đã mượn đủ 3 cuốn sách chưa trả. Không thể mượn thêm.");
                return;
            }

            String value = cmbMAS.SelectedValue.ToString();
            try
            {
                bdsPM.EndEdit();
                bdsPM.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    PHIEUMUONTableAdapter.Update(dS.PHIEUMUON);
                    MessageBox.Show("Dữ liệu đã được ghi vào db");
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để ghi vào cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã đầu sách bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi đầu sách. " + Environment.NewLine + ex.Message);
                }
                return;
            }

            btnGhi.Enabled = btnPhuchoi.Enabled = GroupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            gcPHIEUMUON.Enabled = true;

            //try
            //{
                dS.EnforceConstraints = false;

                // Lấy MAPHIEU hiện tại sau khi Update
                DataRowView currentRow = (DataRowView)bdsPM.Current;
                int currentMaPhieu = Convert.ToInt32(currentRow["MAPHIEU"]);
                if (value == null)
                {
                    MessageBox.Show("Vui lòng chọn mã sách.");
                    return;
                }

                // Thêm dòng vào bảng CT_PHIEUMUON
                DataRow ctRow = dS.CT_PHIEUMUON.NewRow();
                ctRow["MAPHIEU"] = currentMaPhieu;
                ctRow["MASACH"] = value;
                ctRow["TINHTRANGMUON"] = 1;
                ctRow["TRA"] = 0;

                dS.CT_PHIEUMUON.Rows.Add(ctRow);
                CT_PHIEUMUONTableAdapter.Update(dS.CT_PHIEUMUON);

            // Cập nhật trạng thái CHOMUON của sách sang true
                String maSach = cmbMAS.SelectedValue.ToString();
                DataRow sachRow = dS.SACH.Rows.Cast<DataRow>().FirstOrDefault(r => (String)r["MASACH"] == maSach);
                if (sachRow != null)
                {
                    sachRow["CHOMUON"] = true;
                    SACHTableAdapter.Update(dS.SACH);
                }

                MessageBox.Show("Đã thêm sách vào phiếu mượn thành công.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi mượn sách: " + ex.Message);
            //}
            //dS.EnforceConstraints = true;
        }

        private bool CheckIfReaderHasOverdueBooks(int maDG)
        {
            bool hasOverdueBooks = false;

            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("KiemTraQuaHan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDG", maDG);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) == 1)
                    {
                        hasOverdueBooks = true; 
                    }
                }
            }

            return hasOverdueBooks;
        }
        private void SetupColunmChoMuon()
        {
            cmbColHT.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Mượn về"),
                new KeyValuePair<bool, string>(false, "Mượn tại chỗ")
            };
            cmbColHT.DisplayMember = "Value";
            cmbColHT.ValueMember = "Key";
        }
    }
}
