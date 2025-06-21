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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLTV2
{
    public partial class frmTacgia: Form
    {
        int vitri = 0;
        private bool isFilterActive = false; // trạng thái filter
        private Stack<UndoItem> undoStack = new Stack<UndoItem>();

        private QLTV2.DSTableAdapters.DAUSACHTableAdapter DAUSACHTableAdapter = new QLTV2.DSTableAdapters.DAUSACHTableAdapter();
        private QLTV2.DSTableAdapters.THELOAITableAdapter THELOAITableAdapter = new QLTV2.DSTableAdapters.THELOAITableAdapter();
        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.NGANTUTableAdapter NGANTUTableAdapter = new QLTV2.DSTableAdapters.NGANTUTableAdapter();
        public frmTacgia()
        {
            InitializeComponent();
        }

        private void tACGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void SaveCurrentRowState(string action)
        {
            if (bdsTG.Current == null) return;

            DataRowView currentRowView = (DataRowView)bdsTG.Current;
            DataRow row = currentRowView.Row;
            object[] values = (object[])row.ItemArray.Clone();

            int realIndex = dS.DAUSACH.Rows.IndexOf(row); // vị trí trong danh sách gốc

            undoStack.Push(new UndoItem
            {
                ItemArray = values,
                Action = action,
                Index = bdsTG.Position,  // vị trí hiện tại trong danh sách đã filter (nếu có)
                RealIndex = realIndex    // vị trí thật trong danh sách gốc
            });
        }

        private void frmTacgia_Load(object sender, EventArgs e)
        {
            this.THELOAITableAdapter.Fill(dS.THELOAI);
            this.NGANTUTableAdapter.Fill(dS.NGANTU);
            this.NGONNGUTableAdapter.Fill(dS.NGONNGU);
            this.DAUSACHTableAdapter.Fill(this.dS.DAUSACH);
            this.TACGIATableAdapter.Fill(this.dS.TACGIA);
            this.TACGIA_SACHTableAdapter.Fill(this.dS.TACGIA_SACH);

            if (bdsTG.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            this.gcTG.CellValueChanged += gcTG_CellValueChanged;
            this.gcTG.CellBeginEdit += gcTG_CellBeginEdit;
            txtHoten.KeyPress += OnlyAllowLetters_KeyPress;
            this.gcTG.EditingControlShowing += gcTG_EditingControlShowing;
            this.gcTG.CellValidating += gcTG_CellValidating;

        }

        private void tACGIABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            undoStack.Push(new UndoItem { Action = "Add" });

            vitri = bdsTG.Position;
            GroupBox1.Enabled = true;
            gcTG.Enabled = false;
            bdsTG.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            txtHoten.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTG_SACH.Count > 0)
            {
                MessageBox.Show("Tác giả đã có sách nên không thể xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveCurrentRowState("Delete");
                    bdsTG.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên.\n" + ex.Message);
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Họ tác giả không được thiếu.");
                txtHoten.Focus();
                return;
            }

            string name = txtHoten.Text.Trim();
            if (bdsTG.Cast<DataRowView>().Any(r => r != bdsTG.Current && r["HOTENTG"].ToString() == name))
            {
                MessageBox.Show("Tên tác giả đã tồn tại. Vui lòng nhập mã khác.");
                txtHoten.Focus();
                return;
            }

            try
            {
                bdsTG.EndEdit();
                bdsTG.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    TACGIATableAdapter.Update(dS.TACGIA);
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
            gcTG.Enabled = true;
        }
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count > 0)
            {
                var item = undoStack.Pop();

                if (item.Action == "Add")
                {
                    if (bdsTG.Count > 0)
                    {
                        bdsTG.RemoveAt(bdsTG.Count - 1);
                    }
                }
                else if (item.Action == "Delete")
                {
                    DataRow row = dS.TACGIA.NewRow();
                    row.ItemArray = item.ItemArray;
                    dS.TACGIA.Rows.InsertAt(row, item.Index); // phục hồi đúng vị trí
                }
                else if (item.Action == "Edit")
                {
                    bdsTG.Position = isFilterActive ? item.Index : item.RealIndex; // đưa con trỏ về đúng dòng đã sửa

                    DataRow current = ((DataRowView)bdsTG.Current).Row;
                    for (int i = 0; i < current.Table.Columns.Count; i++)
                    {
                        if (!current.Table.Columns[i].ReadOnly)
                        {
                            current[i] = item.ItemArray[i];
                        }
                    }
                    bdsTG.EndEdit();
                    bdsTG.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        TACGIATableAdapter.Update(dS.TACGIA);
                        MessageBox.Show("Dữ liệu đã được ghi vào db");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào để ghi vào cơ sở dữ liệu.");
                    }
                }

                bdsTG.ResetBindings(false);
                gcTG.Refresh();
                MessageBox.Show("Đã phục hồi dòng dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTG.Current != null && bdsTG.IsBindingSuspended == false)
            {
                bdsTG.CancelEdit();
            }

            dS.TACGIA_SACH.Clear();
            dS.TACGIA.Clear();
            dS.DAUSACH.Clear();
            dS.THELOAI.Clear();
            dS.NGANTU.Clear();
            dS.NGONNGU.Clear();

            THELOAITableAdapter.Fill(dS.THELOAI);
            NGANTUTableAdapter.Fill(dS.NGANTU);
            NGONNGUTableAdapter.Fill(dS.NGONNGU);
            DAUSACHTableAdapter.Fill(dS.DAUSACH);
            this.TACGIATableAdapter.Fill(this.dS.TACGIA);
            this.TACGIA_SACHTableAdapter.Fill(this.dS.TACGIA_SACH);

            btnThem.Enabled = btnXoa.Enabled = btnTimkiem.Enabled = btnThoat.Enabled = btnPhuchoi.Enabled = true;
            GroupBox1.Enabled = false;
            gcTG.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void gcTG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bdsTG.EndEdit();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        private void gcTG_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaveCurrentRowState("Edit");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                bdsTG.Filter = ""; // Xóa lọc nếu không nhập gì
                bdsTG.RemoveFilter();
                isFilterActive = false;
                return;
            }

            keyword = keyword.Replace("'", "''");

            bdsTG.Filter = $"HOTENTG LIKE '%{keyword}%'";
            isFilterActive = true;

            if (bdsTG.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.");
                bdsTG.Filter = "";
            }
        }
        private void OnlyAllowLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Cho phép phím điều khiển như Backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Chặn nếu không phải chữ hoặc khoảng trắng
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Chặn khoảng trắng đầu tiên
            if (textBox.SelectionStart == 0 && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Chặn nhiều khoảng trắng liên tiếp
            if (char.IsWhiteSpace(e.KeyChar))
            {
                int pos = textBox.SelectionStart;
                if (pos > 0 && textBox.Text[pos - 1] == ' ')
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private void gcTG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gcTG.CurrentCell.ColumnIndex == colHOTENTG.Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= OnlyAllowLetters_KeyPress;
                    tb.KeyPress += OnlyAllowLetters_KeyPress;
                }
            }
            else
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= OnlyAllowLetters_KeyPress;
                }
            }
        }
        private void gcTG_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Kiểm tra cột Họ hoặc Tên
            if (gcTG.Columns[e.ColumnIndex].Name == "colHOTENTG")
            {
                string newValue = e.FormattedValue?.ToString().Trim();

                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show($"{gcTG.Columns[e.ColumnIndex].HeaderText} không được để trống.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}
