using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLTV2
{
	public partial class RibbonForm1: DevExpress.XtraBars.Ribbon.RibbonForm
	{
        public RibbonForm1()
		{
            InitializeComponent();
		}

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "dg")
            {
                rbpQLTV.Visible = false;
                rbpMVTS.Visible = false;
                rbpQLNS.Visible = false;
                rbpSystem.Visible = false;
                rbpReport.Visible = false;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSach));
            if (frm != null) frm.Activate();
            else
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanvien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanvien f = new frmNhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTL_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheloai));
            if (frm != null) frm.Activate();
            else
            {
                frmTheloai f = new frmTheloai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTacgia));
            if (frm != null) frm.Activate();
            else
            {
                frmTacgia f = new frmTacgia();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDocgia));
            if (frm != null) frm.Activate();
            else
            {
                frmDocgia f = new frmDocgia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMuonsach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMuonsach));
            if (frm != null) frm.Activate();
            else
            {
                frmMuonsach f = new frmMuonsach();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnTrasach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTrasach));
            if (frm != null) frm.Activate();
            else
            {
                frmTrasach f = new frmTrasach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaotaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBackup));
            if (frm != null) frm.Activate();
            else
            {
                frmBackup f = new frmBackup();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnReportDSDG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReport));
            if (frm != null) frm.Activate();
            else
            {
                frmReport f = new frmReport();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnReportDMDS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportDMDS));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDMDS f = new frmReportDMDS();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTopDS_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportTopSachDuocMuon));
            if (frm != null) frm.Activate();
            else
            {
                frmReportTopSachDuocMuon f = new frmReportTopSachDuocMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDGQuaHan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReportDocGiaQuaHan));
            if (frm != null) frm.Activate();
            else
            {
                frmReportDocGiaQuaHan f = new frmReportDocGiaQuaHan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDoiPass));
            if (frm != null) frm.Activate();
            else
            {
                frmDoiPass f = new frmDoiPass();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}