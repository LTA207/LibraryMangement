using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmXoalogin: Form
    {
        public frmXoalogin()
        {
            InitializeComponent();
            setUpRole();
        }
        private void setUpRole()
        {
            // Tạo 1 danh sách quyền
            var listQuyen = new List<KeyValuePair<string, string>>()
    {
        new KeyValuePair<string, string>("dg", "Độc giả"),
        new KeyValuePair<string, string>("ad", "Thủ Thư")
    };

            // Gán danh sách cho ComboBox
            cmbRole.DataSource = listQuyen;
            cmbRole.DisplayMember = "Value";
            cmbRole.ValueMember = "Key";

            // Chọn mặc định là Độc giả
            cmbRole.SelectedIndex = 0;
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu quyền là Độc giả (dg)
            if (cmbRole.SelectedIndex == 0)
            {
                LoadDocGiaDaTaoTK();  // Gọi SP để tải độc giả chưa có tài khoản
            }
            else
            {
                LoadNhanVienDaTaoTK(); // Nếu là Thủ Thư, xóa danh sách trong cmbUser
            }
        }
        private void LoadDocGiaDaTaoTK()
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("LayDocGiaDaTaoTK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            cmbUser.DataSource = null;
                            cmbUser.Enabled = false;
                            return;
                        }

                        dt.Columns.Add("HienThi", typeof(string));
                        foreach (DataRow row in dt.Rows)
                        {
                            row["HienThi"] = $"{row["HODG"]} {row["TENDG"]} - {row["MADG"]}";
                        }

                        cmbUser.DataSource = dt;
                        cmbUser.DisplayMember = "HienThi";
                        cmbUser.ValueMember = "MADG";
                        cmbUser.Enabled = true;
                    }
                }
            }
        }

        private void LoadNhanVienDaTaoTK()
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("LayNhanVienDaTaoTK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        var rowsToRemove = dt.AsEnumerable()
                            .Where(r => r["MANV"].ToString() == Program.mId)
                            .ToList();

                        foreach (var row in rowsToRemove)
                        {
                            dt.Rows.Remove(row);
                        }

                        if (dt.Rows.Count == 0)
                        {
                            cmbUser.DataSource = null;
                            cmbUser.Items.Clear();
                            cmbUser.Enabled = false;
                            return;
                        }

                        dt.Columns.Add("HienThi", typeof(string));
                        foreach (DataRow row in dt.Rows)
                        {
                            row["HienThi"] = $"{row["HONV"]} {row["TENNV"]} - {row["MANV"]}";
                        }

                        cmbUser.DataSource = dt;
                        cmbUser.DisplayMember = "HienThi";
                        cmbUser.ValueMember = "MANV";
                        cmbUser.Enabled = true;
                    }
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string LayLoginNameTuUser(string userName)
        {
            string loginName = null;
            string query = @"
        USE SQLQLTV;
        SELECT sp.name AS LoginName
        FROM sys.database_principals dp
        JOIN sys.server_principals sp ON dp.sid = sp.sid
        WHERE dp.name = @UserName;
    ";

            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        loginName = result.ToString();
                }
            }

            return loginName;
        }

        private void btnXoaLogin_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa login!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rolePrefix = cmbRole.SelectedValue.ToString(); // "dg" hoặc "ad"
            string userCode = cmbUser.SelectedValue.ToString();   // MADG hoặc MANV
            string userName = $"{rolePrefix}{userCode}";
            string loginName = LayLoginNameTuUser(userName);

            if (loginName == null)
            {
                MessageBox.Show("Không tìm thấy login tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa login '{loginName}' và user '{userName}' không?\nThao tác này không thể hoàn tác!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();

                    // 1. Kill session nếu đang đăng nhập
                    string killSessionSql = @"
                DECLARE @sql NVARCHAR(MAX) = '';
                SELECT @sql += 'KILL ' + CAST(session_id AS VARCHAR) + ';'
                FROM sys.dm_exec_sessions
                WHERE login_name = @loginName;
                EXEC (@sql);
            ";

                    using (SqlCommand killCmd = new SqlCommand(killSessionSql, conn))
                    {
                        killCmd.Parameters.AddWithValue("@loginName", loginName);
                        killCmd.ExecuteNonQuery();
                    }

                    // 2. Xóa USER khỏi database hiện tại
                    string dropUserSql = $"USE {conn.Database}; DROP USER [{userName}];";
                    using (SqlCommand dropUserCmd = new SqlCommand(dropUserSql, conn))
                    {
                        dropUserCmd.ExecuteNonQuery();
                    }

                    // 3. Xóa LOGIN khỏi server
                    string dropLoginSql = $"DROP LOGIN [{loginName}];";
                    using (SqlCommand dropLoginCmd = new SqlCommand(dropLoginSql, conn))
                    {
                        dropLoginCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Đã xóa login '{loginName}' và user '{userName}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (rolePrefix == "dg")
                    {
                        LoadDocGiaDaTaoTK();
                    }
                    else
                    {
                        LoadNhanVienDaTaoTK();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa login/user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
