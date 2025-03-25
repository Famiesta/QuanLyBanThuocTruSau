//    using Microsoft.Office.Interop.Word;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Diagnostics;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;
//using System.Runtime.InteropServices;
//using OfficeOpenXml;
//using DocumentFormat.OpenXml.Spreadsheet;

//namespace QuanLyGarage
//{
//    public partial class frmThongKe : Form
//    {
//        public frmThongKe()
//        {
//            InitializeComponent();
//        }

//        private void frmQuanLy_ThongKeBaoCao_Load(object sender, EventArgs e)
//        {
//        }

//        string connectionString = @"Data Source=MSI\SQLEXPRESS01;Initial Catalog=QuanLyGarageOto;Integrated Security=True";
//        SqlConnection conn;
//        void connectDB()
//        {
//            try
//            {
//                conn = new SqlConnection(connectionString);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnTaoBaoCao_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();
//                    string NgayBatDau = dtpNgayBatDau.Value.ToString("yyyy-MM-dd");
//                    string NgayKetThuc = dtpNgayKetThuc.Value.ToString("yyyy-MM-dd");

//                    string query = "";
//                    if (rdbChiPhiNhapXe.Checked == true)
//                    {
//                        //Chi phí nhập xe
//                        //Tổng chi phí = Số lượng nhập x chi phí đơn giá
//                        query = @"
//                    SELECT 
//                        PHIEUNHAPXE.NgayLap AS 'Ngày lập',
//                        XE.TenXe AS 'Tên xe',
//                        SUM(CHITIETPHIEUNHAP_XE.SoLuong) AS 'Số lượng nhập',
//                        CHITIETPHIEUNHAP_XE.GiaNhap AS 'Chi phí (đơn giá)',
//                        SUM(CHITIETPHIEUNHAP_XE.ThanhTien) AS 'Tổng chi phí'
//                    FROM 
//                        CHITIETPHIEUNHAP_XE
//                    INNER JOIN 
//                        XE ON CHITIETPHIEUNHAP_XE.MaXe = XE.MaXe
//                    INNER JOIN 
//                        PHIEUNHAPXE ON CHITIETPHIEUNHAP_XE.MaPhieuNhapXe = PHIEUNHAPXE.MaPhieuNhapXe
//                    WHERE 
//                        PHIEUNHAPXE.NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc
//                    GROUP BY 
//                        PHIEUNHAPXE.NgayLap, XE.TenXe, CHITIETPHIEUNHAP_XE.GiaNhap
//                    ORDER BY 
//                        PHIEUNHAPXE.NgayLap;";
//                    }
//                    //Số lượng bán xe
//                    //Số lượng đã bán = số lượng bán
//                    else if (rdbSoLuongBanXe.Checked == true)
//                    {
//                        query = @"
//                    SELECT 
//                        HOADON.NgayLap AS 'Ngày lập',
//                        XE.TenXe AS 'Tên xe',
//                        SUM(CHITIETHOADON.SoLuongMua) AS 'Số lượng đã bán'
//                    FROM 
//                        CHITIETHOADON
//                    INNER JOIN 
//                        XE ON CHITIETHOADON.MaXe = XE.MaXe
//                    INNER JOIN 
//                        HOADON ON CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon
//                    WHERE 
//                        HOADON.NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc
//                    GROUP BY 
//                        HOADON.NgayLap, XE.TenXe
//                    ORDER BY 
//                        HOADON.NgayLap;";
//                    }
//                    /*Chi phí nhập phụ tùng
//                    Tổng chi phí = số lượng nhập x giá nhập*/
//                    else if (rdbChiPhiNhapPhuTung.Checked == true)
//                    {
//                        query = @"
//                    SELECT 
//                        PHIEUNHAPPHUTUNG.NgayLap AS 'Ngày lập',
//                        PHUTUNG.TenPhuTung AS 'Tên phụ tùng',
//                        SUM(CHITIETPHIEUNHAP_PHUTUNG.SoLuong) AS 'Số lượng nhập',
//                        CHITIETPHIEUNHAP_PHUTUNG.GiaNhap AS 'Chi phí (đơn giá)',
//                        SUM(CHITIETPHIEUNHAP_PHUTUNG.ThanhTien) AS 'Tổng chi phí'
//                    FROM 
//                        CHITIETPHIEUNHAP_PHUTUNG
//                    INNER JOIN 
//                        PHUTUNG ON CHITIETPHIEUNHAP_PHUTUNG.MaPhuTung = PHUTUNG.MaPhuTung
//                    INNER JOIN 
//                        PHIEUNHAPPHUTUNG ON CHITIETPHIEUNHAP_PHUTUNG.MaPhieuNhapPhuTung = PHIEUNHAPPHUTUNG.MaPhieuNhapPhuTung
//                    WHERE 
//                        PHIEUNHAPPHUTUNG.NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc
//                    GROUP BY 
//                        PHIEUNHAPPHUTUNG.NgayLap, PHUTUNG.TenPhuTung, CHITIETPHIEUNHAP_PHUTUNG.GiaNhap
//                    ORDER BY 
//                        PHIEUNHAPPHUTUNG.NgayLap;";
//                    }
//                    /*Số lượng bán phụ tùng
//                    Tổng số lượng bán = số lượng bán*/
//                    else if (rdbSoLuongBanPhuTung.Checked == true)
//                    {
//                        query = @"
//                        SELECT 
//                            PHIEUSUACHUA.NgayLap AS 'Ngày lập',
//                            PHUTUNG.TenPhuTung AS 'Tên phụ tùng',
//                            SUM(CHITIETSUACHUA.SoLuongPhuTung) AS 'Số lượng bán'
//                        FROM 
//                            CHITIETSUACHUA
//                        INNER JOIN 
//                            PHUTUNG ON CHITIETSUACHUA.MaPhuTung = PHUTUNG.MaPhuTung
//                        INNER JOIN 
//                            PHIEUSUACHUA ON CHITIETSUACHUA.MaPhieuSuaChua = PHIEUSUACHUA.MaPhieuSuaChua
//                        WHERE 
//                            PHIEUSUACHUA.NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc
//                        GROUP BY 
//                            PHIEUSUACHUA.NgayLap, PHUTUNG.TenPhuTung
//                        ORDER BY 
//                            PHIEUSUACHUA.NgayLap;";
//                    }
//                    //Doanh thu = số lượng bán xe x giá bán
                    
