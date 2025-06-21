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
        private Dictionary<string, string> selectedISBNToMasach = new Dictionary<string, string>();

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
            GroupBox1.Enabled = GroupBox2.Enabled = false;
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
            //SetupNhanVienComboBox();
            SetupHinhThucComboBox();
            SetupMaSachComboBox();
            SetupNhanVienComboBoxColumn();
            SetupMaSachComboboxColumn();
            SetupMaNVNSComboboxColumn();
            SetupTraComboboxColunm();
            SetupTinhTrangComboboxColumn();
            SetupMaDGComboBoxColumn();
            SetupColunmChoMuon();
            this.gcPHIEUMUON.CellValueChanged += gcPHIEUMUON_CellValueChanged;
            this.gcPHIEUMUON.CellBeginEdit += gcPHIEUMUON_CellBeginEdit;
            cmbMADG.SelectedIndexChanged += cmbMADG_SelectedIndexChanged;
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

            DataGridViewComboBoxColumn colManv = gcPHIEUMUON.Columns["cmbMANVColumn"] as DataGridViewComboBoxColumn;

            if (colManv != null)
            {
                colManv.DataSource = dtNhanVien;
                colManv.DisplayMember = "DisplayText";
                colManv.ValueMember = "MANV";          
                colManv.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cột combobox 'MANV' trong DataGridView.");
            }
        }
        private void SetupMaDGComboBoxColumn()
        {
            DataTable dtDocGia = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "select MADG, CONCAT(HODG,' ', TENDG, ' - ', MADG) as TENDG from DOCGIA";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtDocGia);
            }

            DataGridViewComboBoxColumn colMadg = gcPHIEUMUON.Columns["cmbColMADG"] as DataGridViewComboBoxColumn;

            if (colMadg != null)
            {
                colMadg.DataSource = dtDocGia;
                colMadg.DisplayMember = "TENDG";
                colMadg.ValueMember = "MADG";
                colMadg.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cột combobox 'MANV' trong DataGridView.");
            }
        }
        private void SetupMaSachComboboxColumn()
        {
            DataTable dtDauSach = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = @"
                                SELECT s.MASACH, CONCAT('[', LTRIM(RTRIM(s.MASACH)), '] ', ds.TENSACH) AS DisplayText
                                FROM SACH s
                                JOIN DAUSACH ds ON s.ISBN = ds.ISBN";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtDauSach);
            }

            try
            {
                DataGridViewComboBoxColumn colMaSach = gcCT_PHIEUMUON.Columns["cmbColMaSach"] as DataGridViewComboBoxColumn;
                if (colMaSach != null)
                {
                    colMaSach.DataSource = dtDauSach;
                    colMaSach.DisplayMember = "DisplayText";
                    colMaSach.ValueMember = "MASACH";
                    colMaSach.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột combobox 'cmbColMaSach' trong DataGridView.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thiết lập ComboBoxColumn MASACH: " + ex.Message);
            }
        }
        private void SetupMaNVNSComboboxColumn()
        {
            DataTable dtNhanVien = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = "SELECT MANV, CONCAT(HONV, ' ', TENNV, ' - ', MANV) AS DisplayText FROM NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtNhanVien);
            }

            DataGridViewComboBoxColumn colManv = gcCT_PHIEUMUON.Columns["cmbColMANVNS"] as DataGridViewComboBoxColumn;

            if (colManv != null)
            {
                cmbColMANVNS.DataSource = dtNhanVien;
                cmbColMANVNS.DisplayMember = "DisplayText";
                cmbColMANVNS.ValueMember = "MANV";
                cmbColMANVNS.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cột combobox 'MANV' trong DataGridView.");
            }
        }
        private void SetupTinhTrangComboboxColumn()
        {
            cmbColTinhTrang.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Mới"),
                new KeyValuePair<bool, string>(false, "Cũ")
            };
            cmbColTinhTrang.DisplayMember = "Value";
            cmbColTinhTrang.ValueMember = "Key";
        }
        private void SetupTraComboboxColunm()
        {
            cmbColTRA.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Đã trả"),
                new KeyValuePair<bool, string>(false, "Chưa trả")
            };
            cmbColTRA.DisplayMember = "Value";
            cmbColTRA.ValueMember = "Key";

            //cmbTinhTrang.DataBindings.Clear();
            //cmbTinhTrang.DataBindings.Add("SelectedValue", bdsSach, "TINHTRANG", true, DataSourceUpdateMode.OnPropertyChanged);
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
            MessageBox.Show(Program.mId);
            undoStack.Push(new UndoItem { Action = "Add" });
            vitri = bdsPM.Position;
            GroupBox1.Enabled = GroupBox2.Enabled = true;
            gcPHIEUMUON.Enabled = false;
            bdsPM.AddNew();

            ((DataRowView)bdsPM.Current)["MANV"] = Convert.ToInt32(Program.mId);

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            cmbMADG.Focus();
            dtpNgaymuon.Format = DateTimePickerFormat.Custom;
            dtpNgaymuon.CustomFormat = "dd/MM/yyyy";
            dtpNgaymuon.Value = DateTime.Now;
            cmbHinhthuc.SelectedIndex = 0;
            cmbMADG.SelectedIndex = 0;
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
            // 1. Kiểm tra phiếu mượn hiện tại
            if (bdsPM.Current == null)
            {
                MessageBox.Show("Không có phiếu mượn nào để ghi.");
                return;
            }

            DataRowView currentPM = (DataRowView)bdsPM.Current;
            string maPhieu = currentPM["MAPHIEU"].ToString();

            // 2. Kiểm tra chi tiết phiếu mượn tương ứng
            var chiTietRows = dS.CT_PHIEUMUON.AsEnumerable()
                .Where(row => row.RowState != DataRowState.Deleted && row["MAPHIEU"].ToString() == maPhieu)
                .ToList();

            if (chiTietRows.Count == 0)
            {
                MessageBox.Show("Phiếu mượn phải có ít nhất một sách.");
                return;
            }

            try
            {
                this.Validate();
                bdsPM.EndEdit();
                bdsCT_PHIEUMUON.EndEdit();

                // 3. Ghi phiếu mượn trước
                PHIEUMUONTableAdapter.Update(dS.PHIEUMUON);

                // 4. Sau đó ghi chi tiết phiếu mượn
                CT_PHIEUMUONTableAdapter.Update(dS.CT_PHIEUMUON);

                // 5. Ghi trạng thái cho mượn của sách
                SACHTableAdapter.Update(dS.SACH);

                MessageBox.Show("Đã ghi phiếu mượn và chi tiết thành công.");
                selectedISBNToMasach.Clear();

                btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = true;
                btnGhi.Enabled = btnReload.Enabled = true;
                GroupBox1.Enabled = GroupBox2.Enabled = false;
                gcPHIEUMUON.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi dữ liệu: " + ex.Message);
            }
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
            if (bdsPM.Current != null && bdsPM.IsBindingSuspended == false)
            {
                bdsPM.CancelEdit();
            }

            if (bdsCT_PHIEUMUON.Current != null && bdsCT_PHIEUMUON.IsBindingSuspended == false)
            {
                bdsCT_PHIEUMUON.CancelEdit();
            }
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

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = true;
            GroupBox1.Enabled = GroupBox2.Enabled = false;
            gcPHIEUMUON.Enabled = true;
            selectedISBNToMasach.Clear();
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
        //private void SetupNhanVienComboBox()
        //{
        //    DataTable dtNhanVien = new DataTable();
        //    using (SqlConnection conn = new SqlConnection(Program.connstr))
        //    {
        //        string query = "select MANV, CONCAT(HONV,' ', TENNV, '-', MANV) as TENNV from NHANVIEN";
        //        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //        da.Fill(dtNhanVien);
        //    }
        //    cmbMANV.DataSource = dtNhanVien;
        //    cmbMANV.DisplayMember = "TENNV";
        //    cmbMANV.ValueMember = "MANV";

        //    cmbMANV.DataBindings.Clear();
        //    cmbMANV.DataBindings.Add("SelectedValue", bdsPM, "MANV", true, DataSourceUpdateMode.OnPropertyChanged);
        //}
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
        private bool IsReaderBorrowingISBN(int maDG, string isbn)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_KiemTraDauSachDaMuonBoiDocGia", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDG", maDG);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        return Convert.ToInt32(result) == 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi kiểm tra mượn đầu sách: " + ex.Message);
                        return false; 
                    }
                }
            }
        }
        private void SetupMaSachComboBox()
        {
            DataTable dtDauSach = new DataTable();
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string query = @"
            SELECT 
                ds.ISBN,
                ds.TENSACH AS DisplayName
            FROM 
                DAUSACH ds
            WHERE 
                EXISTS (
                    SELECT 1 FROM SACH s 
                    WHERE s.ISBN = ds.ISBN AND s.CHOMUON = 0
                )";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dtDauSach);
            }

            cmbMAS.DataSource = dtDauSach;
            cmbMAS.DisplayMember = "DisplayName";
            cmbMAS.ValueMember = "ISBN";

            if (dtDauSach.Rows.Count == 0)
            {
                MessageBox.Show("Tất cả các đầu sách hiện đều đã được mượn hết.");
            }

            cmbMAS.DataBindings.Clear();
            //cmbMAS.DataBindings.Add("SelectedValue", bdsPM, "MASACH", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            int maDG = Convert.ToInt32(cmbMADG.SelectedValue);
            int soSachChuaTra = GetSoSachChuaTra(maDG);
            bool isOverdue = CheckIfReaderHasOverdueBooks(maDG);
            string selectedISBN = cmbMAS.SelectedValue?.ToString();
            bool isReaderBorrowingISBN = IsReaderBorrowingISBN(maDG, selectedISBN);

            if (string.IsNullOrWhiteSpace(selectedISBN))
            {
                MessageBox.Show("Vui lòng chọn sách để mượn.");
                cmbMAS.Focus();
                return;
            }

            if (isOverdue)
            {
                MessageBox.Show("Độc giả này có sách mượn quá hạn, không thể mượn thêm.");
                return;
            }

            if (soSachChuaTra >= 3)
            {
                MessageBox.Show("Độc giả đã mượn đủ 3 cuốn sách chưa trả.");
                return;
            }

            if (isReaderBorrowingISBN)
            {
                MessageBox.Show("Độc giả đã mượn đầu sách này rồi.");
                return;
            }

            if (selectedISBNToMasach.ContainsKey(selectedISBN))
            {
                MessageBox.Show("Bạn đã chọn một sách thuộc đầu sách này rồi.");
                return;
            }

            if (selectedISBNToMasach.Count >= 3)
            {
                MessageBox.Show("Chỉ được mượn tối đa 3 sách trong một phiếu mượn.");
                return;
            }

            // Tìm mã sách chưa được mượn từ đầu sách đã chọn
            string selectedMaSach = null;
            foreach (DataRow row in dS.SACH.Rows)
            {
                if (row["ISBN"].ToString() == selectedISBN && !(bool)row["CHOMUON"])
                {
                    selectedMaSach = row["MASACH"].ToString();
                    break;
                }
            }

            if (selectedMaSach == null)
            {
                MessageBox.Show("Tất cả sách của đầu sách này đã được mượn.");
                return;
            }

            // Nếu chưa có phiếu mượn hiện tại, thì thêm mới
            if (bdsPM.Current == null)
            {
                bdsPM.AddNew();
                ((DataRowView)bdsPM.Current)["MADG"] = maDG;
                ((DataRowView)bdsPM.Current)["MANV"] = Convert.ToInt32(Program.mId);
                ((DataRowView)bdsPM.Current)["NGAYMUON"] = DateTime.Now;
                ((DataRowView)bdsPM.Current)["HINHTHUC"] = cmbHinhthuc.SelectedValue;
            }

            bdsPM.EndEdit();
            bdsPM.ResetCurrentItem();

            // Thêm dòng chi tiết phiếu mượn vào DataSet (chưa update DB)
            DataRow ctRow = dS.CT_PHIEUMUON.NewRow();
            ctRow["MAPHIEU"] = ((DataRowView)bdsPM.Current)["MAPHIEU"];
            ctRow["MASACH"] = selectedMaSach;
            ctRow["TINHTRANGMUON"] = 1;
            ctRow["TRA"] = 0;

            dS.CT_PHIEUMUON.Rows.Add(ctRow);

            // Gán tạm CHOMUON trong bộ nhớ (chưa update DB)
            DataRow sachRow = dS.SACH.Rows.Cast<DataRow>().FirstOrDefault(r => r["MASACH"].ToString() == selectedMaSach);
            if (sachRow != null)
            {
                sachRow["CHOMUON"] = true;
            }

            bdsCT_PHIEUMUON.ResetBindings(false);
            selectedISBNToMasach[selectedISBN] = selectedMaSach;
            MessageBox.Show("Đã thêm sách vào phiếu mượn. Nhấn 'Ghi' để lưu vào cơ sở dữ liệu.");
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
        private void cmbMADG_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã phiếu mượn hiện tại (có thể là null hoặc chuỗi rỗng nếu chưa lưu)
            string currentMaPhieu = bdsPM.Current != null ? ((DataRowView)bdsPM.Current)["MAPHIEU"]?.ToString() : "";

            foreach (var pair in selectedISBNToMasach)
            {
                string maSach = pair.Value;

                // Xóa các dòng CT_PHIEUMUON thuộc phiếu hiện tại và mã sách trùng
                foreach (DataRow ctRow in dS.CT_PHIEUMUON.Rows.Cast<DataRow>().ToList())
                {
                    if (ctRow.RowState != DataRowState.Deleted &&
                        ctRow["MASACH"].ToString() == maSach &&
                        string.Equals(ctRow["MAPHIEU"]?.ToString(), currentMaPhieu, StringComparison.OrdinalIgnoreCase))
                    {
                        // Reset lại CHOMUON trong bảng SACH
                        DataRow sachRow = dS.SACH.Rows.Cast<DataRow>()
                            .FirstOrDefault(r => r["MASACH"].ToString() == maSach);

                        if (sachRow != null)
                        {
                            sachRow["CHOMUON"] = false;
                        }

                        ctRow.Delete();
                    }
                }
            }

            selectedISBNToMasach.Clear();
            bdsCT_PHIEUMUON.ResetBindings(false);
            SetupMaSachComboBox(); // cập nhật lại danh sách có thể chọn
        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            if (gcCT_PHIEUMUON.CurrentRow == null || gcCT_PHIEUMUON.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa.");
                return;
            }

            DataGridViewRow selectedRow = gcCT_PHIEUMUON.CurrentRow;
            string maSach = selectedRow.Cells["cmbColMaSach"].Value?.ToString();

            if (string.IsNullOrEmpty(maSach))
            {
                MessageBox.Show("Không thể xác định mã sách để xóa.");
                return;
            }

            // 1. Tìm dòng trong CT_PHIEUMUON theo MASACH
            foreach (DataRow ctRow in dS.CT_PHIEUMUON.Rows.Cast<DataRow>().ToList())
            {
                if (ctRow.RowState != DataRowState.Deleted && ctRow["MASACH"].ToString() == maSach)
                {
                    ctRow.Delete();
                }
            }

            // 2. Gỡ mã sách khỏi selectedISBNToMasach
            string isbnToRemove = selectedISBNToMasach.FirstOrDefault(x => x.Value == maSach).Key;
            if (!string.IsNullOrEmpty(isbnToRemove))
            {
                selectedISBNToMasach.Remove(isbnToRemove);
            }

            // 3. Cập nhật lại trạng thái CHOMUON trong bảng SACH
            DataRow sachRow = dS.SACH.Rows.Cast<DataRow>().FirstOrDefault(r => r["MASACH"].ToString() == maSach);
            if (sachRow != null)
            {
                sachRow["CHOMUON"] = false;
            }

            bdsCT_PHIEUMUON.ResetBindings(false);
            SetupMaSachComboBox(); // làm mới lại danh sách đầu sách có thể mượn
            MessageBox.Show("Đã xóa sách khỏi phiếu mượn.");
        }

    }
}
