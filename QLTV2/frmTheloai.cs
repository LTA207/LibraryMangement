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
    public partial class frmTheloai: Form
    {
        int vitri = 0;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.NGANTUTableAdapter NGANTUTableAdapter = new QLTV2.DSTableAdapters.NGANTUTableAdapter();

        public frmTheloai()
        {
            InitializeComponent();
        }

        private void tHELOAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTL.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void SaveCurrentRowState(string action)
        {
            if (bdsTL.Current == null) return;

            DataRowView currentRowView = (DataRowView)bdsTL.Current;
            DataRow row = currentRowView.Row;
            object[] values = (object[])row.ItemArray.Clone();

            int realIndex = dS.THELOAI.Rows.IndexOf(row); // vị trí trong danh sách gốc

            undoStack.Push(new UndoItem
            {
                ItemArray = values,
                Action = action,
                Index = bdsTL.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                RealIndex = realIndex    // vị trí thật trong danh sách gốc
            });
        }

        private void frmTheloai_Load(object sender, EventArgs e)
        {
            try
            {
                this.THELOAITableAdapter.Fill(dS.THELOAI);
                this.NGANTUTableAdapter.Fill(dS.NGANTU);
                this.NGONNGUTableAdapter.Fill(dS.NGONNGU);
                this.DAUSACHTableAdapter.Fill(this.dS.DAUSACH);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Lỗi ràng buộc dữ liệu: " + ex.Message);
            }

            if (bdsTL.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            this.gcTL.CellValueChanged += gcTHELOAI_CellValueChanged;
            this.gcTL.CellBeginEdit += gcTHELOAI_CellBeginEdit;
        }

        private void gcTHELOAI_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add" });
            vitri = bdsTL.Position;
            GroupBox1.Enabled = true;
            gcTL.Enabled = false;
            bdsTL.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            txtMATL.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDS.Count > 0 )
            {
                MessageBox.Show("Đầu sách đã có thể loại này, không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa thể loại này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete");
                    bdsTL.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thể loại.\n" + ex.Message);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMATL.Text))
            {
                MessageBox.Show("Mã thể loại không được thiếu.");
                txtMATL.Focus();
                return;
            }

            string tenTL = txtTENTL.Text.Trim();
            if (bdsTL.Cast<DataRowView>().Any(r => r != bdsTL.Current && r["THELOAI"].ToString() == tenTL))
            {
                MessageBox.Show("Tên thể loại này đã tồn tại. Vui lòng nhập mã khác.");
                txtTENTL.Focus();
                return;
            }

            try
            {
                bdsTL.EndEdit();
                bdsTL.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    THELOAITableAdapter.Update(dS.THELOAI);
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
            gcTL.Enabled = true;
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();


                if (item.Action == "Add")
                {
                    if (bdsTL.Count > 0 && dS.HasChanges())
                    {
                        bdsTL.RemoveAt(bdsTL.Count - 1);
                    }
                }
                else if (item.Action == "Delete")
                {
                    // Tìm dòng đã bị xóa có cùng ISBN
                    var deletedRow = dS.THELOAI.Rows
                        .Cast<DataRow>()
                        .FirstOrDefault(r => r.RowState == DataRowState.Deleted && r["THELOAI", DataRowVersion.Original].ToString() == item.ItemArray[0].ToString());

                    if (deletedRow != null)
                    {
                        // Hủy xóa (rollback)
                        deletedRow.RejectChanges();
                    }
                    else
                    {
                        // Nếu không tìm thấy dòng đã bị xóa, thêm lại từ ItemArray
                        DataRow row = dS.THELOAI.NewRow();
                        row.ItemArray = item.ItemArray;
                        dS.THELOAI.Rows.InsertAt(row, item.Index);
                    }
                }
                else if (item.Action == "Edit")
                {
                    bdsTL.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                    DataRow current = ((DataRowView)bdsTL.Current).Row;

                    for (int i = 0; i < current.Table.Columns.Count; i++)
                    {
                        MessageBox.Show(item.ItemArray[i].ToString());
                        if (!current.Table.Columns[i].ReadOnly)
                        {
                            current[i] = item.ItemArray[i];
                        }
                    }
                }

                bdsTL.ResetBindings(false);
                gcTL.Refresh();
                MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTL.Current != null && bdsTL.IsBindingSuspended == false)
            {
                bdsTL.CancelEdit();
            }

            dS.DAUSACH.Clear();
            dS.THELOAI.Clear();
            dS.NGANTU.Clear();
            dS.NGONNGU.Clear();

            THELOAITableAdapter.Fill(dS.THELOAI);

            NGANTUTableAdapter.Fill(dS.NGANTU);

            NGONNGUTableAdapter.Fill(dS.NGONNGU);

            DAUSACHTableAdapter.Fill(dS.DAUSACH);

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = true;
            GroupBox1.Enabled = false;
            gcTL.Enabled = true;
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void gcTHELOAI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bdsTL.EndEdit();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnFindTL_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                bdsTL.Filter = ""; // Xóa lọc nếu không nhập gì
                bdsTL.RemoveFilter();
                isFilterActive = false;
                return;
            }

            // Escape ký tự đơn nếu người dùng nhập vào dấu nháy đơn
            keyword = keyword.Replace("'", "''");

            // Tìm theo MANV hoặc TEN (dùng LIKE)
            bdsTL.Filter = $"MaTL LIKE '%{keyword}%' OR THELOAI LIKE '%{keyword}%'";
            isFilterActive = true;

            if (bdsTL.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.");
                bdsTL.Filter = "";
            }
        }
    }
}