//                    else if (rdbDoanhThu.Checked == true)
//                    {
//                        query = @"
//                       WITH DoanhThuChiTiet AS (

//                        SELECT 
//                            HOADON.NgayLap AS NgayLap,
//                            XE.TenXe AS TenSanPham,
//                            CHITIETHOADON.ThanhTien
//                        FROM 
//                            CHITIETHOADON
//                        INNER JOIN 
//                            XE ON CHITIETHOADON.MaXe = XE.MaXe
//                        INNER JOIN 
//                            HOADON ON CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon

//                        UNION ALL

//                        SELECT 
//                            PHIEUSUACHUA.NgayLap AS NgayLap,
//                            SUACHUA.TenSuaChua AS TenSanPham,
//                            CHITIETSUACHUA.ThanhTien
//                        FROM 
//                            CHITIETSUACHUA
//                        INNER JOIN 
//                            SUACHUA ON CHITIETSUACHUA.MaSuaChua = SUACHUA.MaSuaChua
//                        INNER JOIN 
//                            PHIEUSUACHUA ON CHITIETSUACHUA.MaPhieuSuaChua = PHIEUSUACHUA.MaPhieuSuaChua
//                    )

//                    SELECT 
//                        NgayLap,
//                        TenSanPham,
//                        ThanhTien,
//                        TongDoanhThu
//                    FROM (
//                        SELECT 
//                            NgayLap,
//                            TenSanPham,
//                            ThanhTien,
//                            NULL AS TongDoanhThu,
//                            1 AS SapXep
//                        FROM 
//                            DoanhThuChiTiet

//                        UNION ALL

//                        SELECT 
//                            NULL AS NgayLap,
//                            N'Tổng cộng' AS TenSanPham,
//                            NULL AS ThanhTien,
//                            SUM(ThanhTien) AS TongDoanhThu,
//                            2 AS SapXep
//                        FROM 
//                            DoanhThuChiTiet
//                    ) AS KetQua
//                    ORDER BY 
//                        SapXep,
//                        NgayLap;";
//                    }
//                    //Lợi nhuận = Doanh thu - chi phí nhập
//                    else if (rdbLoiNhuan.Checked == true)
//                    {
//                        query = @"
//                    SELECT 
//                        HOADON.NgayLap AS 'Ngày lập',
//                        SUM(CHITIETHOADON.ThanhTien - CHITIETPHIEUNHAP_XE.ThanhTien) AS 'Lợi nhuận'
//                    FROM 
//                        CHITIETHOADON
//                    INNER JOIN 
//                        HOADON ON CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon
//                    LEFT JOIN 
//                        CHITIETPHIEUNHAP_XE ON CHITIETHOADON.MaXe = CHITIETPHIEUNHAP_XE.MaXe
//                    WHERE 
//                        HOADON.NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc
//                    GROUP BY 
//                        HOADON.NgayLap
//                    ORDER BY 
//                        HOADON.NgayLap;";
//                    }
//                    else
//                    {
//                        MessageBox.Show("Vui lòng chọn một hình thức để thống kê: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        return;
//                    }
//                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
//                    adapter.SelectCommand.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
//                    adapter.SelectCommand.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);

//                    DataSet ds = new DataSet();
//                    adapter.Fill(ds);

//                    dgvThongKe.DataSource = ds.Tables[0];
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnXuatExcel_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
//                {
//                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
//                    saveFileDialog.FilterIndex = 1;
//                    saveFileDialog.RestoreDirectory = true;
//                    saveFileDialog.Title = "Chọn nơi lưu file Excel";
//                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
//                    {
//                        string filePath = saveFileDialog.FileName;

//                        if (!filePath.ToLower().EndsWith(".xlsx"))
//                        {
//                            filePath += ".xlsx";
//                        }
//                        ExportToExcel(dgvThongKe, filePath);

//                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                        Process.Start(filePath);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Đã xảy ra lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void ExportToExcel(DataGridView dataGrid, string filePath) 
//        {
//            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

//            using (var package = new ExcelPackage())
//            {
//                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
//                for (int i = 0; i < dataGrid.Columns.Count; i++)
//                {
//                    worksheet.Cells[1, i + 1].Value = dataGrid.Columns[i].HeaderText;
//                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
//                }
//                for (int i = 0; i < dataGrid.Rows.Count; i++)
//                {
//                    for (int j = 0; j < dataGrid.Columns.Count; j++)
//                    {
//                        var cellValue = dataGrid.Rows[i].Cells[j].Value;
//                        worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
//                    }
//                }

//                File.WriteAllBytes(filePath, package.GetAsByteArray());
//            }
//        }


//    }
//}

