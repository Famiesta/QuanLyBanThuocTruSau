namespace QuanLyGarage
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLoiNhuan = new System.Windows.Forms.RadioButton();
            this.rdbDoanhThu = new System.Windows.Forms.RadioButton();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            //this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(270, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLoiNhuan);
            this.groupBox2.Controls.Add(this.rdbDoanhThu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(948, 122);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại thống kê";
            // 
            // rdbLoiNhuan
            // 
            this.rdbLoiNhuan.AutoSize = true;
            this.rdbLoiNhuan.Location = new System.Drawing.Point(514, 58);
            this.rdbLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbLoiNhuan.Name = "rdbLoiNhuan";
            this.rdbLoiNhuan.Size = new System.Drawing.Size(97, 23);
            this.rdbLoiNhuan.TabIndex = 1;
            this.rdbLoiNhuan.Text = "Lợi nhuận";
            this.rdbLoiNhuan.UseVisualStyleBackColor = true;
            // 
            // rdbDoanhThu
            // 
            this.rdbDoanhThu.AutoSize = true;
            this.rdbDoanhThu.Location = new System.Drawing.Point(213, 58);
            this.rdbDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDoanhThu.Name = "rdbDoanhThu";
            this.rdbDoanhThu.Size = new System.Drawing.Size(99, 23);
            this.rdbDoanhThu.TabIndex = 0;
            this.rdbDoanhThu.Text = "Doanh thu";
            this.rdbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(16, 307);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(947, 348);
            this.dgvThongKe.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Từ ngày:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(203, 73);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayBatDau.TabIndex = 37;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(507, 73);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayKetThuc.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Đến:";
        }
        //    // 
        //    // btnTaoBaoCao
        //    // 
        //    this.btnTaoBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnTaoBaoCao.Image = global::PMQuanLyBanHang_thuoctrusau_.Properties.Resources.report_icon;
        //    this.btnTaoBaoCao.Location = new System.Drawing.Point(246, 237);
        //    this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        //    this.btnTaoBaoCao.Name = "btnTaoBaoCao";
        //    this.btnTaoBaoCao.Size = new System.Drawing.Size(173, 48);
        //    this.btnTaoBaoCao.TabIndex = 41;
        //    this.btnTaoBaoCao.Text = "Tạo báo cáo";
        //    this.btnTaoBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //    this.btnTaoBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        //    this.btnTaoBaoCao.UseVisualStyleBackColor = true;
        //    this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
        //    // 
        //    // btnXuatExcel
        //    // 
        //    this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnXuatExcel.Image = global::PMQuanLyBanHang_thuoctrusau_.Properties.Resources.excel_icon;
        //    this.btnXuatExcel.Location = new System.Drawing.Point(440, 237);
        //    this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        //    this.btnXuatExcel.Name = "btnXuatExcel";
        //    this.btnXuatExcel.Size = new System.Drawing.Size(173, 48);
        //    this.btnXuatExcel.TabIndex = 35;
        //    this.btnXuatExcel.Text = "Xuất Excel";
        //    this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //    this.btnXuatExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        //    this.btnXuatExcel.UseVisualStyleBackColor = true;
        //    this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
        //    // 
        //    // frmThongKe
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(975, 744);
        //    this.Controls.Add(this.btnTaoBaoCao);
        //    this.Controls.Add(this.dtpNgayKetThuc);
        //    this.Controls.Add(this.label3);
        //    this.Controls.Add(this.dtpNgayBatDau);
        //    this.Controls.Add(this.label2);
        //    this.Controls.Add(this.btnXuatExcel);
        //    this.Controls.Add(this.dgvThongKe);
        //    this.Controls.Add(this.groupBox2);
        //    this.Controls.Add(this.label1);
        //    this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        //    this.Name = "frmThongKe";
        //    this.Text = "Thống kê";
        //    this.Load += new System.EventHandler(this.frmQuanLy_ThongKeBaoCao_Load);
        //    this.groupBox2.ResumeLayout(false);
        //    this.groupBox2.PerformLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLoiNhuan;
        private System.Windows.Forms.RadioButton rdbDoanhThu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoBaoCao;
    }
}