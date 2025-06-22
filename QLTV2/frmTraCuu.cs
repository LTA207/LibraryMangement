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
    public partial class frmTraCuu: Form
    {
        private QLTV2.DSTableAdapters.THELOAITableAdapter THELOAITableAdapter = new QLTV2.DSTableAdapters.THELOAITableAdapter();
        private QLTV2.DSTableAdapters.NGONNGUTableAdapter NGONNGUTableAdapter = new QLTV2.DSTableAdapters.NGONNGUTableAdapter();
        private QLTV2.DSTableAdapters.TACGIATableAdapter TACGIATableAdapter = new QLTV2.DSTableAdapters.TACGIATableAdapter();
        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TRACUUSACHTableAdapter.Fill(this.dS.TRACUUSACH);
            this.THELOAITableAdapter.Fill(this.dS.THELOAI);    
            this.TACGIATableAdapter.Fill(this.dS.TACGIA);       
            this.NGONNGUTableAdapter.Fill(this.dS.NGONNGU);
            SetupTheLoaiComboBox();
            SetupNgonNguComboBox();
            SetupTacGiaComboBox();
            cmbTL.SelectedIndex = -1;
            cmbTG.SelectedIndex = -1;
            cmbNN.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTenSach.Text.Trim();
            string matl = cmbTL.SelectedValue?.ToString();
            string matg = cmbTG.SelectedValue?.ToString();
            string mangonngu = cmbNN.SelectedValue?.ToString();

            // Xây dựng chuỗi điều kiện filter
            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(keyword))
                filters.Add($"TENSACH LIKE '%{keyword}%'");
            if (!string.IsNullOrEmpty(matl))
                filters.Add($"THELOAI = '{cmbTL.Text}'");
            if (!string.IsNullOrEmpty(matg))
                filters.Add($"TacGia = '{cmbTG.Text}'");
            if (!string.IsNullOrEmpty(mangonngu))
                filters.Add($"NGONNGU = '{cmbNN.Text}'");


            // Gán filter cho BindingSource
            bdsTraCuu.Filter = string.Join(" AND ", filters);
        }
        private void SetupTheLoaiComboBox()
        {
            cmbTL.DataSource = dS.THELOAI;
            cmbTL.DisplayMember = "THELOAI";
            cmbTL.ValueMember = "MaTL";

        }
        private void SetupNgonNguComboBox()
        {
            cmbNN.DataSource = dS.NGONNGU;
            cmbNN.DisplayMember = "NGONNGU";
            cmbNN.ValueMember = "MANGONNGU";

        }
        private void SetupTacGiaComboBox()
        {
            cmbTG.DataSource = dS.TACGIA;
            cmbTG.DisplayMember = "HOTENTG";
            cmbTG.ValueMember = "MATACGIA";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bdsTraCuu.Filter = string.Empty;

            txtTenSach.Clear();

            if (cmbTL.Items.Count > 0) cmbTL.SelectedIndex = -1;
            if (cmbTG.Items.Count > 0) cmbTG.SelectedIndex = -1;
            if (cmbNN.Items.Count > 0) cmbNN.SelectedIndex = -1;

            this.TRACUUSACHTableAdapter.Fill(this.dS.TRACUUSACH);
        }

    }
}
