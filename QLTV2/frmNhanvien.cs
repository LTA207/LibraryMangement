using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLTV2
{
    public partial class frmNhanvien: Form
    {
        int vitri = 0;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.SACHTableAdapter SACHTableAdapter = new QLTV2.DSTableAdapters.SACHTableAdapter();
        private QLTV2.DSTableAdapters.DOCGIATableAdapter DOCGIATableAdapter = new QLTV2.DSTableAdapters.DOCGIATableAdapter();
        private QLTV2.DSTableAdapters.DAUSACHTableAdapter DAUSACHTableAdapter = new QLTV2.DSTableAdapters.DAUSACHTableAdapter();
        private QLTV2.DSTableAdapters.NGANTUTableAdapter NGANTUTableAdapter = new QLTV2.DSTableAdapters.NGANTUTableAdapter();
        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.THELOAITableAdapter THELOAITableAdapter = new QLTV2.DSTableAdapters.THELOAITableAdapter();

        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void SaveCurrentRowState(string action)
        {
            if (bdsNV.Current == null) return;

            DataRowView currentRowView = (DataRowView)bdsNV.Current;
            DataRow row = currentRowView.Row;
            object[] values = (object[])row.ItemArray.Clone();

            int realIndex = dS.DAUSACH.Rows.IndexOf(row); // vị trí trong danh sách gốc

            undoStack.Push(new UndoItem
            {
                ItemArray = values,
                Action = action,
                Index = bdsNV.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                RealIndex = realIndex    // vị trí thật trong danh sách gốc
            });
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            try
            {
                this.THELOAITableAdapter.Connection.ConnectionString = Program.connstr;
                this.THELOAITableAdapter.Fill(this.dS.THELOAI);

                this.NGANTUTableAdapter.Fill(this.dS.NGANTU);

                this.NGONNGUTableAdapter.Fill(this.dS.NGONNGU);

                this.DAUSACHTableAdapter.Fill(this.dS.DAUSACH);

                this.SACHTableAdapter.Fill(this.dS.SACH);

                this.DOCGIATableAdapter.Fill(this.dS.DOCGIA);


                this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);

                this.PHIEUMUONTableAdapter.Fill(this.dS.PHIEUMUON);

                this.CT_PHIEUMUONTableAdapter.Fill(this.dS.CT_PHIEUMUON);
            }
            catch (ConstraintException ex)
            {
                // Lặp qua các bảng để kiểm tra lỗi cụ thể
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

                MessageBox.Show("Lỗi ràng buộc: " + ex.Message);
            }
            if (bdsNV.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            
            this.gcNV.CellValueChanged += gcNV_CellValueChanged;
            this.gcNV.CellBeginEdit += gcNV_CellBeginEdit;
            SetupGenderComboBox();
            SetupGenderComboBoxColumn();
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add" });

            vitri = bdsNV.Position;
            GroupBox1.Enabled = true;
            gcNV.Enabled = false;
            bdsNV.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = btnReload.Enabled = true;
            txtMANV.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsPM.Count > 0)
            {
                MessageBox.Show("Nhân viên đã lập phiếu nên không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete");
                    bdsNV.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên.\n" + ex.Message);
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHO.Text))
            {
                MessageBox.Show("Họ nhân viên không được thiếu.");
                txtHO.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTEN.Text))
            {
                MessageBox.Show("Tên nhân viên không được thiếu.");
                txtTEN.Focus();
                return;
            }

            string manv = txtMANV.Text.Trim();
            if (bdsNV.Cast<DataRowView>().Any(r => r != bdsNV.Current && r["MANV"].ToString() == manv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                txtMANV.Focus();
                return;
            }

            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    NHANVIENTableAdapter.Update(dS.NHANVIEN);
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
                    MessageBox.Show("Mã nhân viên bị trùng.");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi nhân viên. " + Environment.NewLine + ex.Message);
                }
                return;
            }

            btnGhi.Enabled = btnPhuchoi.Enabled = GroupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = true;
            gcNV.Enabled = true;
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();

                if (item.Action == "Add")
                {
                    if (bdsNV.Count > 0)
                    {
                        bdsNV.RemoveAt(bdsNV.Count - 1);
                    }
                }
                else if (item.Action == "Delete")
                {
                    // Tìm dòng đã bị xóa có cùng ISBN
                    var deletedRow = dS.NHANVIEN.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["MANV", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                    if (deletedRow != null)
                    {
                        // Hủy xóa (rollback)
                        deletedRow.RejectChanges();
                    }
                    else
                    {
                        // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                        DataRow row = dS.NHANVIEN.NewRow();
                        row.ItemArray = item.ItemArray;
                        dS.NHANVIEN.Rows.InsertAt(row, item.Index);
                    }
                }
                else if (item.Action == "Edit")
                {
                    bdsNV.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                    DataRow current = ((DataRowView)bdsNV.Current).Row;
                    for (int i = 0; i < current.Table.Columns.Count; i++)
                    {
                        if (!current.Table.Columns[i].ReadOnly)
                        {
                            current[i] = item.ItemArray[i];
                        }
                    }
                }

                bdsNV.ResetBindings(false);
                gcNV.Refresh();
                MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xóa bảng con trước bảng cha
            dS.CT_PHIEUMUON.Clear();
            dS.SACH.Clear();
            dS.DAUSACH.Clear();
            dS.PHIEUMUON.Clear();
            dS.NHANVIEN.Clear();
            dS.THELOAI.Clear();
            dS.NGANTU.Clear();
            dS.NGONNGU.Clear();
            dS.DOCGIA.Clear();

            THELOAITableAdapter.Fill(dS.THELOAI);

            NGANTUTableAdapter.Fill(dS.NGANTU);

            NGONNGUTableAdapter.Fill(dS.NGONNGU);

            DAUSACHTableAdapter.Fill(dS.DAUSACH);

            SACHTableAdapter.Fill(dS.SACH);

            DOCGIATableAdapter.Fill(dS.DOCGIA);

            // Fill theo thứ tự
            NHANVIENTableAdapter.Fill(dS.NHANVIEN);
            PHIEUMUONTableAdapter.Fill(dS.PHIEUMUON);
            CT_PHIEUMUONTableAdapter.Fill(dS.CT_PHIEUMUON);
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void SetupGenderComboBox()
        {
            cmbPhai.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Nam"),
                new KeyValuePair<bool, string>(false, "Nữ")
            };
            cmbPhai.DisplayMember = "Value";
            cmbPhai.ValueMember = "Key";

            cmbPhai.DataBindings.Clear();
            cmbPhai.DataBindings.Add("SelectedValue", bdsNV, "GIOITINH", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void gcNV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bdsNV.EndEdit();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        private void gcNV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit");
        }

        private void btnFindNV_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                bdsNV.Filter = "";
                bdsNV.RemoveFilter();
                isFilterActive = false;
                return;
            }

            keyword = keyword.Replace("'", "''");

            bdsNV.Filter = $"CONVERT(MANV, 'System.String') LIKE '%{keyword}%' OR (HONV + ' ' + TENNV) LIKE '%{keyword}%'";
            isFilterActive = true;

            if (bdsNV.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.");
                bdsNV.Filter = "";
            }
        }

        private void SetupGenderComboBoxColumn()
        {
            var genderList = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Nam"),
                new KeyValuePair<bool, string>(false, "Nữ")
            };

            cmbColPhai.DataSource = genderList;
            cmbColPhai.DisplayMember = "Value";
            cmbColPhai.ValueMember = "Key";
        }

    }
}


