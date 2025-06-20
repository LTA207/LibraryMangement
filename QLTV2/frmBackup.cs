using DevExpress.XtraCharts.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmBackup: Form
    {
        public frmBackup()
        {
            InitializeComponent();
            dtpRestore.Format = DateTimePickerFormat.Custom;
            dtpRestore.CustomFormat = "dd/MM/yyyy";
            te1.Time = DateTime.Now;
        }

        private void btnTaodevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string deviceName = "DEVICE_" + Program.database;
            string backupFilePath = @"D:\backup\" + Program.database + ".bak";

            string createDeviceQuery = $@" use master
            IF NOT EXISTS (SELECT * FROM sys.backup_devices WHERE name = '{deviceName}')
            BEGIN
                EXEC sp_addumpdevice 'disk', '{deviceName}', '{backupFilePath}'
            END";

            SqlCommand cmd = new SqlCommand(createDeviceQuery, Program.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tạo device sao lưu thành công.");

        }
        private void btnSaoluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string databaseName = Program.database;
                string deviceName = "DEVICE_" + databaseName;

                string initOption = ckReset.Checked ? "INIT" : "NOINIT";

                string backupQuery = $@"
                                     BACKUP DATABASE [{databaseName}] TO [{deviceName}]
                                     WITH {initOption}, NAME = 'Backup at {DateTime.Now:yyyy-MM-dd HH:mm:ss}'";

                // 🔥 Mở kết nối nếu chưa mở
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                SqlCommand cmd = new SqlCommand(backupQuery, Program.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sao lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dS.DataTable2.Clear();
                dataTable2TableAdapter.Fill(dS.DataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sao lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmBackup_Load(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this.dS.DataTable2);
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnRestoreInTime.Checked)
            {
                btnPhucHoiTheoThoiGian_ItemClick(sender, e);
                return;
            }

            try
            {
                int index = gcBackup.CurrentCell.RowIndex;
                index = int.Parse(gcBackup.Rows[index].Cells[0].Value.ToString());
                string databaseName = Program.database;
                string deviceName = "DEVICE_" + databaseName;

                if (Program.conn.State == ConnectionState.Open)
                    Program.conn.Close();

                // Kết nối lại và chuyển context về master
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();

                    // Set SINGLE_USER để đảm bảo không ai đang dùng database
                    string setSingleUser = $@" use master
            ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";

                    // Restore từ device
                    string restoreQuery = $@"
            RESTORE DATABASE [{databaseName}] FROM [{deviceName}]
            WITH FILE = {index}, REPLACE";

                    // Set MULTI_USER trở lại
                    string setMultiUser = $@"
            ALTER DATABASE [{databaseName}] SET MULTI_USER";

                    SqlCommand cmd1 = new SqlCommand(setSingleUser, conn);
                    SqlCommand cmd2 = new SqlCommand(restoreQuery, conn);
                    SqlCommand cmd3 = new SqlCommand(setMultiUser, conn);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show($"Phục hồi thành công về bản backup số {index}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Sau khi restore xong nên load lại nếu cần
                dS.DataTable2.Clear();
                dataTable2TableAdapter.Fill(dS.DataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phục hồi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhucHoiTheoThoiGian_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Lấy index bản full backup mà người dùng chọn trên lưới
                int index = gcBackup.CurrentCell.RowIndex;
                index = int.Parse(gcBackup.Rows[index].Cells[0].Value.ToString());

                string databaseName = Program.database;
                string deviceName = "DEVICE_" + databaseName;
                string backupFolder = @"D:\backup";

                // Thời điểm muốn phục hồi
                DateTime datePart = dtpRestore.Value.Date;
                TimeSpan timePart = te1.Time.TimeOfDay;
                DateTime stopAt = datePart.Add(timePart);

                if (stopAt > DateTime.Now.AddMinutes(-1))
                {
                    MessageBox.Show("Thời điểm phục hồi phải trước hiện tại ít nhất 1 phút!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Backup log hiện tại để tránh mất log chưa backup
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string logFilePath = $@"{backupFolder}\{databaseName}_Log_{timestamp}.trn";
                string backupLogQuery = $@"
BACKUP LOG [{databaseName}]
TO DISK = N'{logFilePath}'
WITH INIT, NAME = 'Log Backup at {DateTime.Now:yyyy-MM-dd HH:mm:ss}'";

                using (SqlCommand logCmd = new SqlCommand(backupLogQuery, Program.conn))
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    logCmd.ExecuteNonQuery();
                }
                if (Program.conn.State == ConnectionState.Open)
                    Program.conn.Close();

                DateTime fullBackupFinishDate;
                fullBackupFinishDate = (DateTime)dS.DataTable2.Rows[gcBackup.CurrentCell.RowIndex]["Ngày giờ sao lưu"];

                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();

                    // Đưa về SINGLE_USER
                    string setSingleUser = $@"USE master ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    using (SqlCommand cmd = new SqlCommand(setSingleUser, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Restore full backup từ device với FILE = index
                    string restoreFull = $@"
RESTORE DATABASE [{databaseName}]
FROM [{deviceName}]
WITH FILE = {index}, NORECOVERY, REPLACE";
                    using (SqlCommand cmd = new SqlCommand(restoreFull, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Bắt đầu restore log chain hợp lệ kể từ bản full
                    string[] allLogFiles = Directory.GetFiles(backupFolder, "*.trn");
                    var logFiles = allLogFiles
                        .Where(file => File.GetCreationTime(file) >= fullBackupFinishDate)
                        .OrderBy(f => File.GetCreationTime(f))
                        .ToArray();

                    if (logFiles.Length == 0)
                        throw new Exception("Không tìm thấy file log backup phù hợp với bản full backup đã chọn.");

                    bool stopApplied = false;

                    for (int i = 0; i < logFiles.Length; i++)
                    {
                        string logFile = logFiles[i];
                        string restoreLog;
                        DateTime logFileTime = File.GetCreationTime(logFile);

                        if (!stopApplied)
                        {
                            if (logFileTime >= stopAt)
                            {
                                restoreLog = $@"
RESTORE LOG [{databaseName}]
FROM DISK = N'{logFile}'
WITH STOPAT = '{stopAt:yyyy-MM-dd HH:mm:ss}', RECOVERY";
                                stopApplied = true;
                            }
                            else
                            {
                                restoreLog = $@"
RESTORE LOG [{databaseName}]
FROM DISK = N'{logFile}'
WITH NORECOVERY";
                            }
                        }
                        else
                        {
                            break;
                        }

                        using (SqlCommand cmd = new SqlCommand(restoreLog, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (!stopApplied)
                    {
                        throw new Exception("Không tìm thấy file log chứa thời điểm STOPAT.");
                    }
                }

                MessageBox.Show($"✅ Phục hồi thành công về thời điểm: {stopAt:yyyy-MM-dd HH:mm:ss}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dS.DataTable2.Clear();
                dataTable2TableAdapter.Fill(dS.DataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi phục hồi theo thời gian: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
{
    try
    {
        string databaseName = Program.database;
        string backupFolder = @"D:\backup";

        // Tạo tên file log backup với timestamp
        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string logFilePath = $@"{backupFolder}\{databaseName}_Log_{timestamp}.trn";

        // Câu lệnh backup log
        string backupLogQuery = $@"
BACKUP LOG [{databaseName}]
TO DISK = N'{logFilePath}'
WITH INIT, NAME = 'Log Backup at {DateTime.Now:yyyy-MM-dd HH:mm:ss}'";

        // Mở kết nối và thực thi backup
        using (SqlConnection conn = new SqlConnection(Program.connstr))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(backupLogQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        MessageBox.Show("✅ Backup log thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception ex)
    {
        MessageBox.Show("❌ Lỗi khi backup log: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
