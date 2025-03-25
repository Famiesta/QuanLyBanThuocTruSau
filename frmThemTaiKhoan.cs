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

namespace PMQuanLyBanHang_thuoctrusau_
{
    public partial class frmThemTaiKhoan : Form
    {
        string connectionString;
        SqlConnection conn;

        public frmThemTaiKhoan()
        {
            InitializeComponent();
            connectDB();
        }

        private void connectDB()
        {
            connectionString = global::PMQuanLyBanHang_thuoctrusau_.Properties.Settings.Default.QuanLyBanHangThuocBVTVConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            cboVaiTro.Items.Add("QuanLy");
            cboVaiTro.Items.Add("NhanVien");
            cboVaiTro.SelectedIndex = 1;
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                conn.Open();
                string query = "SELECT MaNhanVien, HoTen FROM NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboMaNhanVien.DataSource = dt;
                cboMaNhanVien.DisplayMember = "HoTen";
                cboMaNhanVien.ValueMember = "MaNhanVien";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string vaitro = cboVaiTro.SelectedItem?.ToString();
            string maNV = cboMaNhanVien.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", username);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mã hóa mật khẩu với BCrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, MaNhanVien, VaiTro) " +
                                     "VALUES (@username, @password, @manv, @vaitro)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@manv", maNV);
                cmd.Parameters.AddWithValue("@vaitro", vaitro);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
