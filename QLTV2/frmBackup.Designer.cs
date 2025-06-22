namespace QLTV2
{
    partial class frmBackup
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSaoluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaodevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestoreInTime = new DevExpress.XtraBars.BarCheckItem();
            this.btnLog = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLTV2.DS();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new QLTV2.DSTableAdapters.DataTable2TableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.gcBackup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckReset = new System.Windows.Forms.CheckBox();
            this.dtpRestore = new System.Windows.Forms.DateTimePicker();
            this.te1 = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnSaoluu,
            this.btnPhuchoi,
            this.barButtonItem3,
            this.btnTaodevice,
            this.btnThoat,
            this.barCheckItem1,
            this.btnRestoreInTime,
            this.btnLog});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaoluu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhuchoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaodevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestoreInTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLog)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.Caption = "Sao lưu";
            this.btnSaoluu.Id = 0;
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoluu_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Id = 1;
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnTaodevice
            // 
            this.btnTaodevice.Caption = "Tạo device sao lưu";
            this.btnTaodevice.Id = 3;
            this.btnTaodevice.Name = "btnTaodevice";
            this.btnTaodevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaodevice_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnRestoreInTime
            // 
            this.btnRestoreInTime.Caption = "Tham số phục hồi theo thời gian";
            this.btnRestoreInTime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnRestoreInTime.Id = 6;
            this.btnRestoreInTime.Name = "btnRestoreInTime";
            // 
            // btnLog
            // 
            this.btnLog.Caption = "Sao lưu log";
            this.btnLog.Id = 7;
            this.btnLog.Name = "btnLog";
            this.btnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLog_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tham số phục hồi theo thời gian";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 5;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 450);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(800, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 450);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dS;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DAUSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
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
            // gcBackup
            // 
            this.gcBackup.AllowUserToAddRows = false;
            this.gcBackup.AllowUserToDeleteRows = false;
            this.gcBackup.AutoGenerateColumns = false;
            this.gcBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gcBackup.DataSource = this.dataTable2BindingSource;
            this.gcBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBackup.Location = new System.Drawing.Point(0, 25);
            this.gcBackup.Name = "gcBackup";
            this.gcBackup.RowHeadersWidth = 51;
            this.gcBackup.RowTemplate.Height = 24;
            this.gcBackup.Size = new System.Drawing.Size(800, 220);
            this.gcBackup.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Bản sao lưu thứ #";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bản sao lưu thứ #";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ngày giờ sao lưu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày giờ sao lưu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "User sao lưu";
            this.dataGridViewTextBoxColumn3.HeaderText = "User sao lưu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ckReset
            // 
            this.ckReset.AutoSize = true;
            this.ckReset.Location = new System.Drawing.Point(192, 295);
            this.ckReset.Name = "ckReset";
            this.ckReset.Size = new System.Drawing.Size(409, 20);
            this.ckReset.TabIndex = 18;
            this.ckReset.Text = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.ckReset.UseVisualStyleBackColor = true;
            // 
            // dtpRestore
            // 
            this.dtpRestore.CustomFormat = "dd/MM/yyyy";
            this.dtpRestore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRestore.Location = new System.Drawing.Point(343, 367);
            this.dtpRestore.Name = "dtpRestore";
            this.dtpRestore.Size = new System.Drawing.Size(200, 22);
            this.dtpRestore.TabIndex = 27;
            // 
            // te1
            // 
            this.te1.EditValue = new System.DateTime(2025, 5, 26, 14, 15, 40, 0);
            this.te1.Location = new System.Drawing.Point(562, 365);
            this.te1.MenuManager = this.barManager1;
            this.te1.Name = "te1";
            this.te1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te1.Size = new System.Drawing.Size(125, 24);
            this.te1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ngày giờ để phục hồi tới thời điểm đó";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.te1);
            this.Controls.Add(this.dtpRestore);
            this.Controls.Add(this.ckReset);
            this.Controls.Add(this.gcBackup);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te1.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnSaoluu;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnTaodevice;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarCheckItem btnRestoreInTime;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DS dS;
        private DSTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gcBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox ckReset;
        private System.Windows.Forms.DateTimePicker dtpRestore;
        private DevExpress.XtraEditors.TimeEdit te1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnLog;
    }
}