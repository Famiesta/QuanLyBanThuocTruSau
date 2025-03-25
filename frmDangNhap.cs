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
using static System.Collections.Specialized.BitVector32;

namespace PMQuanLyBanHang_thuoctrusau_
{
    public partial class frmDangNhap : Form
    {
        string connectionString;
        SqlConnection conn;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = checkRole(username, password);
            if (role == "QuanLy")
            {
                MessageBox.Show("Đăng nhập thành công với quyền quản lý", "Thông báo");
                Dashboard_cs mainForm = new Dashboard_cs();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else if (role == "NhanVien")
            {
                MessageBox.Show("Đăng nhập thành công với quyền nhân viên", "Thông báo");
                Dashboard_cs mainForm = new Dashboard_cs();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else if (role == "err")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();   
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi: " + role, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string checkRole(string username, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT NhanVien.MaNhanVien, VaiTro, MatKhauHash FROM TaiKhoan, NhanVien WHERE TaiKhoan.MaNhanVien = NhanVien.MaNhanVien AND TaiKhoan.TenDangNhap = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashedPasswordFromDB = reader["MatKhauHash"].ToString();

                        // So sánh mật khẩu bằng BCrypt
                        bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDB);

                        if (isPasswordCorrect)
                        {
                            Session.MaTK = reader["MaNhanVien"].ToString();
                            Session.VaiTro = reader["VaiTro"].ToString();
                            Session.TenDangNhap = username;
                            return Session.VaiTro;
                        }
                        else return "err";
                    }
                    else return "err";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
        }
        private void connectDB()
        {
            connectionString = global::PMQuanLyBanHang_thuoctrusau_.Properties.Settings.Default.QuanLyBanHangThuocBVTVConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            connectDB();
            txtUsername.Focus();
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            chkRemember.Checked = Properties.Settings.Default.RememberMe;
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "Tên đăng nhập";
            txtUsername.GotFocus += (s, ev) =>
            {
                if (txtUsername.Text == "Tên đăng nhập")
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = Color.Black;
                }
            };
            txtUsername.LostFocus += (s, ev) =>

            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Tên đăng nhập";
                    txtUsername.ForeColor = Color.Gray;
                }
            };
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Mật khẩu";
            txtPassword.GotFocus += (s, ev) =>
            {
                if (txtPassword.Text == "Mật khẩu")
                {
                    txtPassword.PasswordChar = '*';
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                }
            };
            txtPassword.LostFocus += (s, ev) =>

            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.PasswordChar = '\0';
                    txtPassword.Text = "Mật khẩu";
                    txtPassword.ForeColor = Color.Gray;
                }
            };

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
