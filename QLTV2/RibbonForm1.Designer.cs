namespace QLTV2
{
    partial class RibbonForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnNN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDG = new DevExpress.XtraBars.BarButtonItem();
            this.btnTG = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuonsach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrasach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaotaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportDSDG = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportDMDS = new DevExpress.XtraBars.BarButtonItem();
            this.btnTopDS = new DevExpress.XtraBars.BarButtonItem();
            this.btnDGQuaHan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiPass = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuu = new DevExpress.XtraBars.BarButtonItem();
            this.rbpQLTV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Sách = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQLNS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpMVTS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTraCuu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(54, 46, 54, 46);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSach,
            this.btnNV,
            this.btnTL,
            this.btnNN,
            this.btnDG,
            this.btnTG,
            this.btnMuonsach,
            this.btnTrasach,
            this.btnTaotaikhoan,
            this.btnLogout,
            this.barButtonItem1,
            this.btnReportDSDG,
            this.btnReportDMDS,
            this.btnTopDS,
            this.btnDGQuaHan,
            this.btnDoiPass,
            this.btnTraCuu});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 589;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpQLTV,
            this.rbpQLNS,
            this.rbpMVTS,
            this.rbpSystem,
            this.rbpReport,
            this.rbpTraCuu,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1340, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Quản lý sách";
            this.btnSach.Id = 1;
            this.btnSach.Name = "btnSach";
            this.btnSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSach_ItemClick);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Quản lý nhân viên";
            this.btnNV.Id = 2;
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnTL
            // 
            this.btnTL.Caption = "Quản lý thể loại";
            this.btnTL.Id = 3;
            this.btnTL.Name = "btnTL";
            this.btnTL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTL_ItemClick);
            // 
            // btnNN
            // 
            this.btnNN.Caption = "Quản lý ngôn ngữ";
            this.btnNN.Id = 4;
            this.btnNN.Name = "btnNN";
            // 
            // btnDG
            // 
            this.btnDG.Caption = "Quản lý độc giả";
            this.btnDG.Id = 6;
            this.btnDG.Name = "btnDG";
            this.btnDG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDG_ItemClick);
            // 
            // btnTG
            // 
            this.btnTG.Caption = "Quản lý tác giả";
            this.btnTG.Id = 7;
            this.btnTG.Name = "btnTG";
            this.btnTG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTG_ItemClick);
            // 
            // btnMuonsach
            // 
            this.btnMuonsach.Caption = "Mượn sách";
            this.btnMuonsach.Id = 8;
            this.btnMuonsach.Name = "btnMuonsach";
            this.btnMuonsach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonsach_ItemClick);
            // 
            // btnTrasach
            // 
            this.btnTrasach.Caption = "Trả sách";
            this.btnTrasach.Id = 9;
            this.btnTrasach.Name = "btnTrasach";
            this.btnTrasach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrasach_ItemClick);
            // 
            // btnTaotaikhoan
            // 
            this.btnTaotaikhoan.Caption = "Tạo tài khoản";
            this.btnTaotaikhoan.Id = 10;
            this.btnTaotaikhoan.Name = "btnTaotaikhoan";
            this.btnTaotaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaotaikhoan_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 11;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sao lưu & Phục hồi";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnReportDSDG
            // 
            this.btnReportDSDG.Caption = "In danh sách độc giả";
            this.btnReportDSDG.Id = 13;
            this.btnReportDSDG.Name = "btnReportDSDG";
            this.btnReportDSDG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportDSDG_ItemClick);
            // 
            // btnReportDMDS
            // 
            this.btnReportDMDS.Caption = "In danh mục đầu sách";
            this.btnReportDMDS.Id = 14;
            this.btnReportDMDS.Name = "btnReportDMDS";
            this.btnReportDMDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportDMDS_ItemClick);
            // 
            // btnTopDS
            // 
            this.btnTopDS.Caption = "In Top sách được mượn";
            this.btnTopDS.Id = 15;
            this.btnTopDS.Name = "btnTopDS";
            this.btnTopDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTopDS_ItemClick);
            // 
            // btnDGQuaHan
            // 
            this.btnDGQuaHan.Caption = "In độc giả mượn sách quá hạn";
            this.btnDGQuaHan.Id = 16;
            this.btnDGQuaHan.Name = "btnDGQuaHan";
            this.btnDGQuaHan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDGQuaHan_ItemClick);
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Caption = "Đổi mật khẩu";
            this.btnDoiPass.Id = 17;
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiPass_ItemClick);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Caption = "Tra cứu sách";
            this.btnTraCuu.Id = 18;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuu_ItemClick);
            // 
            // rbpQLTV
            // 
            this.rbpQLTV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Sách,
            this.ribbonPageGroup2});
            this.rbpQLTV.Name = "rbpQLTV";
            this.rbpQLTV.Text = "Quản lý thư viện";
            // 
            // Sách
            // 
            this.Sách.ItemLinks.Add(this.btnSach);
            this.Sách.Name = "Sách";
            this.Sách.Text = "Sách";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTL);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục liên quan";
            // 
            // rbpQLNS
            // 
            this.rbpQLNS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rbpQLNS.Name = "rbpQLNS";
            this.rbpQLNS.Text = "Quản lý nhân sự";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDG);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Độc giả";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTG);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tác giả";
            // 
            // rbpMVTS
            // 
            this.rbpMVTS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.rbpMVTS.Name = "rbpMVTS";
            this.rbpMVTS.Text = "Mượn & trả sách";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnMuonsach);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTrasach);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // rbpSystem
            // 
            this.rbpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup9,
            this.ribbonPageGroup14});
            this.rbpSystem.Name = "rbpSystem";
            this.rbpSystem.Text = "Hệ thống";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnTaotaikhoan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.btnDoiPass);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            this.ribbonPageGroup14.Text = "ribbonPageGroup14";
            // 
            // rbpReport
            // 
            this.rbpReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.rbpReport.Name = "rbpReport";
            this.rbpReport.Text = "Báo cáo";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnReportDSDG);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnReportDMDS);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnTopDS);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.btnDGQuaHan);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.Text = "ribbonPageGroup13";
            // 
            // rbpTraCuu
            // 
            this.rbpTraCuu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup15});
            this.rbpTraCuu.Name = "rbpTraCuu";
            this.rbpTraCuu.Text = "Tra cứu";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.btnTraCuu);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            this.ribbonPageGroup15.Text = "ribbonPageGroup15";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thoát";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 735);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1340, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // RibbonForm1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 765);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RibbonForm1";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RibbonForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQLTV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Sách;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTL;
        private DevExpress.XtraBars.BarButtonItem btnNN;
        private DevExpress.XtraBars.BarButtonItem btnDG;
        private DevExpress.XtraBars.BarButtonItem btnTG;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQLNS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpMVTS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnMuonsach;
        private DevExpress.XtraBars.BarButtonItem btnTrasach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTaotaikhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnReportDSDG;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnReportDMDS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnTopDS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem btnDGQuaHan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.BarButtonItem btnDoiPass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.BarButtonItem btnTraCuu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTraCuu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
    }
}