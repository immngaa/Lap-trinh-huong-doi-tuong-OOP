namespace Nhom03
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.panelTrai = new System.Windows.Forms.Panel();
            this.lbNAN = new System.Windows.Forms.Label();
            this.panelPhai = new System.Windows.Forms.Panel();
            this.ptrThoat = new System.Windows.Forms.PictureBox();
            this.panelTrungTam = new System.Windows.Forms.Panel();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.grbThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtViTri = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.chbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.txtNhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTrai.SuspendLayout();
            this.panelPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).BeginInit();
            this.panelTrungTam.SuspendLayout();
            this.grbThongTinCaNhan.SuspendLayout();
            this.grbThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrai
            // 
            this.panelTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.panelTrai.Controls.Add(this.lbNAN);
            this.panelTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrai.Location = new System.Drawing.Point(0, 0);
            this.panelTrai.Name = "panelTrai";
            this.panelTrai.Size = new System.Drawing.Size(104, 500);
            this.panelTrai.TabIndex = 0;
            // 
            // lbNAN
            // 
            this.lbNAN.AutoSize = true;
            this.lbNAN.Font = new System.Drawing.Font("Broadway", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNAN.ForeColor = System.Drawing.Color.White;
            this.lbNAN.Location = new System.Drawing.Point(-11, 0);
            this.lbNAN.Name = "lbNAN";
            this.lbNAN.Size = new System.Drawing.Size(156, 63);
            this.lbNAN.TabIndex = 2;
            this.lbNAN.Text = "NAN";
            // 
            // panelPhai
            // 
            this.panelPhai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.panelPhai.Controls.Add(this.ptrThoat);
            this.panelPhai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhai.Location = new System.Drawing.Point(104, 0);
            this.panelPhai.Name = "panelPhai";
            this.panelPhai.Size = new System.Drawing.Size(696, 51);
            this.panelPhai.TabIndex = 1;
            // 
            // ptrThoat
            // 
            this.ptrThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptrThoat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrThoat.Image = ((System.Drawing.Image)(resources.GetObject("ptrThoat.Image")));
            this.ptrThoat.Location = new System.Drawing.Point(666, 0);
            this.ptrThoat.Name = "ptrThoat";
            this.ptrThoat.Size = new System.Drawing.Size(30, 24);
            this.ptrThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrThoat.TabIndex = 1;
            this.ptrThoat.TabStop = false;
            this.ptrThoat.Click += new System.EventHandler(this.ptrThoat_Click);
            // 
            // panelTrungTam
            // 
            this.panelTrungTam.Controls.Add(this.grbThongTinDangNhap);
            this.panelTrungTam.Controls.Add(this.grbThongTinCaNhan);
            this.panelTrungTam.Controls.Add(this.btnDangKy);
            this.panelTrungTam.Controls.Add(this.lbDangNhap);
            this.panelTrungTam.Controls.Add(this.lbCauHoi);
            this.panelTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrungTam.Location = new System.Drawing.Point(104, 51);
            this.panelTrungTam.Name = "panelTrungTam";
            this.panelTrungTam.Size = new System.Drawing.Size(696, 449);
            this.panelTrungTam.TabIndex = 2;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnDangKy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(347, 283);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(299, 45);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangNhap.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbDangNhap.Location = new System.Drawing.Point(354, 409);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(120, 22);
            this.lbDangNhap.TabIndex = 9;
            this.lbDangNhap.Text = "Đăng nhập";
            this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbCauHoi.Location = new System.Drawing.Point(150, 409);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(198, 22);
            this.lbCauHoi.TabIndex = 10;
            this.lbCauHoi.Text = "Bạn đã có tài khoản?";
            // 
            // grbThongTinCaNhan
            // 
            this.grbThongTinCaNhan.Controls.Add(this.dtpNgayBatDau);
            this.grbThongTinCaNhan.Controls.Add(this.txtTinhTrang);
            this.grbThongTinCaNhan.Controls.Add(this.txtViTri);
            this.grbThongTinCaNhan.Controls.Add(this.txtSDT);
            this.grbThongTinCaNhan.Controls.Add(this.txtEmail);
            this.grbThongTinCaNhan.Controls.Add(this.txtMaNV);
            this.grbThongTinCaNhan.Controls.Add(this.txtHoTen);
            this.grbThongTinCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.grbThongTinCaNhan.Location = new System.Drawing.Point(30, 15);
            this.grbThongTinCaNhan.Name = "grbThongTinCaNhan";
            this.grbThongTinCaNhan.Size = new System.Drawing.Size(300, 386);
            this.grbThongTinCaNhan.TabIndex = 14;
            this.grbThongTinCaNhan.TabStop = false;
            this.grbThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.dtpNgayBatDau.BorderRadius = 20;
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(9, 344);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(283, 40);
            this.dtpNgayBatDau.TabIndex = 14;
            this.dtpNgayBatDau.Value = new System.DateTime(2024, 12, 29, 8, 39, 9, 480);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtTinhTrang.BorderRadius = 20;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.DefaultText = "";
            this.txtTinhTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtTinhTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.Location = new System.Drawing.Point(9, 288);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PasswordChar = '\0';
            this.txtTinhTrang.PlaceholderText = "Tình trạng";
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(283, 40);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // txtViTri
            // 
            this.txtViTri.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtViTri.BorderRadius = 20;
            this.txtViTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViTri.DefaultText = "";
            this.txtViTri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtViTri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtViTri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtViTri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtViTri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtViTri.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtViTri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtViTri.Location = new System.Drawing.Point(8, 238);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.PasswordChar = '\0';
            this.txtViTri.PlaceholderText = "Vị trí";
            this.txtViTri.SelectedText = "";
            this.txtViTri.Size = new System.Drawing.Size(283, 40);
            this.txtViTri.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtSDT.BorderRadius = 20;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(8, 188);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(283, 40);
            this.txtSDT.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtEmail.BorderRadius = 20;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(8, 138);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(283, 40);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMaNV.BorderRadius = 20;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(8, 88);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "Mã NV";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(283, 40);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtHoTen.BorderRadius = 20;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(8, 38);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "Họ tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(283, 40);
            this.txtHoTen.TabIndex = 1;
            // 
            // grbThongTinDangNhap
            // 
            this.grbThongTinDangNhap.Controls.Add(this.chbHienMatKhau);
            this.grbThongTinDangNhap.Controls.Add(this.txtNhapLaiMatKhau);
            this.grbThongTinDangNhap.Controls.Add(this.txtMatKhau);
            this.grbThongTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.grbThongTinDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.grbThongTinDangNhap.Location = new System.Drawing.Point(347, 15);
            this.grbThongTinDangNhap.Name = "grbThongTinDangNhap";
            this.grbThongTinDangNhap.Size = new System.Drawing.Size(299, 240);
            this.grbThongTinDangNhap.TabIndex = 15;
            this.grbThongTinDangNhap.TabStop = false;
            this.grbThongTinDangNhap.Text = "Thông tin đăng nhập";
            // 
            // chbHienMatKhau
            // 
            this.chbHienMatKhau.AutoSize = true;
            this.chbHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbHienMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.chbHienMatKhau.Location = new System.Drawing.Point(106, 188);
            this.chbHienMatKhau.Name = "chbHienMatKhau";
            this.chbHienMatKhau.Size = new System.Drawing.Size(187, 29);
            this.chbHienMatKhau.TabIndex = 4;
            this.chbHienMatKhau.Text = "Hiện mật khẩu";
            this.chbHienMatKhau.UseVisualStyleBackColor = true;
            this.chbHienMatKhau.CheckedChanged += new System.EventHandler(this.chbHienMatKhau_CheckedChanged);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtNhapLaiMatKhau.BorderRadius = 20;
            this.txtNhapLaiMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMatKhau.DefaultText = "";
            this.txtNhapLaiMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtNhapLaiMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(8, 138);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.PlaceholderText = "Nhập lại mật khẩu";
            this.txtNhapLaiMatKhau.SelectedText = "";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(283, 40);
            this.txtNhapLaiMatKhau.TabIndex = 3;
            this.txtNhapLaiMatKhau.TextChanged += new System.EventHandler(this.txtNhapLaiMatKhau_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMatKhau.BorderRadius = 20;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(8, 88);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(283, 40);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtTenDangNhap.BorderRadius = 20;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(8, 38);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(283, 40);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelTrungTam);
            this.Controls.Add(this.panelPhai);
            this.Controls.Add(this.panelTrai);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKy";
            this.panelTrai.ResumeLayout(false);
            this.panelTrai.PerformLayout();
            this.panelPhai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).EndInit();
            this.panelTrungTam.ResumeLayout(false);
            this.panelTrungTam.PerformLayout();
            this.grbThongTinCaNhan.ResumeLayout(false);
            this.grbThongTinDangNhap.ResumeLayout(false);
            this.grbThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrai;
        private System.Windows.Forms.Panel panelPhai;
        private System.Windows.Forms.Label lbNAN;
        private System.Windows.Forms.Panel panelTrungTam;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.PictureBox ptrThoat;
        private System.Windows.Forms.GroupBox grbThongTinDangNhap;
        private System.Windows.Forms.CheckBox chbHienMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private System.Windows.Forms.GroupBox grbThongTinCaNhan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhTrang;
        private Guna.UI2.WinForms.Guna2TextBox txtViTri;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
    }
}