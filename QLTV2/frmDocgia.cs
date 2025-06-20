using DevExpress.XtraRichEdit.Import.Html;
using QLTV2.DSTableAdapters;
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
    public partial class frmDocgia: Form
    {
        int vitri = 0;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter = new QLTV2.DSTableAdapters.NHANVIENTableAdapter();
        public frmDocgia()
        {
            InitializeComponent();
        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void SaveCurrentRowState(string action)
        {
            if (bdsDG.Current == null) return;

            DataRowView currentRowView = (DataRowView)bdsDG.Current;
            DataRow row = currentRowView.Row;
            object[] values = (object[])row.ItemArray.Clone();

            int realIndex = dS.DOCGIA.Rows.IndexOf(row); // vị trí trong danh sách gốc

            undoStack.Push(new UndoItem
            {
                ItemArray = values,
                Action = action,
                Index = bdsDG.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                RealIndex = realIndex    // vị trí thật trong danh sách gốc
            });
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {            
            try
            {
                this.DOCGIATableAdapter.Fill(this.dS.DOCGIA);
                this.NHANVIENTableAdapter.Fill(this.dS.NHANVIEN);
                this.PHIEUMUONTableAdapter.Fill(this.dS.PHIEUMUON);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Lỗi ràng buộc dữ liệu: " + ex.Message);
            }

            if (bdsDG.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            this.gcDG.CellValueChanged += gcDOCGIA_CellValueChanged;
            this.gcDG.CellBeginEdit += gcDOCGIA_CellBeginEdit;
            SetupGenderComboBox();
            SetupHoatDongComboBox();
            SetupColunmPhai();
            SetupColunmHD();
        }

        private void gcDOCGIA_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add" });
            vitri = bdsDG.Position;
            GroupBox1.Enabled = true;
            gcDG.Enabled = false;
            bdsDG.AddNew();
            dtpDOB.Value = DateTime.Now;
            dtpLAMTHE.Value = DateTime.Now;
            dtpHETHAN.Value = DateTime.Now;

            cmbPhai.SelectedValue = true;

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            txtHODG.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDG.Current == null) return;

            int maDG = Convert.ToInt32(((DataRowView)bdsDG.Current)["MADG"]);
            int soPhieuChuaTra = GetSoPhieuChuaTra(maDG);

            if (soPhieuChuaTra > 0)
            {
                MessageBox.Show("Độc giả đang có sách mượn chưa trả, không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete");
                    bdsDG.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa độc giả.\n" + ex.Message);
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtpHETHAN.Value.Date < dtpLAMTHE.Value.Date)
            {
                MessageBox.Show("Ngày hết hạn thẻ phải sau ngày làm thẻ.");
                dtpHETHAN.Focus();
                return;
            }

            try
            {
                bdsDG.EndEdit();
                bdsDG.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    DOCGIATableAdapter.Update(dS.DOCGIA);
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
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = true;
            gcDG.Enabled = true;
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();


                if (item.Action == "Add")
                {
                    if (bdsDG.Count > 0)
                    {
                        bdsDG.RemoveAt(bdsDG.Count - 1);
                    }
                }
                else if (item.Action == "Delete")
                {
                    // Tìm dòng đã bị xóa có cùng ISBN
                    var deletedRow = dS.DOCGIA.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["MADG", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                    if (deletedRow != null)
                    {
                        // Hủy xóa (rollback)
                        deletedRow.RejectChanges();
                    }
                    else
                    {
                        // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                        DataRow row = dS.DOCGIA.NewRow();
                        row.ItemArray = item.ItemArray;
                        dS.DOCGIA.Rows.InsertAt(row, item.Index);
                    }
                }
                else if (item.Action == "Edit")
                {
                    bdsDG.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                    DataRow current = ((DataRowView)bdsDG.Current).Row;
                    for (int i = 0; i < current.Table.Columns.Count; i++)
                    {
                        if (!current.Table.Columns[i].ReadOnly)
                        {
                            current[i] = item.ItemArray[i];
                        }
                    }
                }

                bdsDG.ResetBindings(false);
                gcDG.Refresh();
                MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDG.Current != null && bdsDG.IsBindingSuspended == false)
            {
                bdsDG.CancelEdit();
            }

            dS.PHIEUMUON.Clear();
            dS.NHANVIEN.Clear();
            dS.DOCGIA.Clear();

            DOCGIATableAdapter.Fill(dS.DOCGIA);
            NHANVIENTableAdapter.Fill(dS.NHANVIEN);
            PHIEUMUONTableAdapter.Fill(dS.PHIEUMUON);

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = true;
            GroupBox1.Enabled = false;
            gcDG.Enabled = true;
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gcDOCGIA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtpHETHAN.Value.Date < dtpLAMTHE.Value.Date)
            {
                MessageBox.Show("Ngày hết hạn thẻ phải sau ngày làm thẻ.");
                dtpHETHAN.Focus();
                return;
            }

            try
            {
                bdsDG.EndEdit();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        private int GetSoPhieuChuaTra(int maDG)
        {
            int soPhieu = 0;

            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("DemPhieuMuonChuaTra", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDG", maDG);

                    conn.Open();
                    object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên dòng đầu tiên
                    if (result != null && int.TryParse(result.ToString(), out int value))
                    {
                        soPhieu = value;
                    }
                }
            }

            return soPhieu;
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
            cmbPhai.DataBindings.Add("SelectedValue", bdsDG, "GIOITINH", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void SetupHoatDongComboBox()
        {
            cmbHD.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Hoạt động"),
                new KeyValuePair<bool, string>(false, "Không hoạt động")
            };
            cmbHD.DisplayMember = "Value";
            cmbHD.ValueMember = "Key";

            cmbHD.DataBindings.Clear();
            cmbHD.DataBindings.Add("SelectedValue", bdsDG, "HOATDONG", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnFindDG_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                bdsDG.Filter = ""; // Xóa lọc nếu không nhập gì
                bdsDG.RemoveFilter();
                isFilterActive = false;
                return;
            }

            keyword = keyword.Replace("'", "''");

            bdsDG.Filter = $"CONVERT(MADG, 'System.String') LIKE '%{keyword}%' OR (HODG + ' ' + TENDG) LIKE '%{keyword}%'";
            isFilterActive = true;

            if (bdsDG.Count == 0)
            {
                MessageBox.Show("Không tìm thấy độc giả nào phù hợp.");
                bdsDG.Filter = "";
            }
        }
        private void SetupColunmPhai()
        {
            cmbColPhai.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Nam"),
                new KeyValuePair<bool, string>(false, "Nữ")
            };
            cmbColPhai.DisplayMember = "Value";
            cmbColPhai.ValueMember = "Key";
        }
        private void SetupColunmHD()
        {
            cmbColHD.DataSource = new List<KeyValuePair<bool, string>>()
            {
                new KeyValuePair<bool, string>(true, "Hoạt động"),
                new KeyValuePair<bool, string>(false, "Không hoạt động")
            };
            cmbColHD.DisplayMember = "Value";
            cmbColHD.ValueMember = "Key";
        }
    }
}
