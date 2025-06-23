namespace QLTV2
{
    partial class frmNhanvien
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
            System.Windows.Forms.Label hONVLabel;
            System.Windows.Forms.Label tENNVLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.Windows.Forms.Label eMAILLabel;
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
            this.btnTimkiem = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QLTV2.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QLTV2.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.CT_PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.CT_PHIEUMUONTableAdapter();
            this.gcNV = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.bdsCTPM = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUMUONTableAdapter = new QLTV2.DSTableAdapters.PHIEUMUONTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.btnFindNV = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.gcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHONV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColPhai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hONVLabel = new System.Windows.Forms.Label();
            tENNVLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hONVLabel
            // 
            hONVLabel.AutoSize = true;
            hONVLabel.Location = new System.Drawing.Point(42, 46);
            hONVLabel.Name = "hONVLabel";
            hONVLabel.Size = new System.Drawing.Size(45, 16);
            hONVLabel.TabIndex = 2;
            hONVLabel.Text = "HONV:";
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Location = new System.Drawing.Point(243, 46);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(51, 16);
            tENNVLabel.TabIndex = 4;
            tENNVLabel.Text = "TENNV:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(468, 116);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(65, 16);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "GIOITINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(481, 46);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(52, 16);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(11, 117);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(76, 16);
            dIENTHOAILabel.TabIndex = 10;
            dIENTHOAILabel.Text = "DIENTHOAI:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(247, 113);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(47, 16);
            eMAILLabel.TabIndex = 12;
            eMAILLabel.Text = "EMAIL:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1130, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1130, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1130, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Caption = "Tìm kiếm";
            this.btnTimkiem.Id = 5;
            this.btnTimkiem.Name = "btnTimkiem";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.dS;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = this.CT_PHIEUMUONTableAdapter;
            this.tableAdapterManager.DAUSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CT_PHIEUMUONTableAdapter
            // 
            this.CT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // gcNV
            // 
            this.gcNV.AllowUserToAddRows = false;
            this.gcNV.AllowUserToDeleteRows = false;
            this.gcNV.AutoGenerateColumns = false;
            this.gcNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcc,
            this.colHONV,
            this.colTENNV,
            this.cmbColPhai,
            this.dataGridViewTextBoxColumn4,
            this.colDIENTHOAI,
            this.dataGridViewTextBoxColumn6});
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNV.Location = new System.Drawing.Point(0, 25);
            this.gcNV.Name = "gcNV";
            this.gcNV.RowHeadersWidth = 51;
            this.gcNV.RowTemplate.Height = 24;
            this.gcNV.Size = new System.Drawing.Size(1130, 263);
            this.gcNV.TabIndex = 9;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(eMAILLabel);
            this.GroupBox1.Controls.Add(this.txtEMAIL);
            this.GroupBox1.Controls.Add(dIENTHOAILabel);
            this.GroupBox1.Controls.Add(this.txtPHONE);
            this.GroupBox1.Controls.Add(dIACHILabel);
            this.GroupBox1.Controls.Add(this.txtDIACHI);
            this.GroupBox1.Controls.Add(gIOITINHLabel);
            this.GroupBox1.Controls.Add(this.cmbPhai);
            this.GroupBox1.Controls.Add(tENNVLabel);
            this.GroupBox1.Controls.Add(this.txtTEN);
            this.GroupBox1.Controls.Add(hONVLabel);
            this.GroupBox1.Controls.Add(this.txtHO);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(323, 288);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(807, 248);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.Text = "groupControl1";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "EMAIL", true));
            this.txtEMAIL.Location = new System.Drawing.Point(300, 110);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(100, 23);
            this.txtEMAIL.TabIndex = 13;
            // 
            // txtPHONE
            // 
            this.txtPHONE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "DIENTHOAI", true));
            this.txtPHONE.Location = new System.Drawing.Point(93, 114);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(100, 23);
            this.txtPHONE.TabIndex = 11;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(539, 43);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(100, 23);
            this.txtDIACHI.TabIndex = 9;
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "GIOITINH", true));
            this.cmbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(539, 113);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(121, 24);
            this.cmbPhai.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TENNV", true));
            this.txtTEN.Location = new System.Drawing.Point(300, 43);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 23);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HONV", true));
            this.txtHO.Location = new System.Drawing.Point(93, 43);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(100, 23);
            this.txtHO.TabIndex = 3;
            // 
            // bdsCTPM
            // 
            this.bdsCTPM.DataMember = "FK__CT_PHIEUM__MANVN__440B1D61";
            this.bdsCTPM.DataSource = this.bdsNV;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "FK__PHIEUMUON__MANV__3F466844";
            this.bdsPM.DataSource = this.bdsNV;
            // 
            // PHIEUMUONTableAdapter
            // 
            this.PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dS;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnFindNV);
            this.GroupBox2.Controls.Add(this.txtTimkiem);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox2.Location = new System.Drawing.Point(0, 288);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(323, 248);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.Text = "groupControl1";
            // 
            // btnFindNV
            // 
            this.btnFindNV.Location = new System.Drawing.Point(114, 119);
            this.btnFindNV.Name = "btnFindNV";
            this.btnFindNV.Size = new System.Drawing.Size(75, 23);
            this.btnFindNV.TabIndex = 17;
            this.btnFindNV.Text = "Tìm kiếm";
            this.btnFindNV.UseVisualStyleBackColor = true;
            this.btnFindNV.Click += new System.EventHandler(this.btnFindNV_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(47, 53);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(212, 23);
            this.txtTimkiem.TabIndex = 16;
            // 
            // gcc
            // 
            this.gcc.DataPropertyName = "MANV";
            this.gcc.HeaderText = "MANV";
            this.gcc.MinimumWidth = 6;
            this.gcc.Name = "gcc";
            this.gcc.ReadOnly = true;
            // 
            // colHONV
            // 
            this.colHONV.DataPropertyName = "HONV";
            this.colHONV.HeaderText = "HONV";
            this.colHONV.MinimumWidth = 6;
            this.colHONV.Name = "colHONV";
            // 
            // colTENNV
            // 
            this.colTENNV.DataPropertyName = "TENNV";
            this.colTENNV.HeaderText = "TENNV";
            this.colTENNV.MinimumWidth = 6;
            this.colTENNV.Name = "colTENNV";
            // 
            // cmbColPhai
            // 
            this.cmbColPhai.DataPropertyName = "GIOITINH";
            this.cmbColPhai.HeaderText = "GIOITINH";
            this.cmbColPhai.MinimumWidth = 6;
            this.cmbColPhai.Name = "cmbColPhai";
            this.cmbColPhai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.colDIENTHOAI.HeaderText = "DIENTHOAI";
            this.colDIENTHOAI.MinimumWidth = 6;
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn6.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 536);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
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
        private System.Windows.Forms.BindingSource bdsNV;
        private DS dS;
        private DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gcNV;
        private DevExpress.XtraEditors.GroupControl GroupBox1;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private DSTableAdapters.CT_PHIEUMUONTableAdapter CT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private DSTableAdapters.PHIEUMUONTableAdapter PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DevExpress.XtraEditors.GroupControl GroupBox2;
        private System.Windows.Forms.Button btnFindNV;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHONV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENNV;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbColPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}