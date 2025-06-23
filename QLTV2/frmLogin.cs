using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.KeyPress += TextBox_KeyPress_KhongDauCach;
            txtPassword.KeyPress += TextBox_KeyPress_KhongDauCach;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            Program.mlogin = txtUsername.Text.Trim();
            Program.password = txtPassword.Text.Trim();

            if (Program.KetNoi() == 1)
            {
                //try
                //{
                // Lấy ORIGINAL_LOGIN()
                string sql = "SELECT dp.name AS DatabaseUserName " +
                             "FROM sys.server_principals sp " +
                             "JOIN sys.syslogins sl ON sp.sid = sl.sid " +
                             "JOIN sys.database_principals dp ON dp.sid = sp.sid " +
                             "WHERE sp.name = ORIGINAL_LOGIN();";
                Program.myReader = Program.ExecSqlDataReader(sql);

                    string originalLogin = "";
                    if (Program.myReader != null && Program.myReader.Read())
                    {
                        originalLogin = Program.myReader.GetString(0);
                    }
                    Program.myReader.Close();

                    if (string.IsNullOrEmpty(originalLogin))
                    {
                        MessageBox.Show("Không lấy được thông tin login.");
                        return;
                    }

                    Program.username = originalLogin;
                    Program.mGroup = originalLogin.Substring(0, 2).ToLower();
                    Program.mId = originalLogin.Substring(2);

                    if (Program.mGroup == "dg")
                    {
                        sql = $"SELECT HODG + TENDG FROM DOCGIA WHERE MaDG = '{Program.mId}'";
                        Program.myReader = Program.ExecSqlDataReader(sql);

                        if (Program.myReader != null && Program.myReader.Read())
                        {
                            Program.mHoten = Program.myReader.GetString(0);
                            MessageBox.Show("Đăng nhập thành công!\nĐộc giả: " + Program.mHoten);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy độc giả.");
                        }
                        Program.myReader.Close();
                    }
                    else if (Program.mGroup == "ad")
                    {
                        sql = $"SELECT HONV + ' ' + TENNV FROM NHANVIEN WHERE MANV = '{Program.mId}'";
                        Program.myReader = Program.ExecSqlDataReader(sql);

                        if (Program.myReader != null && Program.myReader.Read())
                        {
                            Program.mHoten = Program.myReader.GetString(0);
                            MessageBox.Show("Đăng nhập thành công!\nNhân viên: " + Program.mHoten);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên.");
                        }
                        Program.myReader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không xác định được loại tài khoản.");
                    }

                    // ⭐ Nếu login thành công, mở Main Menu
                    this.Hide(); // Ẩn frmLogin
                    RibbonForm1 mainForm = new RibbonForm1();
                    mainForm.ShowDialog(); // Show MainForm dạng Dialog

                    // Khi MainForm đóng, frmLogin sẽ hiện lại
                    this.Show();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi xử lý đăng nhập: " + ex.Message);
                //}
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại tài khoản/mật khẩu.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát luôn chương trình
        }
        private void TextBox_KeyPress_KhongDauCach(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                //MessageBox.Show("Không được nhập dấu cách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
