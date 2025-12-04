namespace Nhom03
{
    partial class UC_ThongTinSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
			this.lbCapDoThanhVien = new System.Windows.Forms.Label();
			this.lbDiemTichLuy = new System.Windows.Forms.Label();
			this.lbThuongHieu = new System.Windows.Forms.Label();
			this.lbPhanLoaiKH = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbbMaLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtThuongHieu = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
			this.panelTimKiem = new System.Windows.Forms.Panel();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnXem = new Guna.UI2.WinForms.Guna2Button();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.lnNhapMaSP = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.dtgrvThongTinSanPham = new System.Windows.Forms.DataGridView();
			this.groupBox2.SuspendLayout();
			this.panelTimKiem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rtxtMoTa);
			this.groupBox2.Controls.Add(this.lbCapDoThanhVien);
			this.groupBox2.Controls.Add(this.lbDiemTichLuy);
			this.groupBox2.Controls.Add(this.lbThuongHieu);
			this.groupBox2.Controls.Add(this.lbPhanLoaiKH);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtGia);
			this.groupBox2.Controls.Add(this.cbbMaLoaiSP);
			this.groupBox2.Controls.Add(this.txtThuongHieu);
			this.groupBox2.Controls.Add(this.txtTenSP);
			this.groupBox2.Controls.Add(this.txtMaSP);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 2);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(1220, 426);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin sản phẩm";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// rtxtMoTa
			// 
			this.rtxtMoTa.Location = new System.Drawing.Point(681, 165);
			this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rtxtMoTa.Name = "rtxtMoTa";
			this.rtxtMoTa.Size = new System.Drawing.Size(372, 224);
			this.rtxtMoTa.TabIndex = 61;
			this.rtxtMoTa.Text = "";
			// 
			// lbCapDoThanhVien
			// 
			this.lbCapDoThanhVien.AutoSize = true;
			this.lbCapDoThanhVien.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCapDoThanhVien.Location = new System.Drawing.Point(555, 165);
			this.lbCapDoThanhVien.Name = "lbCapDoThanhVien";
			this.lbCapDoThanhVien.Size = new System.Drawing.Size(90, 32);
			this.lbCapDoThanhVien.TabIndex = 60;
			this.lbCapDoThanhVien.Text = "Mô tả";
			// 
			// lbDiemTichLuy
			// 
			this.lbDiemTichLuy.AutoSize = true;
			this.lbDiemTichLuy.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiemTichLuy.Location = new System.Drawing.Point(555, 78);
			this.lbDiemTichLuy.Name = "lbDiemTichLuy";
			this.lbDiemTichLuy.Size = new System.Drawing.Size(58, 32);
			this.lbDiemTichLuy.TabIndex = 60;
			this.lbDiemTichLuy.Text = "Giá";
			// 
			// lbThuongHieu
			// 
			this.lbThuongHieu.AutoSize = true;
			this.lbThuongHieu.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThuongHieu.Location = new System.Drawing.Point(7, 342);
			this.lbThuongHieu.Name = "lbThuongHieu";
			this.lbThuongHieu.Size = new System.Drawing.Size(183, 32);
			this.lbThuongHieu.TabIndex = 60;
			this.lbThuongHieu.Text = "Thương hiệu";
			// 
			// lbPhanLoaiKH
			// 
			this.lbPhanLoaiKH.AutoSize = true;
			this.lbPhanLoaiKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPhanLoaiKH.Location = new System.Drawing.Point(7, 258);
			this.lbPhanLoaiKH.Name = "lbPhanLoaiKH";
			this.lbPhanLoaiKH.Size = new System.Drawing.Size(153, 32);
			this.lbPhanLoaiKH.TabIndex = 60;
			this.lbPhanLoaiKH.Text = "Mã loại SP";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 32);
			this.label3.TabIndex = 60;
			this.label3.Text = "Tên sản phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 32);
			this.label2.TabIndex = 59;
			this.label2.Text = "Mã sản phẩm";
			// 
			// txtGia
			// 
			this.txtGia.BackColor = System.Drawing.Color.Transparent;
			this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGia.DefaultText = "";
			this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGia.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGia.Location = new System.Drawing.Point(681, 78);
			this.txtGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtGia.Name = "txtGia";
			this.txtGia.PasswordChar = '\0';
			this.txtGia.PlaceholderText = "VNĐ";
			this.txtGia.SelectedText = "";
			this.txtGia.Size = new System.Drawing.Size(205, 38);
			this.txtGia.TabIndex = 58;
			// 
			// cbbMaLoaiSP
			// 
			this.cbbMaLoaiSP.BackColor = System.Drawing.Color.Transparent;
			this.cbbMaLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbMaLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbMaLoaiSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbbMaLoaiSP.ItemHeight = 30;
			this.cbbMaLoaiSP.Items.AddRange(new object[] {
            "L01",
            "L02",
            "L03",
            "L04",
            "L05",
            "L06",
            "L07",
            "L08",
            "L09",
            "L10",
            "L11",
            "L12"});
			this.cbbMaLoaiSP.Location = new System.Drawing.Point(241, 259);
			this.cbbMaLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbbMaLoaiSP.Name = "cbbMaLoaiSP";
			this.cbbMaLoaiSP.Size = new System.Drawing.Size(223, 36);
			this.cbbMaLoaiSP.TabIndex = 57;
			// 
			// txtThuongHieu
			// 
			this.txtThuongHieu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtThuongHieu.DefaultText = "";
			this.txtThuongHieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtThuongHieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtThuongHieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtThuongHieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtThuongHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtThuongHieu.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThuongHieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtThuongHieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtThuongHieu.Location = new System.Drawing.Point(241, 335);
			this.txtThuongHieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtThuongHieu.Name = "txtThuongHieu";
			this.txtThuongHieu.PasswordChar = '\0';
			this.txtThuongHieu.PlaceholderText = "";
			this.txtThuongHieu.SelectedText = "";
			this.txtThuongHieu.Size = new System.Drawing.Size(224, 45);
			this.txtThuongHieu.TabIndex = 51;
			// 
			// txtTenSP
			// 
			this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTenSP.DefaultText = "";
			this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTenSP.Location = new System.Drawing.Point(241, 165);
			this.txtTenSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.PasswordChar = '\0';
			this.txtTenSP.PlaceholderText = "";
			this.txtTenSP.SelectedText = "";
			this.txtTenSP.Size = new System.Drawing.Size(224, 45);
			this.txtTenSP.TabIndex = 51;
			// 
			// txtMaSP
			// 
			this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaSP.DefaultText = "";
			this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaSP.Location = new System.Drawing.Point(241, 100);
			this.txtMaSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.PasswordChar = '\0';
			this.txtMaSP.PlaceholderText = "";
			this.txtMaSP.SelectedText = "";
			this.txtMaSP.Size = new System.Drawing.Size(224, 45);
			this.txtMaSP.TabIndex = 48;
			// 
			// panelTimKiem
			// 
			this.panelTimKiem.BackColor = System.Drawing.Color.Transparent;
			this.panelTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTimKiem.Controls.Add(this.btnSua);
			this.panelTimKiem.Controls.Add(this.btnXoa);
			this.panelTimKiem.Controls.Add(this.btnThem);
			this.panelTimKiem.Controls.Add(this.btnXem);
			this.panelTimKiem.Controls.Add(this.btnTimKiem);
			this.panelTimKiem.Controls.Add(this.lnNhapMaSP);
			this.panelTimKiem.Controls.Add(this.txtTimKiem);
			this.panelTimKiem.Location = new System.Drawing.Point(3, 434);
			this.panelTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTimKiem.Name = "panelTimKiem";
			this.panelTimKiem.Size = new System.Drawing.Size(1221, 101);
			this.panelTimKiem.TabIndex = 114;
			// 
			// btnSua
			// 
			this.btnSua.BorderRadius = 20;
			this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnSua.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Location = new System.Drawing.Point(1072, 26);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(141, 49);
			this.btnSua.TabIndex = 73;
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BorderRadius = 20;
			this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnXoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(923, 26);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(141, 49);
			this.btnXoa.TabIndex = 73;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.BorderRadius = 20;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnThem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(769, 26);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(141, 49);
			this.btnThem.TabIndex = 73;
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXem
			// 
			this.btnXem.BorderRadius = 20;
			this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
			this.btnXem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXem.ForeColor = System.Drawing.Color.White;
			this.btnXem.Location = new System.Drawing.Point(620, 26);
			this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(141, 49);
			this.btnXem.TabIndex = 73;
			this.btnXem.Text = "Xem";
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
			this.btnTimKiem.BorderRadius = 20;
			this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTimKiem.FillColor = System.Drawing.SystemColors.Control;
			this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Image = global::Nhom03.Properties.Resources.TimKiem;
			this.btnTimKiem.ImageSize = new System.Drawing.Size(35, 35);
			this.btnTimKiem.Location = new System.Drawing.Point(523, 22);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(88, 56);
			this.btnTimKiem.TabIndex = 72;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// lnNhapMaSP
			// 
			this.lnNhapMaSP.AutoSize = true;
			this.lnNhapMaSP.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnNhapMaSP.Location = new System.Drawing.Point(5, 35);
			this.lnNhapMaSP.Name = "lnNhapMaSP";
			this.lnNhapMaSP.Size = new System.Drawing.Size(180, 32);
			this.lnNhapMaSP.TabIndex = 71;
			this.lnNhapMaSP.Text = "Nhập mã SP";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(217, 31);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(297, 40);
			this.txtTimKiem.TabIndex = 64;
			// 
			// dtgrvThongTinSanPham
			// 
			this.dtgrvThongTinSanPham.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvThongTinSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvThongTinSanPham.Location = new System.Drawing.Point(3, 541);
			this.dtgrvThongTinSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtgrvThongTinSanPham.Name = "dtgrvThongTinSanPham";
			this.dtgrvThongTinSanPham.RowHeadersWidth = 62;
			this.dtgrvThongTinSanPham.RowTemplate.Height = 28;
			this.dtgrvThongTinSanPham.Size = new System.Drawing.Size(1220, 284);
			this.dtgrvThongTinSanPham.TabIndex = 113;
			this.dtgrvThongTinSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvThongTinSanPham_CellClick);
			// 
			// UC_ThongTinSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelTimKiem);
			this.Controls.Add(this.dtgrvThongTinSanPham);
			this.Controls.Add(this.groupBox2);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UC_ThongTinSanPham";
			this.Size = new System.Drawing.Size(1231, 856);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panelTimKiem.ResumeLayout(false);
			this.panelTimKiem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvThongTinSanPham)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.Label lbCapDoThanhVien;
        private System.Windows.Forms.Label lbDiemTichLuy;
        private System.Windows.Forms.Label lbPhanLoaiKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaLoaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private System.Windows.Forms.Panel panelTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label lnNhapMaSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgrvThongTinSanPham;
        private System.Windows.Forms.Label lbThuongHieu;
        private Guna.UI2.WinForms.Guna2TextBox txtThuongHieu;
    }
}
