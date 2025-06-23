using DevExpress.XtraRichEdit.Import.Html;
using QLTV2.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmSach: Form
    {
        int vitri = 0;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.THELOAITableAdapter THELOAITableAdapter = new QLTV2.DSTableAdapters.THELOAITableAdapter();
        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.NGANTUTableAdapter NGANTUTableAdapter = new QLTV2.DSTableAdapters.NGANTUTableAdapter();

        public frmSach()
        {
            InitializeComponent();
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            if(undoStack.Count == 0)
            {
                btnPhuchoi.Enabled = false;
            }
            else
            {
                btnPhuchoi.Enabled = true;
            }
                try
                {
                    this.THELOAITableAdapter.Fill(dS.THELOAI);
                    this.NGANTUTableAdapter.Fill(dS.NGANTU);
                    this.NGONNGUTableAdapter.Fill(dS.NGONNGU);
                    this.DAUSACHTableAdapter.Fill(dS.DAUSACH);
                    this.SACHTableAdapter.Fill(dS.SACH);
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show("Lỗi ràng buộc dữ liệu: " + ex.Message);
                }

            if (bdsDS.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            txtSotrang.KeyPress += ChiNhapSo_KeyPress;
            txtLanxuatban.KeyPress += ChiNhapSo_KeyPress;
            txtGia.KeyPress += ChiNhapSo_KeyPress;

            SetupTheLoaiComboBox();
            SetupNgonNguComboBox();
            this.gcDAUSACH.CellValueChanged += gcDAUSACH_CellValueChanged;
            this.gcDAUSACH.CellBeginEdit += gcDAUSACH_CellBeginEdit;
            this.gcDAUSACH.CellValidating += gcDAUSACH_CellValidating;
            this.gcDAUSACH.EditingControlShowing += gcDAUSACH_EditingControlShowing;

            SetupNganTuComboBox();
            SetupTinhTrangComboBox();
            SetupChoMuonComboBox();

            SetupColunmTinhTrang();
            SetupColunmChoMuon();
            GroupBox1.Enabled = GroupBox2.Enabled = false;
            GroupBox3.Enabled = true;
        }

        private void SaveCurrentRowState(string action, string table)
        {
            if (bdsDS.Current == null) return;

            if (table == "DAUSACH")
            {
                DataRowView currentRowView = (DataRowView)bdsDS.Current;
                DataRow row = currentRowView.Row;
                object[] values = (object[])row.ItemArray.Clone();

                int realIndex = dS.DAUSACH.Rows.IndexOf(row); // vị trí trong danh sách gốc

                undoStack.Push(new UndoItem
                {
                    ItemArray = values,
                    TableName = table,
                    Action = action,
                    Index = bdsDS.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                    RealIndex = realIndex    // vị trí thật trong danh sách gốc
                });
            }
            else
            {
                DataRowView currentRowView = (DataRowView)bdsSach.Current;
                DataRow row = currentRowView.Row;
                object[] values = (object[])row.ItemArray.Clone();

                int realIndex = dS.SACH.Rows.IndexOf(row); // vị trí trong danh sách gốc

                undoStack.Push(new UndoItem
                {
                    ItemArray = values,
                    TableName = table,
                    Action = action,
                    Index = bdsSach.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                    RealIndex = realIndex    // vị trí thật trong danh sách gốc
                });
            }
        }
        private void gcDAUSACH_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit", "DAUSACH");
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add", TableName = "DAUSACH" });
            vitri = bdsDS.Position;
            GroupBox1.Enabled = true;
            gcDAUSACH.Enabled = gcSACH.Enabled = false;
            dtpNSB.Value = DateTime.Now;
            bdsDS.AddNew();

            btnThem.Enabled = btnXoa.Enabled = GroupBox3.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = gcSACH.Enabled = contextMenuStrip1.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            txtISBN.Focus();

            cmbMATL.SelectedIndex = 0;
            cmbMANN.SelectedIndex = 0;
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSach.Count > 0)
            {
                MessageBox.Show("Đầu sách đã có sách, không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa đầu sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete", "DAUSACH");
                    bdsDS.RemoveCurrent();
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
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Mã đầu sách không được thiếu.");
                txtISBN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTensach.Text))
            {
                MessageBox.Show("Tên sách không được thiếu.");
                txtTensach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKhosach.Text))
            {
                MessageBox.Show("Kho sách không được thiếu.");
                txtKhosach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoidung.Text))
            {
                MessageBox.Show("Nội dung không được thiếu.");
                txtNoidung.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHinh.Text))
            {
                MessageBox.Show("Hình ảnh không được thiếu.");
                txtHinh.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLanxuatban.Text))
            {
                MessageBox.Show("Lần xuất bản không được thiếu.");
                txtLanxuatban.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Giá không được thiếu.");
                txtGia.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSotrang.Text))
            {
                MessageBox.Show("Số trang không được thiếu.");
                txtSotrang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNhaXB.Text))
            {
                MessageBox.Show("Nhà xuất bản không được thiếu.");
                txtNhaXB.Focus();
                return;
            }

            string ISBN = txtISBN.Text.Trim();
            if (bdsDS.Cast<DataRowView>().Any(r => r != bdsDS.Current && r["ISBN"].ToString() == ISBN))
            {
                MessageBox.Show("Mã đầu sách này đã tồn tại. Vui lòng nhập mã khác.");
                txtISBN.Focus();
                return;
            }

            try
            {
                bdsDS.EndEdit();
                bdsDS.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    DAUSACHTableAdapter.Update(dS.DAUSACH);
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

            btnGhi.Enabled = btnXoa.Enabled = btnThem.Enabled = GroupBox3.Enabled = contextMenuStrip1.Enabled = true;
            if(undoStack.Count != 0)
            {
                btnPhuchoi.Enabled = true;
            }
            else
            {
                btnPhuchoi.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            gcDAUSACH.Enabled = gcSACH.Enabled = true;
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();

                if (item.TableName == "DAUSACH")
                {
                    if (item.Action == "Add")
                    {
                        if (bdsDS.Count > 0)
                        {
                            bdsDS.RemoveAt(bdsDS.Count - 1);
                            //DAUSACHTableAdapter.Update(dS.DAUSACH);
                        }
                    }
                    else if (item.Action == "Delete")
                    {
                        // Tìm dòng đã bị xóa có cùng ISBN
                        var deletedRow = dS.DAUSACH.Rows
                            .Cast<DataRow>()
                            .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["ISBN", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                        if (deletedRow != null)
                        {
                            // Hủy xóa (rollback)
                            deletedRow.RejectChanges();
                        }
                        else
                        {
                            // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                            DataRow row = dS.DAUSACH.NewRow();
                            row.ItemArray = item.ItemArray;
                            dS.DAUSACH.Rows.InsertAt(row, item.Index);
                        }
                    }
                    else if (item.Action == "Edit")
                    {
                        bdsDS.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                        DataRow current = ((DataRowView)bdsDS.Current).Row;
                        for (int i = 0; i < current.Table.Columns.Count; i++)
                        {
                            if (!current.Table.Columns[i].ReadOnly)
                            {
                                current[i] = item.ItemArray[i];
                            }
                        }
                    }

                    bdsDS.ResetBindings(false);
                    gcDAUSACH.Refresh();
                }
                else
                {
                    if(item.Action == "Add")
                    {
                        if(bdsSach.Count > 0)
                        {
                            bdsSach.RemoveAt(bdsSach.Count - 1);
                        }
                    }
                    else if (item.Action == "Delete")
                    {
                        // Tìm dòng đã bị xóa có cùng ISBN
                        var deletedRow = dS.SACH.Rows
                            .Cast<DataRow>()
                            .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["MASACH", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                        if (deletedRow != null)
                        {
                            // Hủy xóa (rollback)
                            deletedRow.RejectChanges();
                        }
                        else
                        {
                            // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                            DataRow row = dS.SACH.NewRow();
                            row.ItemArray = item.ItemArray;
                            dS.SACH.Rows.InsertAt(row, item.Index);
                        }
                    }
                }
                    MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
            if(undoStack.Count == 0)
            {
                btnPhuchoi.Enabled = false;
            }
            else
            {
                btnPhuchoi.Enabled = true;
            }

        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDS.Current != null && bdsDS.IsBindingSuspended == false)
            {
                bdsDS.CancelEdit();
            }

            if (bdsSach.Current != null && bdsSach.IsBindingSuspended == false)
            {
                bdsSach.CancelEdit();
            }

            dS.SACH.Clear();
            dS.DAUSACH.Clear();
            dS.THELOAI.Clear();
            dS.NGANTU.Clear();
            dS.NGONNGU.Clear();

            THELOAITableAdapter.Fill(dS.THELOAI);

            NGANTUTableAdapter.Fill(dS.NGANTU);

            NGONNGUTableAdapter.Fill(dS.NGONNGU);

            DAUSACHTableAdapter.Fill(dS.DAUSACH);

            SACHTableAdapter.Fill(dS.SACH);

            bdsDS.Filter = "";
            bdsDS.RemoveFilter();
            isFilterActive = false;
            txtTimkiem.Clear();

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = GroupBox3.Enabled = contextMenuStrip1.Enabled = btnGhi.Enabled = true;
            GroupBox1.Enabled = GroupBox2.Enabled = false;
            gcDAUSACH.Enabled = gcSACH.Enabled = true;

            if(undoStack.Count == 0)
            {
                btnPhuchoi.Enabled = false;
            }
            else
            {
                btnPhuchoi.Enabled = true;
            }
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void SetupTheLoaiComboBox()
        {
            cmbMATL.DataSource = dS.THELOAI;
            cmbMATL.DisplayMember = "THELOAI";
            cmbMATL.ValueMember = "MaTL";

            cmbMATL.DataBindings.Clear();
            cmbMATL.DataBindings.Add("SelectedValue", bdsDS, "MaTL", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void SetupNgonNguComboBox()
        {
            cmbMANN.DataSource = dS.NGONNGU;
            cmbMANN.DisplayMember = "NGONNGU";
            cmbMANN.ValueMember = "MANGONNGU";

            cmbMANN.DataBindings.Clear();
            cmbMANN.DataBindings.Add("SelectedValue", bdsDS, "MANGONNGU", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void gcDAUSACH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgv.Rows[e.RowIndex];
            string dataProperty = dgv.Columns[e.ColumnIndex].DataPropertyName;
            object value = row.Cells[e.ColumnIndex].Value;

            string[] requiredColumns = {
        "ISBN", "Tensach", "Khosach", "Noidung", "HinhAnhPath",
        "Lanxuatban", "Sotrang", "Gia", "NXB", "MANGONNGU", "MaTL"
    };

            if (requiredColumns.Contains(dataProperty) && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
            {
                MessageBox.Show($"{dataProperty} không được để trống.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (undoStack.Count > 0 && undoStack.Peek().Action == "Edit")
                {
                    var lastEdit = undoStack.Peek();
                    int columnIndex = dgv.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == dataProperty).Index;
                    dgv.Rows[e.RowIndex].Cells[columnIndex].Value = lastEdit.ItemArray[columnIndex];
                }

                return; 
            }

            try
            {
                bdsDS.EndEdit();
                //MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnMenuThem_Click(object sender, EventArgs e)
        {

            undoStack.Push(new UndoItem { Action = "Add", TableName = "SACH" });
            vitri = bdsDS.Position;
            GroupBox2.Enabled = true;
            gcSACH.Enabled = false;

            DataRowView newRow = (DataRowView)bdsSach.AddNew();
            newRow["CHOMUON"] = false;

            btnThem.Enabled = btnXoa.Enabled = contextMenuStrip1.Enabled = btnThoat.Enabled = btnGhi.Enabled = contextMenuStrip1.Enabled = btnPhuchoi.Enabled =false;
            btnReload.Enabled = true;
            gcDAUSACH.Enabled = gcSACH.Enabled = false;
            txtMAS.Focus();
        }

        private void btnGhisach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMAS.Text))
            {
                MessageBox.Show("Mã sách không được thiếu.");
                txtMAS.Focus();
                return;
            }

            string MaSach = txtMAS.Text.Trim();
            if (bdsSach.Cast<DataRowView>().Any(r => r != bdsSach.Current && r["MASACH"].ToString() == MaSach))
            {
                MessageBox.Show("Mã sách này đã tồn tại. Vui lòng nhập mã khác.");
                txtMAS.Focus();
                return;
            }

            try
            {

                bdsSach.EndEdit();
                bdsSach.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    SACHTableAdapter.Update(dS.SACH);
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
            if(undoStack.Count == 0)
            {
                btnPhuchoi.Enabled = false;
            }
            else
            {
                btnPhuchoi.Enabled = true;
            }
            gcDAUSACH.Enabled = gcSACH.Enabled = true;
            GroupBox1.Enabled = GroupBox2.Enabled = false;
            GroupBox3.Enabled = true;
            btnGhi.Enabled = btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = contextMenuStrip1.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                bdsDS.Filter = ""; // Xóa lọc nếu không nhập gì
                bdsDS.RemoveFilter();
                isFilterActive = false;
                return;
            }

            // Escape ký tự đơn nếu người dùng nhập vào dấu nháy đơn
            keyword = keyword.Replace("'", "''");

            // Tìm theo MANV hoặc TEN (dùng LIKE)
            bdsDS.Filter = $"ISBN LIKE '%{keyword}%' OR Tensach LIKE '%{keyword}%'";
            isFilterActive = true;

            if (bdsDS.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.");
                bdsDS.Filter = ""; 
            }
        }

        private void btnMenuXoa_Click(object sender, EventArgs e)
        {
            if (bdsCT_PHIEUMUON.Count > 0)
            {
                MessageBox.Show("Sách đã có chi tiết phiếu mượn, không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa đầu sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete", "SACH");
                    bdsSach.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sách.\n" + ex.Message);
                    return;
                }
            }
        }

        private void SetupNganTuComboBox()
        {
            cmbMANT.DataSource = dS.NGANTU;
            cmbMANT.DisplayMember = "KE";
            cmbMANT.ValueMember = "MANGANTU";

            cmbMANT.DataBindings.Clear();
            cmbMANT.DataBindings.Add("SelectedValue", bdsSach, "MANGANTU", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetupTinhTrangComboBox()
        {
            cmbTT.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Có thể cho mượn"),
                new KeyValuePair<bool, string>(false, "Đã thanh lý")
            };
            cmbTT.DisplayMember = "Value";
            cmbTT.ValueMember = "Key";

            cmbTT.DataBindings.Clear();
            cmbTT.DataBindings.Add("SelectedValue", bdsSach, "TINHTRANG", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetupChoMuonComboBox()
        {
            cmbCM.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Đã được mượn"),
                new KeyValuePair<bool, string>(false, "Chưa được mượn")
            };
            cmbCM.DisplayMember = "Value";
            cmbCM.ValueMember = "Key";

            cmbCM.SelectedValue = false;

            cmbCM.DataBindings.Clear();
            cmbCM.DataBindings.Add("SelectedValue", bdsSach, "CHOMUON", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetupColunmTinhTrang()
        {
            cmbTinhTrang.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Có thể cho mượn"),
                new KeyValuePair<bool, string>(false, "Đã thanh lý")
            };
            cmbTinhTrang.DisplayMember = "Value";
            cmbTinhTrang.ValueMember = "Key";

            //cmbTinhTrang.DataBindings.Clear();
            //cmbTinhTrang.DataBindings.Add("SelectedValue", bdsSach, "TINHTRANG", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetupColunmChoMuon()
        {
            cmbChoMuon.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Đã cho mượn"),
                new KeyValuePair<bool, string>(false, "Chưa cho mượn")
            };
            cmbChoMuon.DisplayMember = "Value";
            cmbChoMuon.ValueMember = "Key";

            //cmbTinhTrang.DataBindings.Clear();
            //cmbTinhTrang.DataBindings.Add("SelectedValue", bdsSach, "TINHTRANG", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void gcDAUSACH_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string dataProperty = dgv.Columns[e.ColumnIndex].DataPropertyName;

            // Các cột chỉ cho nhập số
            string[] numericColumns = { "Gia", "Sotrang", "Lanxuatban" };

            if (numericColumns.Contains(dataProperty))
            {
                string input = e.FormattedValue?.ToString() ?? "";
                if (!int.TryParse(input, out _)) // kiểm tra xem có phải số nguyên
                {
                    MessageBox.Show($"{dataProperty} chỉ được nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; // hủy thay đổi
                }
            }
        }
        private void OnlyAllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn luôn khi nhập không phải số
            }
        }

        private void gcDAUSACH_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (txt == null) return;

            txt.KeyPress -= OnlyAllowDigits_KeyPress; // tránh đăng ký nhiều lần
            int colIndex = gcDAUSACH.CurrentCell.ColumnIndex;
            string dataProperty = gcDAUSACH.Columns[colIndex].DataPropertyName;

            // Nếu là cột số thì gắn sự kiện chỉ cho nhập số
            if (dataProperty == "Gia" || dataProperty == "Sotrang" || dataProperty == "Lanxuatban")
            {
                txt.KeyPress += OnlyAllowDigits_KeyPress;
            }
        }


    }
}
