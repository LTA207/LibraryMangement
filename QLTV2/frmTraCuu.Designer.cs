namespace QLTV2
{
    partial class frmTraCuu
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bdsTraCuu = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLTV2.DS();
            this.TRACUUSACHTableAdapter = new QLTV2.DSTableAdapters.TRACUUSACHTableAdapter();
            this.tableAdapterManager = new QLTV2.DSTableAdapters.TableAdapterManager();
            this.gcTraCuu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cmbNN = new System.Windows.Forms.ComboBox();
            this.cmbTL = new System.Windows.Forms.ComboBox();
            this.cmbTG = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngôn ngữ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(900, 218);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 90);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tra cứu sách";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.cmbTG);
            this.groupControl1.Controls.Add(this.cmbTL);
            this.groupControl1.Controls.Add(this.cmbNN);
            this.groupControl1.Controls.Add(this.txtTenSach);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1225, 269);
            this.groupControl1.TabIndex = 10;
            // 
            // bdsTraCuu
            // 
            this.bdsTraCuu.DataMember = "TRACUUSACH";
            this.bdsTraCuu.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TRACUUSACHTableAdapter
            // 
            this.TRACUUSACHTableAdapter.ClearBeforeFill = true;
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
            // gcTraCuu
            // 
            this.gcTraCuu.AllowUserToAddRows = false;
            this.gcTraCuu.AllowUserToDeleteRows = false;
            this.gcTraCuu.AutoGenerateColumns = false;
            this.gcTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.gcTraCuu.DataSource = this.bdsTraCuu;
            this.gcTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTraCuu.Location = new System.Drawing.Point(0, 269);
            this.gcTraCuu.Name = "gcTraCuu";
            this.gcTraCuu.RowHeadersWidth = 51;
            this.gcTraCuu.RowTemplate.Height = 24;
            this.gcTraCuu.Size = new System.Drawing.Size(1225, 409);
            this.gcTraCuu.TabIndex = 11;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSACH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENSACH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TacGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "TacGia";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGONNGU";
            this.dataGridViewTextBoxColumn4.HeaderText = "NGONNGU";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "THELOAI";
            this.dataGridViewTextBoxColumn5.HeaderText = "THELOAI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOTRANG";
            this.dataGridViewTextBoxColumn6.HeaderText = "SOTRANG";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NGAYXUATBAN";
            this.dataGridViewTextBoxColumn7.HeaderText = "NGAYXUATBAN";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TongSoCuon";
            this.dataGridViewTextBoxColumn8.HeaderText = "TongSoCuon";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SoLuongCon";
            this.dataGridViewTextBoxColumn9.HeaderText = "SoLuongCon";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(198, 152);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(286, 23);
            this.txtTenSach.TabIndex = 11;
            // 
            // cmbNN
            // 
            this.cmbNN.FormattingEnabled = true;
            this.cmbNN.Location = new System.Drawing.Point(198, 213);
            this.cmbNN.Name = "cmbNN";
            this.cmbNN.Size = new System.Drawing.Size(286, 24);
            this.cmbNN.TabIndex = 12;
            // 
            // cmbTL
            // 
            this.cmbTL.FormattingEnabled = true;
            this.cmbTL.Location = new System.Drawing.Point(582, 152);
            this.cmbTL.Name = "cmbTL";
            this.cmbTL.Size = new System.Drawing.Size(266, 24);
            this.cmbTL.TabIndex = 13;
            // 
            // cmbTG
            // 
            this.cmbTG.FormattingEnabled = true;
            this.cmbTG.Location = new System.Drawing.Point(582, 213);
            this.cmbTG.Name = "cmbTG";
            this.cmbTG.Size = new System.Drawing.Size(266, 24);
            this.cmbTG.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(900, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Xóa lọc";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 678);
            this.Controls.Add(this.gcTraCuu);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTraCuu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsTraCuu;
        private DSTableAdapters.TRACUUSACHTableAdapter TRACUUSACHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gcTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private System.Windows.Forms.ComboBox cmbTL;
        private System.Windows.Forms.ComboBox cmbNN;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cmbTG;
        private System.Windows.Forms.Button btnClear;
    }
}