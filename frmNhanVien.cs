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
    public partial class frmNhanVien : Form
    {
        string connectionString;
        SqlConnection conn;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connectDB();
            LoadNhanVien();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Tìm kiếm...";
            txtSearch.GotFocus += (s, ev) =>
            {
                if (txtSearch.Text == "Tìm kiếm...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };
            txtSearch.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Tìm kiếm...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void connectDB()
        {
            connectionString = global::PMQuanLyBanHang_thuoctrusau_.Properties.Settings.Default.QuanLyBanHangThuocBVTVConnectionString;
            conn = new SqlConnection(connectionString);
        }
        private void LoadNhanVien()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                bangNV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ClearForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cbxChucVu.SelectedIndex = -1;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cbxGioitinh.SelectedIndex = -1;
            dateNgaySinh.Value = DateTime.Now;
            dateNgayVaoLam.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string query = @"INSERT INTO NhanVien 
                    (MaNhanVien, HoTen, ChucVu, SoDienThoai, NgaySinh, GioiTinh, DiaChi, NgayVaoLam) 
                    VALUES (@MaNV, @TenNV, @ChucVu, @SDT, @NgaySinh, @GioiTinh, @DiaChi, @NgayVaoLam)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@ChucVu", cbxChucVu.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbxGioitinh.Text == "Nam" ? 1 : 0);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@NgayVaoLam", dateNgayVaoLam.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadNhanVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE NhanVien SET 
                    HoTen=@TenNV, ChucVu=@ChucVu, SoDienThoai=@SDT, 
                    NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi
                    WHERE MaNhanVien=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@ChucVu", cbxChucVu.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cbxGioitinh.Text == "Nam" ? 1 : 0);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                //cmd.Parameters.AddWithValue("@NgayVaoLam", dateNgayVaoLam.Value);
                int success = cmd.ExecuteNonQuery();
                if (success != 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Không có dòng dữ liệu nào được cập nhật!");
                }

                LoadNhanVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNhanVien=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtHoTen.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadNhanVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void bangNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bangNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cbxChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                dateNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbxGioitinh.Text = Convert.ToBoolean(row.Cells["GioiTinh"].Value) ? "Nam" : "Nữ";
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dateNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (bangNV.DataSource as DataTable).DefaultView.RowFilter = string.Format("MaNhanVien LIKE '%{0}%' OR HoTen LIKE '%{0}%' OR ChucVu LIKE '%{0}%' OR SoDienThoai LIKE '%{0}%' OR DiaChi LIKE '%{0}%'", txtSearch.Text.Trim());
        }
    }
}
