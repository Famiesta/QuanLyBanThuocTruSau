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
    public partial class frmTaiKhoan : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            connectDB();
            LoadNhanVien();
            LoadTrangThai();
            LoadVaiTro();
            LoadTaiKhoan();
        }
        private void connectDB()
        {
            connectionString = global::PMQuanLyBanHang_thuoctrusau_.Properties.Settings.Default.QuanLyBanHangThuocBVTVConnectionString;
            conn = new SqlConnection(connectionString);
        }
        private void LoadNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen FROM NhanVien WHERE MaNhanVien NOT IN (SELECT MaNhanVien FROM TaiKhoan)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboMaNhanVien.DataSource = dt;
            comboMaNhanVien.DisplayMember = "HoTen";
            comboMaNhanVien.ValueMember = "MaNhanVien";
        }

        private void LoadVaiTro()
        {
            comboVaiTro.Items.Clear();
            comboVaiTro.Items.Add("QuanLy");
            comboVaiTro.Items.Add("NhanVien");
        }

        private void LoadTrangThai()
        {
            comboTrangThai.Items.Clear();
            comboTrangThai.Items.Add("Hoạt động");
            comboTrangThai.Items.Add("Không hoạt động");
            comboTrangThai.SelectedIndex = 0;
        }
        private void LoadTaiKhoan()
        {
            string query = @"SELECT TenDangNhap AS [Tài Khoản], MaNhanVien AS [Mã Nhân Viên],
                     VaiTro AS [Vai trò],
                     CASE WHEN TrangThaiTaiKhoan = 1 THEN N'Hoạt động' ELSE N'Không hoạt động' END AS [Trạng thái tài khoản]
                     FROM TaiKhoan";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTTTK.DataSource = dt;
        }
        private void comboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboTaiKhoan.Text;
            if (!string.IsNullOrEmpty(selectedUser))
            {
                string query = "SELECT TrangThaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @user";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", selectedUser);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    int dbStatus = Convert.ToInt32(result);
                    int selectedStatus = comboTrangThai.SelectedIndex == 0 ? 1 : 0;

                    btnThayDoiTrangThai.Visible = dbStatus != selectedStatus;
                }
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string username = comboTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string maNhanVien = comboMaNhanVien.SelectedValue.ToString();
            string vaiTro = comboVaiTro.SelectedItem?.ToString();
            int trangThai = comboTrangThai.SelectedIndex == 0 ? 1 : 0;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNhanVien = @maNV";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@maNV", maNhanVien);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, MatKhauHash, MaNhanVien, VaiTro, TrangThaiTaiKhoan) VALUES (@user, @pass, @maNV, @role, @status)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@user", username);
            insertCmd.Parameters.AddWithValue("@pass", hashedPassword);
            insertCmd.Parameters.AddWithValue("@maNV", maNhanVien);
            insertCmd.Parameters.AddWithValue("@role", vaiTro);
            insertCmd.Parameters.AddWithValue("@status", trangThai);

            conn.Open();
            insertCmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm tài khoản thành công!");
            LoadNhanVien();
            LoadTaiKhoan(); 

        }

        private void btnThayDoiTrangThai_Click(object sender, EventArgs e)
        {
            string username = comboTaiKhoan.Text.Trim();
            int newStatus = comboTrangThai.SelectedIndex == 0 ? 1 : 0;

            string updateQuery = "UPDATE TaiKhoan SET TrangThaiTaiKhoan = @status WHERE TenDangNhap = @user";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@status", newStatus);
            updateCmd.Parameters.AddWithValue("@user", username);

            conn.Open();
            updateCmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cập nhật trạng thái thành công!");
            btnThayDoiTrangThai.Visible = false;
            LoadTaiKhoan();
        }

        private void dgvTTTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTTTK.Rows[e.RowIndex];

                // Gán dữ liệu từ từng cột vào các control
                comboTaiKhoan.SelectedValue = row.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();  // Nếu mật khẩu không muốn hiển thị có thể bỏ dòng này

                comboMaNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value?.ToString(); // Giả sử bạn đã dùng SelectedValue = MaNV
                comboVaiTro.Text = row.Cells["VaiTro"].Value?.ToString(); // Hoặc dùng SelectedItem nếu muốn chính xác
                comboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }
    }
}
