namespace QLTV2
{
    partial class frmSach
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label tensachLabel;
            System.Windows.Forms.Label khosachLabel;
            System.Windows.Forms.Label noidungLabel;
            System.Windows.Forms.Label hinhAnhPathLabel;
            System.Windows.Forms.Label ngayxuatbanLabel;
            System.Windows.Forms.Label lanxuatbanLabel;
            System.Windows.Forms.Label sotrangLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label nHAXBLabel;
            System.Windows.Forms.Label mANGONNGULabel;
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            System.Windows.Forms.Label cHOMUONLabel;
            System.Windows.Forms.Label mANGANTULabel;
            System.Windows.Forms.Label maTLLabel1;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QLTV2.DS();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDS = new System.Windows.Forms.BindingSource(this.components);
            this.DAUSACHTableAdapter = new QLTV2.DSTableAdapters.DAUSACHTableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.SACHTableAdapter = new QLTV2.DSTableAdapters.SACHTableAdapter();
            this.GroupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbMATL = new System.Windows.Forms.ComboBox();
            this.cmbMANN = new System.Windows.Forms.ComboBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSotrang = new System.Windows.Forms.TextBox();
            this.txtLanxuatban = new System.Windows.Forms.TextBox();
            this.dtpNSB = new System.Windows.Forms.DateTimePicker();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.txtKhosach = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.btnGhisach = new System.Windows.Forms.Button();
            this.cmbMANT = new System.Windows.Forms.ComboBox();
            this.cmbCM = new System.Windows.Forms.ComboBox();
            this.cmbTT = new System.Windows.Forms.ComboBox();
            this.txtMAS = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gcDAUSACH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsCT_PHIEUMUON = new System.Windows.Forms.BindingSource(this.components);
            this.CT_PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.CT_PHIEUMUONTableAdapter();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gcSACH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbChoMuon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GroupBox3 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new DevExpress.XtraEditors.TextEdit();
            iSBNLabel = new System.Windows.Forms.Label();
            tensachLabel = new System.Windows.Forms.Label();
            khosachLabel = new System.Windows.Forms.Label();
            noidungLabel = new System.Windows.Forms.Label();
            hinhAnhPathLabel = new System.Windows.Forms.Label();
            ngayxuatbanLabel = new System.Windows.Forms.Label();
            lanxuatbanLabel = new System.Windows.Forms.Label();
            sotrangLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            nHAXBLabel = new System.Windows.Forms.Label();
            mANGONNGULabel = new System.Windows.Forms.Label();
            mASACHLabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            cHOMUONLabel = new System.Windows.Forms.Label();
            mANGANTULabel = new System.Windows.Forms.Label();
            maTLLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDAUSACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHIEUMUON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox3)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(32, 50);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(39, 16);
            iSBNLabel.TabIndex = 0;
            iSBNLabel.Text = "ISBN:";
            // 
            // tensachLabel
            // 
            tensachLabel.AutoSize = true;
            tensachLabel.Location = new System.Drawing.Point(224, 50);
            tensachLabel.Name = "tensachLabel";
            tensachLabel.Size = new System.Drawing.Size(60, 16);
            tensachLabel.TabIndex = 2;
            tensachLabel.Text = "Tensach:";
            // 
            // khosachLabel
            // 
            khosachLabel.AutoSize = true;
            khosachLabel.Location = new System.Drawing.Point(437, 50);
            khosachLabel.Name = "khosachLabel";
            khosachLabel.Size = new System.Drawing.Size(59, 16);
            khosachLabel.TabIndex = 4;
            khosachLabel.Text = "Khosach:";
            // 
            // noidungLabel
            // 
            noidungLabel.AutoSize = true;
            noidungLabel.Location = new System.Drawing.Point(13, 98);
            noidungLabel.Name = "noidungLabel";
            noidungLabel.Size = new System.Drawing.Size(58, 16);
            noidungLabel.TabIndex = 6;
            noidungLabel.Text = "Noidung:";
            // 
            // hinhAnhPathLabel
            // 
            hinhAnhPathLabel.AutoSize = true;
            hinhAnhPathLabel.Location = new System.Drawing.Point(984, 53);
            hinhAnhPathLabel.Name = "hinhAnhPathLabel";
            hinhAnhPathLabel.Size = new System.Drawing.Size(92, 16);
            hinhAnhPathLabel.TabIndex = 8;
            hinhAnhPathLabel.Text = "Hinh Anh Path:";
            // 
            // ngayxuatbanLabel
            // 
            ngayxuatbanLabel.AutoSize = true;
            ngayxuatbanLabel.Location = new System.Drawing.Point(646, 54);
            ngayxuatbanLabel.Name = "ngayxuatbanLabel";
            ngayxuatbanLabel.Size = new System.Drawing.Size(85, 16);
            ngayxuatbanLabel.TabIndex = 10;
            ngayxuatbanLabel.Text = "Ngayxuatban:";
            // 
            // lanxuatbanLabel
            // 
            lanxuatbanLabel.AutoSize = true;
            lanxuatbanLabel.Location = new System.Drawing.Point(207, 98);
            lanxuatbanLabel.Name = "lanxuatbanLabel";
            lanxuatbanLabel.Size = new System.Drawing.Size(77, 16);
            lanxuatbanLabel.TabIndex = 12;
            lanxuatbanLabel.Text = "Lanxuatban:";
            // 
            // sotrangLabel
            // 
            sotrangLabel.AutoSize = true;
            sotrangLabel.Location = new System.Drawing.Point(439, 98);
            sotrangLabel.Name = "sotrangLabel";
            sotrangLabel.Size = new System.Drawing.Size(57, 16);
            sotrangLabel.TabIndex = 14;
            sotrangLabel.Text = "Sotrang:";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(1139, 97);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(30, 16);
            giaLabel.TabIndex = 16;
            giaLabel.Text = "Gia:";
            // 
            // nHAXBLabel
            // 
            nHAXBLabel.AutoSize = true;
            nHAXBLabel.Location = new System.Drawing.Point(923, 98);
            nHAXBLabel.Name = "nHAXBLabel";
            nHAXBLabel.Size = new System.Drawing.Size(51, 16);
            nHAXBLabel.TabIndex = 18;
            nHAXBLabel.Text = "NHAXB:";
            // 
            // mANGONNGULabel
            // 
            mANGONNGULabel.AutoSize = true;
            mANGONNGULabel.Location = new System.Drawing.Point(644, 101);
            mANGONNGULabel.Name = "mANGONNGULabel";
            mANGONNGULabel.Size = new System.Drawing.Size(87, 16);
            mANGONNGULabel.TabIndex = 20;
            mANGONNGULabel.Text = "MANGONNGU:";
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(28, 73);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(62, 16);
            mASACHLabel.TabIndex = 0;
            mASACHLabel.Text = "MASACH:";
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(37, 116);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(80, 16);
            tINHTRANGLabel.TabIndex = 4;
            tINHTRANGLabel.Text = "TINHTRANG:";
            // 
            // cHOMUONLabel
            // 
            cHOMUONLabel.AutoSize = true;
            cHOMUONLabel.Location = new System.Drawing.Point(295, 119);
            cHOMUONLabel.Name = "cHOMUONLabel";
            cHOMUONLabel.Size = new System.Drawing.Size(72, 16);
            cHOMUONLabel.TabIndex = 6;
            cHOMUONLabel.Text = "CHOMUON:";
            // 
            // mANGANTULabel
            // 
            mANGANTULabel.AutoSize = true;
            mANGANTULabel.Location = new System.Drawing.Point(252, 72);
            mANGANTULabel.Name = "mANGANTULabel";
            mANGANTULabel.Size = new System.Drawing.Size(78, 16);
            mANGANTULabel.TabIndex = 8;
            mANGANTULabel.Text = "MANGANTU:";
            // 
            // maTLLabel1
            // 
            maTLLabel1.AutoSize = true;
            maTLLabel1.Location = new System.Drawing.Point(1332, 101);
            maTLLabel1.Name = "maTLLabel1";
            maTLLabel1.Size = new System.Drawing.Size(47, 16);
            maTLLabel1.TabIndex = 24;
            maTLLabel1.Text = "Ma TL:";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 25);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 811);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 786);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1557, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 786);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhuchoi,
            this.btnReload,
            this.btnThoat,
            this.barButtonItem3});
            this.barManager2.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhuchoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 2;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 5;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Id = 6;
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 7;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(1557, 25);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 811);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 25);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 786);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1557, 25);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 786);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSach
            // 
            this.bdsSach.DataMember = "FK__SACH__ISBN__31EC6D26";
            this.bdsSach.DataSource = this.bdsDS;
            // 
            // bdsDS
            // 
            this.bdsDS.DataMember = "DAUSACH";
            this.bdsDS.DataSource = this.dS;
            // 
            // DAUSACHTableAdapter
            // 
            this.DAUSACHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DAUSACHTableAdapter = this.DAUSACHTableAdapter;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = this.SACHTableAdapter;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SACHTableAdapter
            // 
            this.SACHTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(maTLLabel1);
            this.GroupBox1.Controls.Add(this.cmbMATL);
            this.GroupBox1.Controls.Add(mANGONNGULabel);
            this.GroupBox1.Controls.Add(this.cmbMANN);
            this.GroupBox1.Controls.Add(nHAXBLabel);
            this.GroupBox1.Controls.Add(this.txtNhaXB);
            this.GroupBox1.Controls.Add(giaLabel);
            this.GroupBox1.Controls.Add(this.txtGia);
            this.GroupBox1.Controls.Add(sotrangLabel);
            this.GroupBox1.Controls.Add(this.txtSotrang);
            this.GroupBox1.Controls.Add(lanxuatbanLabel);
            this.GroupBox1.Controls.Add(this.txtLanxuatban);
            this.GroupBox1.Controls.Add(ngayxuatbanLabel);
            this.GroupBox1.Controls.Add(this.dtpNSB);
            this.GroupBox1.Controls.Add(hinhAnhPathLabel);
            this.GroupBox1.Controls.Add(this.txtHinh);
            this.GroupBox1.Controls.Add(noidungLabel);
            this.GroupBox1.Controls.Add(this.txtNoidung);
            this.GroupBox1.Controls.Add(khosachLabel);
            this.GroupBox1.Controls.Add(this.txtKhosach);
            this.GroupBox1.Controls.Add(tensachLabel);
            this.GroupBox1.Controls.Add(this.txtTensach);
            this.GroupBox1.Controls.Add(iSBNLabel);
            this.GroupBox1.Controls.Add(this.txtISBN);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 641);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1557, 170);
            this.GroupBox1.TabIndex = 36;
            this.GroupBox1.Text = "groupControl1";
            // 
            // cmbMATL
            // 
            this.cmbMATL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "MaTL", true));
            this.cmbMATL.FormattingEnabled = true;
            this.cmbMATL.Location = new System.Drawing.Point(1385, 98);
            this.cmbMATL.Name = "cmbMATL";
            this.cmbMATL.Size = new System.Drawing.Size(121, 24);
            this.cmbMATL.TabIndex = 25;
            // 
            // cmbMANN
            // 
            this.cmbMANN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "MANGONNGU", true));
            this.cmbMANN.FormattingEnabled = true;
            this.cmbMANN.Location = new System.Drawing.Point(737, 98);
            this.cmbMANN.Name = "cmbMANN";
            this.cmbMANN.Size = new System.Drawing.Size(121, 24);
            this.cmbMANN.TabIndex = 21;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "NHAXB", true));
            this.txtNhaXB.Location = new System.Drawing.Point(980, 95);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(100, 23);
            this.txtNhaXB.TabIndex = 19;
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Gia", true));
            this.txtGia.Location = new System.Drawing.Point(1175, 94);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 23);
            this.txtGia.TabIndex = 17;
            // 
            // txtSotrang
            // 
            this.txtSotrang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Sotrang", true));
            this.txtSotrang.Location = new System.Drawing.Point(502, 95);
            this.txtSotrang.Name = "txtSotrang";
            this.txtSotrang.Size = new System.Drawing.Size(100, 23);
            this.txtSotrang.TabIndex = 15;
            // 
            // txtLanxuatban
            // 
            this.txtLanxuatban.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Lanxuatban", true));
            this.txtLanxuatban.Location = new System.Drawing.Point(290, 95);
            this.txtLanxuatban.Name = "txtLanxuatban";
            this.txtLanxuatban.Size = new System.Drawing.Size(100, 23);
            this.txtLanxuatban.TabIndex = 13;
            // 
            // dtpNSB
            // 
            this.dtpNSB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDS, "Ngayxuatban", true));
            this.dtpNSB.Location = new System.Drawing.Point(737, 50);
            this.dtpNSB.Name = "dtpNSB";
            this.dtpNSB.Size = new System.Drawing.Size(200, 23);
            this.dtpNSB.TabIndex = 11;
            // 
            // txtHinh
            // 
            this.txtHinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "HinhAnhPath", true));
            this.txtHinh.Location = new System.Drawing.Point(1082, 50);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(276, 23);
            this.txtHinh.TabIndex = 9;
            // 
            // txtNoidung
            // 
            this.txtNoidung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Noidung", true));
            this.txtNoidung.Location = new System.Drawing.Point(77, 95);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(100, 23);
            this.txtNoidung.TabIndex = 7;
            // 
            // txtKhosach
            // 
            this.txtKhosach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Khosach", true));
            this.txtKhosach.Location = new System.Drawing.Point(502, 47);
            this.txtKhosach.Name = "txtKhosach";
            this.txtKhosach.Size = new System.Drawing.Size(100, 23);
            this.txtKhosach.TabIndex = 5;
            // 
            // txtTensach
            // 
            this.txtTensach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "Tensach", true));
            this.txtTensach.Location = new System.Drawing.Point(290, 47);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(100, 23);
            this.txtTensach.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS, "ISBN", true));
            this.txtISBN.Location = new System.Drawing.Point(77, 47);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 23);
            this.txtISBN.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnGhisach);
            this.GroupBox2.Controls.Add(mANGANTULabel);
            this.GroupBox2.Controls.Add(this.cmbMANT);
            this.GroupBox2.Controls.Add(cHOMUONLabel);
            this.GroupBox2.Controls.Add(this.cmbCM);
            this.GroupBox2.Controls.Add(tINHTRANGLabel);
            this.GroupBox2.Controls.Add(this.cmbTT);
            this.GroupBox2.Controls.Add(mASACHLabel);
            this.GroupBox2.Controls.Add(this.txtMAS);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox2.Location = new System.Drawing.Point(0, 232);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(649, 409);
            this.GroupBox2.TabIndex = 53;
            this.GroupBox2.Text = "groupControl1";
            // 
            // btnGhisach
            // 
            this.btnGhisach.Location = new System.Drawing.Point(537, 87);
            this.btnGhisach.Name = "btnGhisach";
            this.btnGhisach.Size = new System.Drawing.Size(75, 23);
            this.btnGhisach.TabIndex = 10;
            this.btnGhisach.Text = "Ghi";
            this.btnGhisach.UseVisualStyleBackColor = true;
            this.btnGhisach.Click += new System.EventHandler(this.btnGhisach_Click);
            // 
            // cmbMANT
            // 
            this.cmbMANT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSach, "MANGANTU", true));
            this.cmbMANT.FormattingEnabled = true;
            this.cmbMANT.Location = new System.Drawing.Point(336, 69);
            this.cmbMANT.Name = "cmbMANT";
            this.cmbMANT.Size = new System.Drawing.Size(121, 24);
            this.cmbMANT.TabIndex = 9;
            // 
            // cmbCM
            // 
            this.cmbCM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSach, "CHOMUON", true));
            this.cmbCM.FormattingEnabled = true;
            this.cmbCM.Location = new System.Drawing.Point(373, 116);
            this.cmbCM.Name = "cmbCM";
            this.cmbCM.Size = new System.Drawing.Size(121, 24);
            this.cmbCM.TabIndex = 7;
            // 
            // cmbTT
            // 
            this.cmbTT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSach, "TINHTRANG", true));
            this.cmbTT.FormattingEnabled = true;
            this.cmbTT.Location = new System.Drawing.Point(123, 113);
            this.cmbTT.Name = "cmbTT";
            this.cmbTT.Size = new System.Drawing.Size(121, 24);
            this.cmbTT.TabIndex = 5;
            // 
            // txtMAS
            // 
            this.txtMAS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSach, "MASACH", true));
            this.txtMAS.Location = new System.Drawing.Point(96, 70);
            this.txtMAS.Name = "txtMAS";
            this.txtMAS.Size = new System.Drawing.Size(100, 23);
            this.txtMAS.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuThem,
            this.btnMenuXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 52);
            // 
            // btnMenuThem
            // 
            this.btnMenuThem.Name = "btnMenuThem";
            this.btnMenuThem.Size = new System.Drawing.Size(148, 24);
            this.btnMenuThem.Text = "Thêm sách";
            this.btnMenuThem.Click += new System.EventHandler(this.btnMenuThem_Click);
            // 
            // btnMenuXoa
            // 
            this.btnMenuXoa.Name = "btnMenuXoa";
            this.btnMenuXoa.Size = new System.Drawing.Size(148, 24);
            this.btnMenuXoa.Text = "Xóa sách";
            this.btnMenuXoa.Click += new System.EventHandler(this.btnMenuXoa_Click);
            // 
            // gcDAUSACH
            // 
            this.gcDAUSACH.AllowUserToAddRows = false;
            this.gcDAUSACH.AllowUserToDeleteRows = false;
            this.gcDAUSACH.AutoGenerateColumns = false;
            this.gcDAUSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcDAUSACH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13});
            this.gcDAUSACH.DataSource = this.bdsDS;
            this.gcDAUSACH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDAUSACH.Location = new System.Drawing.Point(0, 25);
            this.gcDAUSACH.Margin = new System.Windows.Forms.Padding(4);
            this.gcDAUSACH.Name = "gcDAUSACH";
            this.gcDAUSACH.RowHeadersWidth = 51;
            this.gcDAUSACH.RowTemplate.Height = 24;
            this.gcDAUSACH.Size = new System.Drawing.Size(1557, 207);
            this.gcDAUSACH.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tensach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tensach";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Khosach";
            this.dataGridViewTextBoxColumn3.HeaderText = "Khosach";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Noidung";
            this.dataGridViewTextBoxColumn4.HeaderText = "Noidung";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HinhAnhPath";
            this.dataGridViewTextBoxColumn5.HeaderText = "HinhAnhPath";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ngayxuatban";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngayxuatban";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Lanxuatban";
            this.dataGridViewTextBoxColumn7.HeaderText = "Lanxuatban";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sotrang";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sotrang";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gia";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gia";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NHAXB";
            this.dataGridViewTextBoxColumn10.HeaderText = "NHAXB";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MANGONNGU";
            this.dataGridViewTextBoxColumn11.DataSource = this.dS;
            this.dataGridViewTextBoxColumn11.DisplayMember = "NGONNGU.NGONNGU";
            this.dataGridViewTextBoxColumn11.HeaderText = "MANGONNGU";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "NGONNGU.MANGONNGU";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MaTL";
            this.dataGridViewTextBoxColumn13.DataSource = this.dS;
            this.dataGridViewTextBoxColumn13.DisplayMember = "THELOAI.THELOAI";
            this.dataGridViewTextBoxColumn13.HeaderText = "MaTL";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.ValueMember = "THELOAI.MaTL";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // bdsCT_PHIEUMUON
            // 
            this.bdsCT_PHIEUMUON.DataMember = "FK__CT_PHIEUM__MASAC__4316F928";
            this.bdsCT_PHIEUMUON.DataSource = this.bdsSach;
            // 
            // CT_PHIEUMUONTableAdapter
            // 
            this.CT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.dS;
            // 
            // sACHBindingSource1
            // 
            this.sACHBindingSource1.DataMember = "SACH";
            this.sACHBindingSource1.DataSource = this.dS;
            // 
            // gcSACH
            // 
            this.gcSACH.AllowUserToAddRows = false;
            this.gcSACH.AllowUserToDeleteRows = false;
            this.gcSACH.AutoGenerateColumns = false;
            this.gcSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcSACH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.cmbTinhTrang,
            this.cmbChoMuon,
            this.dataGridViewTextBoxColumn16});
            this.gcSACH.DataSource = this.bdsSach;
            this.gcSACH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSACH.Location = new System.Drawing.Point(649, 232);
            this.gcSACH.Name = "gcSACH";
            this.gcSACH.RowHeadersWidth = 51;
            this.gcSACH.RowTemplate.Height = 24;
            this.gcSACH.Size = new System.Drawing.Size(908, 409);
            this.gcSACH.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MASACH";
            this.dataGridViewTextBoxColumn14.HeaderText = "MASACH";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn15.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DataPropertyName = "TINHTRANG";
            this.cmbTinhTrang.HeaderText = "TINHTRANG";
            this.cmbTinhTrang.MinimumWidth = 6;
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbTinhTrang.Width = 125;
            // 
            // cmbChoMuon
            // 
            this.cmbChoMuon.DataPropertyName = "CHOMUON";
            this.cmbChoMuon.HeaderText = "CHOMUON";
            this.cmbChoMuon.MinimumWidth = 6;
            this.cmbChoMuon.Name = "cmbChoMuon";
            this.cmbChoMuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbChoMuon.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MANGANTU";
            this.dataGridViewTextBoxColumn16.DataSource = this.dS;
            this.dataGridViewTextBoxColumn16.DisplayMember = "NGANTU.KE";
            this.dataGridViewTextBoxColumn16.HeaderText = "MANGANTU";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn16.ValueMember = "NGANTU.MANGANTU";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnTimkiem);
            this.GroupBox3.Controls.Add(this.txtTimkiem);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox3.Location = new System.Drawing.Point(649, 547);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(908, 94);
            this.GroupBox3.TabIndex = 79;
            this.GroupBox3.Text = "groupControl1";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(424, 54);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(117, 23);
            this.btnTimkiem.TabIndex = 74;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(60, 55);
            this.txtTimkiem.MenuManager = this.barManager1;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(266, 22);
            this.txtTimkiem.TabIndex = 73;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 811);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.gcSACH);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.gcDAUSACH);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDAUSACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHIEUMUON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox3)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DS dS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource bdsDS;
        private DSTableAdapters.DAUSACHTableAdapter DAUSACHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SACHTableAdapter SACHTableAdapter;
        private System.Windows.Forms.BindingSource bdsSach;
        private DevExpress.XtraEditors.GroupControl GroupBox1;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSotrang;
        private System.Windows.Forms.TextBox txtLanxuatban;
        private System.Windows.Forms.DateTimePicker dtpNSB;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.TextBox txtKhosach;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cmbMANN;
        private DevExpress.XtraEditors.GroupControl GroupBox2;
        private System.Windows.Forms.TextBox txtMAS;
        private System.Windows.Forms.ComboBox cmbMANT;
        private System.Windows.Forms.ComboBox cmbCM;
        private System.Windows.Forms.ComboBox cmbTT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuThem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuXoa;
        private System.Windows.Forms.Button btnGhisach;
        private System.Windows.Forms.ComboBox cmbMATL;
        private System.Windows.Forms.DataGridView gcDAUSACH;
        private System.Windows.Forms.BindingSource bdsCT_PHIEUMUON;
        private DSTableAdapters.CT_PHIEUMUONTableAdapter CT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private System.Windows.Forms.BindingSource sACHBindingSource1;
        private System.Windows.Forms.DataGridView gcSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTinhTrang;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbChoMuon;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.GroupControl GroupBox3;
        private System.Windows.Forms.Button btnTimkiem;
        private DevExpress.XtraEditors.TextEdit txtTimkiem;
    }
}