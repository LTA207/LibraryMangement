namespace QLTV2
{
    partial class frmMuonsach
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
            System.Windows.Forms.Label hINHTHUCLabel;
            System.Windows.Forms.Label nGAYMUONLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mASACHLabel = new System.Windows.Forms.Label();
            this.mADGLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLTV2.DS();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.PHIEUMUONTableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.gcPHIEUMUON = new System.Windows.Forms.DataGridView();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbMADG = new System.Windows.Forms.ComboBox();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.cmbHinhthuc = new System.Windows.Forms.ComboBox();
            this.cmbMAS = new System.Windows.Forms.ComboBox();
            this.bdsCT_PHIEUMUON = new System.Windows.Forms.BindingSource(this.components);
            this.CT_PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.CT_PHIEUMUONTableAdapter();
            this.GroupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoasach = new System.Windows.Forms.Button();
            this.btnMuonsach = new System.Windows.Forms.Button();
            this.gcCT_PHIEUMUON = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColMaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColTinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbColTRA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbColMANVNS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dOCGIATableAdapter1 = new QLTV2.DSTableAdapters.DOCGIATableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColMADG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbColHT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMANVColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            hINHTHUCLabel = new System.Windows.Forms.Label();
            nGAYMUONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPHIEUMUON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHIEUMUON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_PHIEUMUON)).BeginInit();
            this.SuspendLayout();
            // 
            // hINHTHUCLabel
            // 
            hINHTHUCLabel.AutoSize = true;
            hINHTHUCLabel.Location = new System.Drawing.Point(208, 55);
            hINHTHUCLabel.Name = "hINHTHUCLabel";
            hINHTHUCLabel.Size = new System.Drawing.Size(72, 16);
            hINHTHUCLabel.TabIndex = 2;
            hINHTHUCLabel.Text = "HINHTHUC:";
            // 
            // nGAYMUONLabel
            // 
            nGAYMUONLabel.AutoSize = true;
            nGAYMUONLabel.Location = new System.Drawing.Point(459, 54);
            nGAYMUONLabel.Name = "nGAYMUONLabel";
            nGAYMUONLabel.Size = new System.Drawing.Size(78, 16);
            nGAYMUONLabel.TabIndex = 4;
            nGAYMUONLabel.Text = "NGAYMUON:";
            // 
            // mASACHLabel
            // 
            this.mASACHLabel.AutoSize = true;
            this.mASACHLabel.Location = new System.Drawing.Point(53, 62);
            this.mASACHLabel.Name = "mASACHLabel";
            this.mASACHLabel.Size = new System.Drawing.Size(62, 16);
            this.mASACHLabel.TabIndex = 17;
            this.mASACHLabel.Text = "MASACH:";
            // 
            // mADGLabel
            // 
            this.mADGLabel.AutoSize = true;
            this.mADGLabel.Location = new System.Drawing.Point(16, 55);
            this.mADGLabel.Name = "mADGLabel";
            this.mADGLabel.Size = new System.Drawing.Size(46, 16);
            this.mADGLabel.TabIndex = 18;
            this.mADGLabel.Text = "MADG:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnReload,
            this.btnPhuchoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhuchoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Id = 4;
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 3;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1076, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 679);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1076, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 654);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1076, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 654);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "PHIEUMUON";
            this.bdsPM.DataSource = this.dS;
            // 
            // PHIEUMUONTableAdapter
            // 
            this.PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DAUSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = this.PHIEUMUONTableAdapter;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcPHIEUMUON
            // 
            this.gcPHIEUMUON.AllowUserToAddRows = false;
            this.gcPHIEUMUON.AllowUserToDeleteRows = false;
            this.gcPHIEUMUON.AutoGenerateColumns = false;
            this.gcPHIEUMUON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcPHIEUMUON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcPHIEUMUON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cmbColMADG,
            this.cmbColHT,
            this.dataGridViewTextBoxColumn3,
            this.cmbMANVColumn});
            this.gcPHIEUMUON.DataSource = this.bdsPM;
            this.gcPHIEUMUON.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPHIEUMUON.Location = new System.Drawing.Point(0, 25);
            this.gcPHIEUMUON.Name = "gcPHIEUMUON";
            this.gcPHIEUMUON.RowHeadersWidth = 51;
            this.gcPHIEUMUON.RowTemplate.Height = 24;
            this.gcPHIEUMUON.Size = new System.Drawing.Size(1076, 184);
            this.gcPHIEUMUON.TabIndex = 8;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.dS;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.mADGLabel);
            this.GroupBox1.Controls.Add(this.cmbMADG);
            this.GroupBox1.Controls.Add(nGAYMUONLabel);
            this.GroupBox1.Controls.Add(this.dtpNgaymuon);
            this.GroupBox1.Controls.Add(hINHTHUCLabel);
            this.GroupBox1.Controls.Add(this.cmbHinhthuc);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 551);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1076, 128);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.Text = "groupControl1";
            // 
            // cmbMADG
            // 
            this.cmbMADG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPM, "MADG", true));
            this.cmbMADG.FormattingEnabled = true;
            this.cmbMADG.Location = new System.Drawing.Point(68, 52);
            this.cmbMADG.Name = "cmbMADG";
            this.cmbMADG.Size = new System.Drawing.Size(121, 24);
            this.cmbMADG.TabIndex = 19;
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaymuon.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPM, "NGAYMUON", true));
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaymuon.Location = new System.Drawing.Point(543, 50);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaymuon.TabIndex = 5;
            // 
            // cmbHinhthuc
            // 
            this.cmbHinhthuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPM, "HINHTHUC", true));
            this.cmbHinhthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHinhthuc.FormattingEnabled = true;
            this.cmbHinhthuc.Location = new System.Drawing.Point(286, 52);
            this.cmbHinhthuc.Name = "cmbHinhthuc";
            this.cmbHinhthuc.Size = new System.Drawing.Size(121, 24);
            this.cmbHinhthuc.TabIndex = 3;
            // 
            // cmbMAS
            // 
            this.cmbMAS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCT_PHIEUMUON, "MASACH", true));
            this.cmbMAS.FormattingEnabled = true;
            this.cmbMAS.Location = new System.Drawing.Point(121, 59);
            this.cmbMAS.Name = "cmbMAS";
            this.cmbMAS.Size = new System.Drawing.Size(208, 24);
            this.cmbMAS.TabIndex = 18;
            // 
            // bdsCT_PHIEUMUON
            // 
            this.bdsCT_PHIEUMUON.DataMember = "FK__CT_PHIEUM__MAPHI__4222D4EF";
            this.bdsCT_PHIEUMUON.DataSource = this.bdsPM;
            // 
            // CT_PHIEUMUONTableAdapter
            // 
            this.CT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnXoasach);
            this.GroupBox2.Controls.Add(this.btnMuonsach);
            this.GroupBox2.Controls.Add(this.cmbMAS);
            this.GroupBox2.Controls.Add(this.mASACHLabel);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox2.Location = new System.Drawing.Point(0, 209);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(490, 342);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.Text = "groupControl1";
            // 
            // btnXoasach
            // 
            this.btnXoasach.Location = new System.Drawing.Point(275, 181);
            this.btnXoasach.Name = "btnXoasach";
            this.btnXoasach.Size = new System.Drawing.Size(112, 27);
            this.btnXoasach.TabIndex = 20;
            this.btnXoasach.Text = "Xóa sách";
            this.btnXoasach.UseVisualStyleBackColor = true;
            this.btnXoasach.Click += new System.EventHandler(this.btnXoasach_Click);
            // 
            // btnMuonsach
            // 
            this.btnMuonsach.Location = new System.Drawing.Point(39, 181);
            this.btnMuonsach.Name = "btnMuonsach";
            this.btnMuonsach.Size = new System.Drawing.Size(112, 27);
            this.btnMuonsach.TabIndex = 19;
            this.btnMuonsach.Text = "Mượn sách";
            this.btnMuonsach.UseVisualStyleBackColor = true;
            this.btnMuonsach.Click += new System.EventHandler(this.btnMuonsach_Click);
            // 
            // gcCT_PHIEUMUON
            // 
            this.gcCT_PHIEUMUON.AllowUserToAddRows = false;
            this.gcCT_PHIEUMUON.AllowUserToDeleteRows = false;
            this.gcCT_PHIEUMUON.AutoGenerateColumns = false;
            this.gcCT_PHIEUMUON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcCT_PHIEUMUON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcCT_PHIEUMUON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.cmbColMaSach,
            this.dataGridViewTextBoxColumn7,
            this.cmbColTinhTrang,
            this.cmbColTRA,
            this.cmbColMANVNS});
            this.gcCT_PHIEUMUON.DataSource = this.bdsCT_PHIEUMUON;
            this.gcCT_PHIEUMUON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCT_PHIEUMUON.Location = new System.Drawing.Point(490, 209);
            this.gcCT_PHIEUMUON.Name = "gcCT_PHIEUMUON";
            this.gcCT_PHIEUMUON.RowHeadersWidth = 51;
            this.gcCT_PHIEUMUON.RowTemplate.Height = 24;
            this.gcCT_PHIEUMUON.Size = new System.Drawing.Size(586, 342);
            this.gcCT_PHIEUMUON.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAPHIEU";
            this.dataGridViewTextBoxColumn5.FillWeight = 20.14307F;
            this.dataGridViewTextBoxColumn5.HeaderText = "MAPHIEU";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cmbColMaSach
            // 
            this.cmbColMaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cmbColMaSach.DataPropertyName = "MASACH";
            this.cmbColMaSach.FillWeight = 481.2834F;
            this.cmbColMaSach.HeaderText = "MASACH";
            this.cmbColMaSach.MinimumWidth = 6;
            this.cmbColMaSach.Name = "cmbColMaSach";
            this.cmbColMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbColMaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbColMaSach.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NGAYTRA";
            this.dataGridViewTextBoxColumn7.FillWeight = 24.64337F;
            this.dataGridViewTextBoxColumn7.HeaderText = "NGAYTRA";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // cmbColTinhTrang
            // 
            this.cmbColTinhTrang.DataPropertyName = "TINHTRANGMUON";
            this.cmbColTinhTrang.FillWeight = 24.64337F;
            this.cmbColTinhTrang.HeaderText = "TINHTRANGMUON";
            this.cmbColTinhTrang.MinimumWidth = 6;
            this.cmbColTinhTrang.Name = "cmbColTinhTrang";
            this.cmbColTinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmbColTRA
            // 
            this.cmbColTRA.DataPropertyName = "TRA";
            this.cmbColTRA.FillWeight = 24.64337F;
            this.cmbColTRA.HeaderText = "TRA";
            this.cmbColTRA.MinimumWidth = 6;
            this.cmbColTRA.Name = "cmbColTRA";
            this.cmbColTRA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmbColMANVNS
            // 
            this.cmbColMANVNS.DataPropertyName = "MANVNS";
            this.cmbColMANVNS.FillWeight = 24.64337F;
            this.cmbColMANVNS.HeaderText = "MANVNS";
            this.cmbColMANVNS.MinimumWidth = 6;
            this.cmbColMANVNS.Name = "cmbColMANVNS";
            this.cmbColMANVNS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbColMANVNS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dOCGIATableAdapter1
            // 
            this.dOCGIATableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPHIEU";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPHIEU";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmbColMADG
            // 
            this.cmbColMADG.DataPropertyName = "MADG";
            this.cmbColMADG.HeaderText = "MADG";
            this.cmbColMADG.MinimumWidth = 6;
            this.cmbColMADG.Name = "cmbColMADG";
            this.cmbColMADG.ReadOnly = true;
            this.cmbColMADG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbColMADG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbColHT
            // 
            this.cmbColHT.DataPropertyName = "HINHTHUC";
            this.cmbColHT.HeaderText = "HINHTHUC";
            this.cmbColHT.MinimumWidth = 6;
            this.cmbColHT.Name = "cmbColHT";
            this.cmbColHT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYMUON";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAYMUON";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cmbMANVColumn
            // 
            this.cmbMANVColumn.DataPropertyName = "MANV";
            this.cmbMANVColumn.HeaderText = "MANV";
            this.cmbMANVColumn.MinimumWidth = 6;
            this.cmbMANVColumn.Name = "cmbMANVColumn";
            this.cmbMANVColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbMANVColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmMuonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 679);
            this.Controls.Add(this.gcCT_PHIEUMUON);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gcPHIEUMUON);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMuonsach";
            this.Text = "frmMuonsach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMuonsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPHIEUMUON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_PHIEUMUON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_PHIEUMUON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.BindingSource bdsPM;
        private DS dS;
        private DSTableAdapters.PHIEUMUONTableAdapter PHIEUMUONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gcPHIEUMUON;
        private DevExpress.XtraEditors.GroupControl GroupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.ComboBox cmbHinhthuc;
        private System.Windows.Forms.BindingSource bdsCT_PHIEUMUON;
        private DSTableAdapters.CT_PHIEUMUONTableAdapter CT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.ComboBox cmbMAS;
        private System.Windows.Forms.ComboBox cmbMADG;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl GroupBox2;
        private System.Windows.Forms.DataGridView gcCT_PHIEUMUON;
        private System.Windows.Forms.Button btnXoasach;
        private System.Windows.Forms.Button btnMuonsach;
        private System.Windows.Forms.Label mASACHLabel;
        private System.Windows.Forms.Label mADGLabel;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private DSTableAdapters.DOCGIATableAdapter dOCGIATableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColTinhTrang;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColTRA;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColMANVNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColMADG;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbMANVColumn;
    }
}