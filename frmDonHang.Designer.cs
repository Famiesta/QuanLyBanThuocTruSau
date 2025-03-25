namespace PMQuanLyBanHang_thuoctrusau_
{
    partial class frmDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_layma = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.lb_nv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.cbxTenHangHoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenKH = new System.Windows.Forms.ComboBox();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.btnDatLich = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bangDatLich = new System.Windows.Forms.DataGridView();
            this.MALT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bangDatLich)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(962, 229);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(144, 30);
            this.txtMaNV.TabIndex = 142;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(845, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 141;
            this.label8.Text = "NV Tạo HD";
            // 
            // lb_layma
            // 
            this.lb_layma.AutoSize = true;
            this.lb_layma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_layma.Location = new System.Drawing.Point(1050, 154);
            this.lb_layma.Name = "lb_layma";
            this.lb_layma.Size = new System.Drawing.Size(56, 20);
            this.lb_layma.TabIndex = 140;
            this.lb_layma.Text = "Lấy mã";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(962, 177);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(144, 30);
            this.txtMaHD.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(845, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 138;
            this.label7.Text = "Mã Hóa Đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoRoundedCorners = true;
            this.btnThanhToan.BorderRadius = 21;
            this.btnThanhToan.FillColor = System.Drawing.Color.Orange;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(1124, 162);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(168, 45);
            this.btnThanhToan.TabIndex = 137;
            this.btnThanhToan.Text = "Thanh toán";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoRoundedCorners = true;
            this.btnLamMoi.BorderRadius = 21;
            this.btnLamMoi.FillColor = System.Drawing.Color.Orange;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1124, 221);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(168, 45);
            this.btnLamMoi.TabIndex = 136;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(573, 115);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(250, 31);
            this.cbxNhanVien.TabIndex = 135;
            // 
            // lb_nv
            // 
            this.lb_nv.AutoSize = true;
            this.lb_nv.BackColor = System.Drawing.Color.Transparent;
            this.lb_nv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nv.Location = new System.Drawing.Point(374, 120);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(115, 23);
            this.lb_nv.TabIndex = 134;
            this.lb_nv.Text = "NV Phụ trách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 133;
            this.label3.Text = "Thời Gian Giao Hàng";
            // 
            // dateKT
            // 
            this.dateKT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateKT.Location = new System.Drawing.Point(573, 223);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(250, 30);
            this.dateKT.TabIndex = 132;
            this.dateKT.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 21;
            this.btnLuu.FillColor = System.Drawing.Color.Orange;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1125, 102);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(168, 45);
            this.btnLuu.TabIndex = 131;
            this.btnLuu.Text = "Lưu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 130;
            this.label9.Text = "Thời Gian Đặt";
            // 
            // dateBD
            // 
            this.dateBD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateBD.Location = new System.Drawing.Point(573, 164);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(250, 30);
            this.dateBD.TabIndex = 129;
            this.dateBD.Value = new System.DateTime(2025, 3, 20, 0, 0, 0, 0);
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.Location = new System.Drawing.Point(169, 66);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(184, 30);
            this.txtMaDH.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 127;
            this.label4.Text = "Mã Đơn Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(169, 171);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(184, 30);
            this.txtMaKH.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 125;
            this.label6.Text = "Mã Khách Hàng";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(169, 221);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(184, 30);
            this.txtGiaTien.TabIndex = 124;
            // 
            // cbxTenHangHoa
            // 
            this.cbxTenHangHoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenHangHoa.FormattingEnabled = true;
            this.cbxTenHangHoa.Location = new System.Drawing.Point(169, 120);
            this.cbxTenHangHoa.Name = "cbxTenHangHoa";
            this.cbxTenHangHoa.Size = new System.Drawing.Size(184, 31);
            this.cbxTenHangHoa.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 121;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 120;
            this.label1.Text = "Đơn Hàng";
            // 
            // cbxTenKH
            // 
            this.cbxTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenKH.FormattingEnabled = true;
            this.cbxTenKH.Location = new System.Drawing.Point(573, 60);
            this.cbxTenKH.Name = "cbxTenKH";
            this.cbxTenKH.Size = new System.Drawing.Size(250, 31);
            this.cbxTenKH.TabIndex = 119;
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh.Location = new System.Drawing.Point(374, 66);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(138, 23);
            this.lb_tenkh.TabIndex = 118;
            this.lb_tenkh.Text = "Tên Khách Hàng";
            // 
            // btnDatLich
            // 
            this.btnDatLich.AutoRoundedCorners = true;
            this.btnDatLich.BorderRadius = 21;
            this.btnDatLich.FillColor = System.Drawing.Color.Orange;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(1125, 47);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(168, 45);
            this.btnDatLich.TabIndex = 117;
            this.btnDatLich.Text = "Đặt lịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 123;
            this.label5.Text = "Giá Tiền ";
            // 
            // bangDatLich
            // 
            this.bangDatLich.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangDatLich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bangDatLich.ColumnHeadersHeight = 29;
            this.bangDatLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALT,
            this.TENLT,
            this.THOIGIANDT,
            this.MANV,
            this.GIATIEN,
            this.Thoigian,
            this.THOIGIANKT});
            this.bangDatLich.Location = new System.Drawing.Point(2, 295);
            this.bangDatLich.Name = "bangDatLich";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bangDatLich.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bangDatLich.RowHeadersWidth = 51;
            this.bangDatLich.RowTemplate.Height = 24;
            this.bangDatLich.Size = new System.Drawing.Size(1291, 266);
            this.bangDatLich.TabIndex = 116;
            // 
            // MALT
            // 
            this.MALT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALT.DataPropertyName = "MALICHHEN";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.MALT.DefaultCellStyle = dataGridViewCellStyle2;
            this.MALT.HeaderText = "Mã Đơn Hàng";
            this.MALT.MinimumWidth = 6;
            this.MALT.Name = "MALT";
            // 
            // TENLT
            // 
            this.TENLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLT.DataPropertyName = "MAKH";
            this.TENLT.HeaderText = "Tên Hàng Hóa";
            this.TENLT.MinimumWidth = 6;
            this.TENLT.Name = "TENLT";
            // 
            // THOIGIANDT
            // 
            this.THOIGIANDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANDT.DataPropertyName = "MALT";
            this.THOIGIANDT.HeaderText = "Mã Khách Hàng";
            this.THOIGIANDT.MinimumWidth = 6;
            this.THOIGIANDT.Name = "THOIGIANDT";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Tên Khách Hàng";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // GIATIEN
            // 
            this.GIATIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATIEN.DataPropertyName = "TRANGTHAI";
            this.GIATIEN.HeaderText = "NV Phụ Trách";
            this.GIATIEN.MinimumWidth = 6;
            this.GIATIEN.Name = "GIATIEN";
            // 
            // Thoigian
            // 
            this.Thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thoigian.DataPropertyName = "THOIGIANBD";
            this.Thoigian.HeaderText = "Thời gian đặt hàng";
            this.Thoigian.MinimumWidth = 6;
            this.Thoigian.Name = "Thoigian";
            // 
            // THOIGIANKT
            // 
            this.THOIGIANKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANKT.DataPropertyName = "THOIGIANKT";
            this.THOIGIANKT.HeaderText = "Thời gian giao hàng";
            this.THOIGIANKT.MinimumWidth = 6;
            this.THOIGIANKT.Name = "THOIGIANKT";
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1304, 576);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_layma);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbxNhanVien);
            this.Controls.Add(this.lb_nv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateKT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateBD);
            this.Controls.Add(this.txtMaDH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.cbxTenHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTenKH);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bangDatLich);
            this.Name = "frmDonHang";
            this.Text = "formDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.bangDatLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_layma;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label lb_nv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateKT;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cbxTenHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenKH;
        private System.Windows.Forms.Label lb_tenkh;
        private Guna.UI2.WinForms.Guna2Button btnDatLich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView bangDatLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKT;
    }
}