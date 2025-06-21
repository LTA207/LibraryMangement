namespace QLTV2
{
    partial class frmDocgia
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
            System.Windows.Forms.Label hODGLabel;
            System.Windows.Forms.Label tENDGLabel;
            System.Windows.Forms.Label eMAILDGLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.Windows.Forms.Label nGAYLAMTHELabel;
            System.Windows.Forms.Label nGAYHETHANLabel;
            System.Windows.Forms.Label hOATDONGLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimkiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLTV2.DS();
            this.bdsDG = new System.Windows.Forms.BindingSource(this.components);
            this.DOCGIATableAdapter = new QLTV2.DSTableAdapters.DOCGIATableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.gcDG = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.btnFindDG = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cmbHD = new System.Windows.Forms.ComboBox();
            this.dtpHETHAN = new System.Windows.Forms.DateTimePicker();
            this.dtpLAMTHE = new System.Windows.Forms.DateTimePicker();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTENDG = new System.Windows.Forms.TextBox();
            this.txtHODG = new System.Windows.Forms.TextBox();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.PHIEUMUONTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHODG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColPhai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColHD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            hODGLabel = new System.Windows.Forms.Label();
            tENDGLabel = new System.Windows.Forms.Label();
            eMAILDGLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            nGAYLAMTHELabel = new System.Windows.Forms.Label();
            nGAYHETHANLabel = new System.Windows.Forms.Label();
            hOATDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // hODGLabel
            // 
            hODGLabel.AutoSize = true;
            hODGLabel.Location = new System.Drawing.Point(67, 48);
            hODGLabel.Name = "hODGLabel";
            hODGLabel.Size = new System.Drawing.Size(45, 16);
            hODGLabel.TabIndex = 0;
            hODGLabel.Text = "HODG:";
            // 
            // tENDGLabel
            // 
            tENDGLabel.AutoSize = true;
            tENDGLabel.Location = new System.Drawing.Point(354, 52);
            tENDGLabel.Name = "tENDGLabel";
            tENDGLabel.Size = new System.Drawing.Size(51, 16);
            tENDGLabel.TabIndex = 2;
            tENDGLabel.Text = "TENDG:";
            // 
            // eMAILDGLabel
            // 
            eMAILDGLabel.AutoSize = true;
            eMAILDGLabel.Location = new System.Drawing.Point(49, 108);
            eMAILDGLabel.Name = "eMAILDGLabel";
            eMAILDGLabel.Size = new System.Drawing.Size(63, 16);
            eMAILDGLabel.TabIndex = 4;
            eMAILDGLabel.Text = "EMAILDG:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(340, 113);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(65, 16);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "GIOITINH:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(809, 112);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(71, 16);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(591, 52);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(52, 16);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "DIACHI:";
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(567, 116);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(76, 16);
            dIENTHOAILabel.TabIndex = 12;
            dIENTHOAILabel.Text = "DIENTHOAI:";
            // 
            // nGAYLAMTHELabel
            // 
            nGAYLAMTHELabel.AutoSize = true;
            nGAYLAMTHELabel.Location = new System.Drawing.Point(790, 51);
            nGAYLAMTHELabel.Name = "nGAYLAMTHELabel";
            nGAYLAMTHELabel.Size = new System.Drawing.Size(90, 16);
            nGAYLAMTHELabel.TabIndex = 14;
            nGAYLAMTHELabel.Text = "NGAYLAMTHE:";
            // 
            // nGAYHETHANLabel
            // 
            nGAYHETHANLabel.AutoSize = true;
            nGAYHETHANLabel.Location = new System.Drawing.Point(22, 183);
            nGAYHETHANLabel.Name = "nGAYHETHANLabel";
            nGAYHETHANLabel.Size = new System.Drawing.Size(90, 16);
            nGAYHETHANLabel.TabIndex = 16;
            nGAYHETHANLabel.Text = "NGAYHETHAN:";
            // 
            // hOATDONGLabel
            // 
            hOATDONGLabel.AutoSize = true;
            hOATDONGLabel.Location = new System.Drawing.Point(361, 181);
            hOATDONGLabel.Name = "hOATDONGLabel";
            hOATDONGLabel.Size = new System.Drawing.Size(78, 16);
            hOATDONGLabel.TabIndex = 18;
            hOATDONGLabel.Text = "HOATDONG:";
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
            this.btnPhuchoi,
            this.btnReload,
            this.btnTimkiem,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTimkiem),
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
            this.btnPhuchoi.Id = 3;
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Caption = "Tìm kiếm";
            this.btnTimkiem.Id = 5;
            this.btnTimkiem.Name = "btnTimkiem";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1098, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 579);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1098, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1098, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDG
            // 
            this.bdsDG.DataMember = "DOCGIA";
            this.bdsDG.DataSource = this.dS;
            // 
            // DOCGIATableAdapter
            // 
            this.DOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DAUSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = this.DOCGIATableAdapter;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDG
            // 
            this.gcDG.AllowUserToAddRows = false;
            this.gcDG.AllowUserToDeleteRows = false;
            this.gcDG.AutoGenerateColumns = false;
            this.gcDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colHODG,
            this.colTENDG,
            this.dataGridViewTextBoxColumn4,
            this.cmbColPhai,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.cmbColHD});
            this.gcDG.DataSource = this.bdsDG;
            this.gcDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDG.Location = new System.Drawing.Point(0, 25);
            this.gcDG.Name = "gcDG";
            this.gcDG.RowHeadersWidth = 51;
            this.gcDG.RowTemplate.Height = 24;
            this.gcDG.Size = new System.Drawing.Size(1098, 220);
            this.gcDG.TabIndex = 5;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnFindDG);
            this.GroupBox1.Controls.Add(this.txtTimkiem);
            this.GroupBox1.Controls.Add(hOATDONGLabel);
            this.GroupBox1.Controls.Add(this.cmbHD);
            this.GroupBox1.Controls.Add(nGAYHETHANLabel);
            this.GroupBox1.Controls.Add(this.dtpHETHAN);
            this.GroupBox1.Controls.Add(nGAYLAMTHELabel);
            this.GroupBox1.Controls.Add(this.dtpLAMTHE);
            this.GroupBox1.Controls.Add(dIENTHOAILabel);
            this.GroupBox1.Controls.Add(this.txtPHONE);
            this.GroupBox1.Controls.Add(dIACHILabel);
            this.GroupBox1.Controls.Add(this.txtDIACHI);
            this.GroupBox1.Controls.Add(nGAYSINHLabel);
            this.GroupBox1.Controls.Add(this.dtpDOB);
            this.GroupBox1.Controls.Add(gIOITINHLabel);
            this.GroupBox1.Controls.Add(this.cmbPhai);
            this.GroupBox1.Controls.Add(eMAILDGLabel);
            this.GroupBox1.Controls.Add(this.txtEMAIL);
            this.GroupBox1.Controls.Add(tENDGLabel);
            this.GroupBox1.Controls.Add(this.txtTENDG);
            this.GroupBox1.Controls.Add(hODGLabel);
            this.GroupBox1.Controls.Add(this.txtHODG);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 245);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1098, 334);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.Text = "groupControl1";
            // 
            // btnFindDG
            // 
            this.btnFindDG.Location = new System.Drawing.Point(976, 177);
            this.btnFindDG.Name = "btnFindDG";
            this.btnFindDG.Size = new System.Drawing.Size(75, 23);
            this.btnFindDG.TabIndex = 21;
            this.btnFindDG.Text = "Tìm kiếm";
            this.btnFindDG.UseVisualStyleBackColor = true;
            this.btnFindDG.Click += new System.EventHandler(this.btnFindDG_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(700, 177);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(231, 23);
            this.txtTimkiem.TabIndex = 20;
            // 
            // cmbHD
            // 
            this.cmbHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "HOATDONG", true));
            this.cmbHD.FormattingEnabled = true;
            this.cmbHD.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbHD.Location = new System.Drawing.Point(445, 178);
            this.cmbHD.Name = "cmbHD";
            this.cmbHD.Size = new System.Drawing.Size(121, 24);
            this.cmbHD.TabIndex = 19;
            // 
            // dtpHETHAN
            // 
            this.dtpHETHAN.CustomFormat = "dd/MM/yyyy";
            this.dtpHETHAN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDG, "NGAYHETHAN", true));
            this.dtpHETHAN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHETHAN.Location = new System.Drawing.Point(118, 179);
            this.dtpHETHAN.Name = "dtpHETHAN";
            this.dtpHETHAN.Size = new System.Drawing.Size(200, 23);
            this.dtpHETHAN.TabIndex = 17;
            // 
            // dtpLAMTHE
            // 
            this.dtpLAMTHE.CustomFormat = "dd/MM/yyyy";
            this.dtpLAMTHE.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDG, "NGAYLAMTHE", true));
            this.dtpLAMTHE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLAMTHE.Location = new System.Drawing.Point(886, 47);
            this.dtpLAMTHE.Name = "dtpLAMTHE";
            this.dtpLAMTHE.Size = new System.Drawing.Size(200, 23);
            this.dtpLAMTHE.TabIndex = 15;
            // 
            // txtPHONE
            // 
            this.txtPHONE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "DIENTHOAI", true));
            this.txtPHONE.Location = new System.Drawing.Point(649, 113);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(100, 23);
            this.txtPHONE.TabIndex = 13;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(649, 49);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(100, 23);
            this.txtDIACHI.TabIndex = 11;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDG, "NGAYSINH", true));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(886, 108);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 23);
            this.dtpDOB.TabIndex = 9;
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "GIOITINH", true));
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(411, 110);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(121, 24);
            this.cmbPhai.TabIndex = 7;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "EMAILDG", true));
            this.txtEMAIL.Location = new System.Drawing.Point(118, 105);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(205, 23);
            this.txtEMAIL.TabIndex = 5;
            // 
            // txtTENDG
            // 
            this.txtTENDG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "TENDG", true));
            this.txtTENDG.Location = new System.Drawing.Point(411, 49);
            this.txtTENDG.Name = "txtTENDG";
            this.txtTENDG.Size = new System.Drawing.Size(100, 23);
            this.txtTENDG.TabIndex = 3;
            // 
            // txtHODG
            // 
            this.txtHODG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDG, "HODG", true));
            this.txtHODG.Location = new System.Drawing.Point(118, 45);
            this.txtHODG.Name = "txtHODG";
            this.txtHODG.Size = new System.Drawing.Size(100, 23);
            this.txtHODG.TabIndex = 1;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "FK__PHIEUMUON__MADG__3E52440B";
            this.bdsPM.DataSource = this.bdsDG;
            // 
            // PHIEUMUONTableAdapter
            // 
            this.PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADG";
            this.dataGridViewTextBoxColumn1.HeaderText = "MADG";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colHODG
            // 
            this.colHODG.DataPropertyName = "HODG";
            this.colHODG.HeaderText = "HODG";
            this.colHODG.MinimumWidth = 6;
            this.colHODG.Name = "colHODG";
            // 
            // colTENDG
            // 
            this.colTENDG.DataPropertyName = "TENDG";
            this.colTENDG.HeaderText = "TENDG";
            this.colTENDG.MinimumWidth = 6;
            this.colTENDG.Name = "colTENDG";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAILDG";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMAILDG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cmbColPhai
            // 
            this.cmbColPhai.DataPropertyName = "GIOITINH";
            this.cmbColPhai.HeaderText = "GIOITINH";
            this.cmbColPhai.MinimumWidth = 6;
            this.cmbColPhai.Name = "cmbColPhai";
            this.cmbColPhai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn6.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn7.HeaderText = "DIENTHOAI";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NGAYLAMTHE";
            this.dataGridViewTextBoxColumn8.HeaderText = "NGAYLAMTHE";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NGAYHETHAN";
            this.dataGridViewTextBoxColumn9.HeaderText = "NGAYHETHAN";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // cmbColHD
            // 
            this.cmbColHD.DataPropertyName = "HOATDONG";
            this.cmbColHD.HeaderText = "HOATDONG";
            this.cmbColHD.MinimumWidth = 6;
            this.cmbColHD.Name = "cmbColHD";
            this.cmbColHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 579);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gcDG);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDocgia";
            this.Text = "frmDocgia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnTimkiem;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsDG;
        private DS dS;
        private DSTableAdapters.DOCGIATableAdapter DOCGIATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gcDG;
        private DevExpress.XtraEditors.GroupControl GroupBox1;
        private System.Windows.Forms.TextBox txtHODG;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTENDG;
        private System.Windows.Forms.DateTimePicker dtpHETHAN;
        private System.Windows.Forms.DateTimePicker dtpLAMTHE;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.BindingSource bdsPM;
        private DSTableAdapters.PHIEUMUONTableAdapter PHIEUMUONTableAdapter;
        private System.Windows.Forms.ComboBox cmbHD;
        private System.Windows.Forms.Button btnFindDG;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHODG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColHD;
    }
}