using DevExpress.XtraPrinting.Preview;
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
    public partial class frmReportDMDS: Form
    {
        public frmReportDMDS()
        {
            InitializeComponent();
            XtraReport1 report = new XtraReport1();
            report.Parameters["Nguoilap"].Value = Program.mHoten;
            report.Parameters["Nguoilap"].Visible = false;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        //private void btnExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    try
        //    {
        //        // Khởi tạo report (dữ liệu đã được Data Binding sẵn trong report)
        //        XtraReport1 report = new XtraReport1();

        //        // Mở hộp thoại chọn nơi lưu file
        //        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //        {
        //            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        //            saveFileDialog.Title = "Lưu báo cáo PDF";
        //            saveFileDialog.FileName = "BaoCaoDocGia.pdf";

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                // Xuất file PDF
        //                report.ExportToPdf(saveFileDialog.FileName);
        //                MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                // Hỏi người dùng có muốn mở file không
        //                DialogResult result = MessageBox.Show("Bạn có muốn mở file vừa xuất không?", "Mở file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //                if (result == DialogResult.Yes)
        //                {
        //                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi xuất file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            report.Parameters["Nguoilap"].Value = Program.mHoten;
            report.Parameters["Nguoilap"].Visible = false;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
