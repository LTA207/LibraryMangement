using DevExpress.XtraReports.UI;
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
    public partial class frmReport: Form
    {
        public frmReport()
        {
            InitializeComponent();
            ReportDSDG report = new ReportDSDG();
            report.Parameters["NguoiLap"].Value = Program.mHoten;
            report.Parameters["NguoiLap"].Visible = false;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSDG report = new ReportDSDG();
            report.Parameters["NguoiLap"].Value = Program.mHoten;
            report.Parameters["NguoiLap"].Visible = false;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
