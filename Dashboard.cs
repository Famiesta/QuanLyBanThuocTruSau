using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQuanLyBanHang_thuoctrusau_
{
    public partial class Dashboard_cs : Form
    {
        private Timer timer;
        private Form currentFormChild;
        public string manv_ = "";
        SqlConnection conn = new SqlConnection("Server=MSI\\SQLEXPRESS01;Database=QuanLyBanHangBVTV;Integrated Security=True;TrustServerCertificate=True;");
        public Dashboard_cs()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
       
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lb_date.Text = date.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonHang());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHangHoa());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất.", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // Mở lại form đăng nhập
                this.Close();
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.Show();
                
            }
        }

        private void bangLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_cs_Load(object sender, EventArgs e)
        {

        }
    }
}
