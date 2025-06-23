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
    public partial class frmDoiPass: Form
    {
        public frmDoiPass()
        {
            InitializeComponent();
            setUpRole();
            txtPass.KeyPress += txtPassword_KeyPress;
            txtPassValid.KeyPress += txtPassword_KeyPress;
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
            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                // Mở kết nối
                conn.Open();

                // Tạo Command để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("LayNhanVienDaTaoTK", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tạo DataAdapter và DataTable để lưu trữ dữ liệu
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Thêm cột mới để gộp Họ, Tên và Mã Độc Giả
                        dt.Columns.Add("HienThi", typeof(string));
                        foreach (DataRow row in dt.Rows)
                        {
                            row["HienThi"] = $"{row["HONV"]} {row["TENNV"]} - {row["MANV"]}";
                        }

                        // Gán DataSource cho cmbUser
                        cmbUser.DataSource = dt;
                        cmbUser.DisplayMember = "HienThi";  // Cột mới để hiển thị
                        cmbUser.ValueMember = "MANV";        // Giá trị thực sự sẽ là MADG

                        cmbUser.Enabled = true;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có user được chọn chưa
            if (cmbUser.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần đổi mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Lấy thông tin mật khẩu
            string newPass = txtPass.Text.Trim();
            string confirmPass = txtPassValid.Text.Trim();

            // 3. Kiểm tra mật khẩu rỗng
            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Kiểm tra mật khẩu nhập lại có khớp không
            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Lấy login name để thực hiện đổi mật khẩu
            string rolePrefix = cmbRole.SelectedValue.ToString(); // "dg" hoặc "ad"
            string userCode = cmbUser.SelectedValue.ToString();   // MADG hoặc MANV

            string userName = $"{rolePrefix}{userCode}";
            string loginName = LayLoginNameTuUser(userName);

            // 6. Tạo câu lệnh đổi mật khẩu (ALTER LOGIN)
            string sql = $"ALTER LOGIN [{loginName}] WITH PASSWORD = '{newPass}'";

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    SqlConnection.ClearAllPools();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                //MessageBox.Show("Không được nhập dấu cách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
