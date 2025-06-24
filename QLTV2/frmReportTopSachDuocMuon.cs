using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTV2
{
	public partial class frmReportTopSachDuocMuon : QLTV2.Form1
	{
        private DateTime selectedStartDate;
        private DateTime selectedEndDate;
        private int selectedN;

        public frmReportTopSachDuocMuon()
        {
            InitializeComponent();

            TopDauSachDuocMuon report = new TopDauSachDuocMuon();

            report.Parameters["NguoiLap"].Value = Program.mHoten;
            report.Parameters["NguoiLap"].Visible = false;

            // Gán giá trị các parameter và chuyển kiểu đúng
            if (report.Parameters["start"].Value is DateOnly dStart)
                selectedStartDate = dStart.ToDateTime(TimeOnly.MinValue);
            else
                selectedStartDate = Convert.ToDateTime(report.Parameters["start"].Value);

            if (report.Parameters["end"].Value is DateOnly dEnd)
                selectedEndDate = dEnd.ToDateTime(TimeOnly.MinValue);
            else
                selectedEndDate = Convert.ToDateTime(report.Parameters["end"].Value);

            selectedN = Convert.ToInt32(report.Parameters["N"].Value);

            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }


        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TopDauSachDuocMuon report = new TopDauSachDuocMuon();
            report.Parameters["start"].Value = selectedStartDate;
            report.Parameters["end"].Value = selectedEndDate;
            report.Parameters["N"].Value = selectedN;
            report.Parameters["NguoiLap"].Value = Program.mHoten;

            report.Parameters["start"].Visible = false;
            report.Parameters["end"].Visible = false;
            report.Parameters["N"].Visible = false;
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
