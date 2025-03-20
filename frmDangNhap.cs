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
            }
            else if (role == "NhanVien")
            {
                MessageBox.Show("Đăng nhập thành công với quyền nhân viên", "Thông báo");
            }
            else if (role == "err")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhauHash = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Session.MaTK = reader["MaTK"].ToString();
                        Session.VaiTro = reader["VaiTro"].ToString();
                        Session.TenDangNhap = username;
                        return Session.VaiTro;
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
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            chkRemember.Checked = Properties.Settings.Default.RememberMe;
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
