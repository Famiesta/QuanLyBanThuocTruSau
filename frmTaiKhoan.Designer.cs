namespace PMQuanLyBanHang_thuoctrusau_
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboVaiTro = new System.Windows.Forms.ComboBox();
            this.comboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.dgvTTTK = new System.Windows.Forms.DataGridView();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.btnThemTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThayDoiTrangThai = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboVaiTro
            // 
            this.comboVaiTro.FormattingEnabled = true;
            this.comboVaiTro.Items.AddRange(new object[] {
            "Quản Trị",
            "Nhân Viên"});
            this.comboVaiTro.Location = new System.Drawing.Point(152, 183);
            this.comboVaiTro.Name = "comboVaiTro";
            this.comboVaiTro.Size = new System.Drawing.Size(220, 28);
            this.comboVaiTro.TabIndex = 24;
            // 
            // comboTaiKhoan
            // 
            this.comboTaiKhoan.FormattingEnabled = true;
            this.comboTaiKhoan.Location = new System.Drawing.Point(152, 44);
            this.comboTaiKhoan.Name = "comboTaiKhoan";
            this.comboTaiKhoan.Size = new System.Drawing.Size(220, 28);
            this.comboTaiKhoan.TabIndex = 23;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.Location = new System.Drawing.Point(7, 183);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(60, 23);
            this.lblVaiTro.TabIndex = 10;
            this.lblVaiTro.Text = "Vai trò";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AcceptsReturn = true;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(152, 91);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(220, 33);
            this.txtMatKhau.TabIndex = 8;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(9, 97);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(82, 23);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // dgvTTTK
            // 
            this.dgvTTTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.Column1,
            this.QUYEN,
            this.TrangThaiTK});
            this.dgvTTTK.Location = new System.Drawing.Point(478, 78);
            this.dgvTTTK.Name = "dgvTTTK";
            this.dgvTTTK.RowHeadersWidth = 51;
            this.dgvTTTK.RowTemplate.Height = 24;
            this.dgvTTTK.Size = new System.Drawing.Size(722, 483);
            this.dgvTTTK.TabIndex = 10;
            this.dgvTTTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTTK_CellClick);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(7, 47);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(82, 23);
            this.lblTaiKhoan.TabIndex = 6;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.AutoRoundedCorners = true;
            this.btnThemTaiKhoan.BorderRadius = 35;
            this.btnThemTaiKhoan.FillColor = System.Drawing.Color.OrangeRed;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(17, 384);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(163, 73);
            this.btnThemTaiKhoan.TabIndex = 3;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản";
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoRoundedCorners = true;
            this.btnHuy.BorderRadius = 33;
            this.btnHuy.FillColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(76, 475);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(233, 68);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Cấp lại mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboMaNhanVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboTrangThai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboVaiTro);
            this.groupBox1.Controls.Add(this.comboTaiKhoan);
            this.groupBox1.Controls.Add(this.lblVaiTro);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.lblMatKhau);
            this.groupBox1.Controls.Add(this.lblTaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // comboMaNhanVien
            // 
            this.comboMaNhanVien.FormattingEnabled = true;
            this.comboMaNhanVien.Items.AddRange(new object[] {
            "Quản Trị",
            "Nhân Viên"});
            this.comboMaNhanVien.Location = new System.Drawing.Point(152, 137);
            this.comboMaNhanVien.Name = "comboMaNhanVien";
            this.comboMaNhanVien.Size = new System.Drawing.Size(220, 28);
            this.comboMaNhanVien.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên nhân viên";
            // 
            // comboTrangThai
            // 
            this.comboTrangThai.FormattingEnabled = true;
            this.comboTrangThai.Items.AddRange(new object[] {
            "Quản Trị",
            "Nhân Viên"});
            this.comboTrangThai.Location = new System.Drawing.Point(152, 230);
            this.comboTrangThai.Name = "comboTrangThai";
            this.comboTrangThai.Size = new System.Drawing.Size(220, 28);
            this.comboTrangThai.TabIndex = 26;
            this.comboTrangThai.SelectedIndexChanged += new System.EventHandler(this.comboTrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 51);
            this.label1.TabIndex = 25;
            this.label1.Text = "Trạng thái tài khoản";
            // 
            // btnThayDoiTrangThai
            // 
            this.btnThayDoiTrangThai.AutoRoundedCorners = true;
            this.btnThayDoiTrangThai.BorderRadius = 35;
            this.btnThayDoiTrangThai.FillColor = System.Drawing.Color.OrangeRed;
            this.btnThayDoiTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoiTrangThai.ForeColor = System.Drawing.Color.White;
            this.btnThayDoiTrangThai.Location = new System.Drawing.Point(212, 384);
            this.btnThayDoiTrangThai.Name = "btnThayDoiTrangThai";
            this.btnThayDoiTrangThai.Size = new System.Drawing.Size(162, 73);
            this.btnThayDoiTrangThai.TabIndex = 4;
            this.btnThayDoiTrangThai.Text = "Thay đổi trạng thái";
            this.btnThayDoiTrangThai.Click += new System.EventHandler(this.btnThayDoiTrangThai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnThemTaiKhoan);
            this.panel1.Controls.Add(this.btnThayDoiTrangThai);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(23, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 562);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(122, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(729, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 38);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thông Tin Tài Khoản";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenDangNhap.DataPropertyName = "TAIKHOAN";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.TenDangNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenDangNhap.HeaderText = "Tài Khoản";
            this.TenDangNhap.MaxInputLength = 10;
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 113;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // QUYEN
            // 
            this.QUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Vai trò";
            this.QUYEN.MaxInputLength = 20;
            this.QUYEN.MinimumWidth = 6;
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.Width = 63;
            // 
            // TrangThaiTK
            // 
            this.TrangThaiTK.HeaderText = "Trạng thái tài khoản";
            this.TrangThaiTK.MinimumWidth = 6;
            this.TrangThaiTK.Name = "TrangThaiTK";
            this.TrangThaiTK.Width = 125;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1212, 666);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTTTK);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboVaiTro;
        private System.Windows.Forms.ComboBox comboTaiKhoan;
        private System.Windows.Forms.Label lblVaiTro;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.DataGridView dgvTTTK;
        private System.Windows.Forms.Label lblTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnThemTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnThayDoiTrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiTK;
    }
}