namespace Nhom03
{
    partial class UC_LoaiSanPham
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
			this.lblMoTa = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cbbTenPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbbMaLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lblMaPhanLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelTimKiem = new System.Windows.Forms.Panel();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnXem = new Guna.UI2.WinForms.Guna2Button();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.dtgrvLoaiSanPham = new System.Windows.Forms.DataGridView();
			this.groupBox2.SuspendLayout();
			this.panelTimKiem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvLoaiSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rtxtMoTa);
			this.groupBox2.Controls.Add(this.lblMoTa);
			this.groupBox2.Controls.Add(this.lblTen);
			this.groupBox2.Controls.Add(this.cbbTenPhanLoai);
			this.groupBox2.Controls.Add(this.cbbMaLoaiSP);
			this.groupBox2.Controls.Add(this.lblMaPhanLoai);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(4, 4);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(1216, 475);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Loại sản phẩm";
			// 
			// rtxtMoTa
			// 
			this.rtxtMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtMoTa.Location = new System.Drawing.Point(627, 120);
			this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rtxtMoTa.Name = "rtxtMoTa";
			this.rtxtMoTa.Size = new System.Drawing.Size(527, 260);
			this.rtxtMoTa.TabIndex = 76;
			this.rtxtMoTa.Text = "";
			// 
			// lblMoTa
			// 
			this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
			this.lblMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoTa.Location = new System.Drawing.Point(513, 120);
			this.lblMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lblMoTa.Name = "lblMoTa";
			this.lblMoTa.Size = new System.Drawing.Size(79, 34);
			this.lblMoTa.TabIndex = 75;
			this.lblMoTa.Text = "Mô tả";
			// 
			// lblTen
			// 
			this.lblTen.BackColor = System.Drawing.Color.Transparent;
			this.lblTen.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTen.Location = new System.Drawing.Point(24, 211);
			this.lblTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lblTen.Name = "lblTen";
			this.lblTen.Size = new System.Drawing.Size(186, 34);
			this.lblTen.TabIndex = 69;
			this.lblTen.Text = "Tên phân loại";
			// 
			// cbbTenPhanLoai
			// 
			this.cbbTenPhanLoai.BackColor = System.Drawing.Color.Transparent;
			this.cbbTenPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbTenPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTenPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbTenPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbTenPhanLoai.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbTenPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.cbbTenPhanLoai.ItemHeight = 30;
			this.cbbTenPhanLoai.Items.AddRange(new object[] {
            "Laptop",
            "Điện thoại di động",
            "Máy tính bảng",
            "Máy tính để bàn",
            "Linh kiện máy tính (RAM, CPU, GPU,...)",
            " Phụ kiện công nghệ (chuột, bàn phím, tai nghe,...)",
            "Thiết bị mạng (Router, Switch, Modem,...)",
            "Máy ảnh & Thiết bị quay phim",
            "Thiết bị lưu trữ (Ổ cứng, USB, SSD,...)",
            "Màn hình & Máy chiếu",
            "Đồng hồ thông minh (Smartwatch)",
            "Đồ gia dụng"});
			this.cbbTenPhanLoai.Location = new System.Drawing.Point(225, 211);
			this.cbbTenPhanLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbTenPhanLoai.Name = "cbbTenPhanLoai";
			this.cbbTenPhanLoai.Size = new System.Drawing.Size(265, 36);
			this.cbbTenPhanLoai.TabIndex = 72;
			// 
			// cbbMaLoaiSP
			// 
			this.cbbMaLoaiSP.BackColor = System.Drawing.Color.Transparent;
			this.cbbMaLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbMaLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaLoaiSP.Font = new System.Drawing.Font("Verdana", 10.125F);
			this.cbbMaLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
			this.cbbMaLoaiSP.Location = new System.Drawing.Point(225, 120);
			this.cbbMaLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbMaLoaiSP.Name = "cbbMaLoaiSP";
			this.cbbMaLoaiSP.Size = new System.Drawing.Size(265, 36);
			this.cbbMaLoaiSP.TabIndex = 71;
			// 
			// lblMaPhanLoai
			// 
			this.lblMaPhanLoai.BackColor = System.Drawing.Color.Transparent;
			this.lblMaPhanLoai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaPhanLoai.Location = new System.Drawing.Point(21, 120);
			this.lblMaPhanLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lblMaPhanLoai.Name = "lblMaPhanLoai";
			this.lblMaPhanLoai.Size = new System.Drawing.Size(142, 34);
			this.lblMaPhanLoai.TabIndex = 68;
			this.lblMaPhanLoai.Text = "Mã  loại SP\r\n\r\n";
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
			this.panelTimKiem.Controls.Add(this.label1);
			this.panelTimKiem.Controls.Add(this.txtTimKiem);
			this.panelTimKiem.Location = new System.Drawing.Point(3, 485);
			this.panelTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTimKiem.Name = "panelTimKiem";
			this.panelTimKiem.Size = new System.Drawing.Size(1221, 101);
			this.panelTimKiem.TabIndex = 112;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 32);
			this.label1.TabIndex = 71;
			this.label1.Text = "Nhập mã loại SP";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(259, 31);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(237, 40);
			this.txtTimKiem.TabIndex = 64;
			// 
			// dtgrvLoaiSanPham
			// 
			this.dtgrvLoaiSanPham.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvLoaiSanPham.Location = new System.Drawing.Point(3, 592);
			this.dtgrvLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtgrvLoaiSanPham.Name = "dtgrvLoaiSanPham";
			this.dtgrvLoaiSanPham.RowHeadersWidth = 62;
			this.dtgrvLoaiSanPham.RowTemplate.Height = 28;
			this.dtgrvLoaiSanPham.Size = new System.Drawing.Size(1220, 284);
			this.dtgrvLoaiSanPham.TabIndex = 111;
			this.dtgrvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvLoaiSanPham_CellClick);
			// 
			// UC_LoaiSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelTimKiem);
			this.Controls.Add(this.dtgrvLoaiSanPham);
			this.Controls.Add(this.groupBox2);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UC_LoaiSanPham";
			this.Size = new System.Drawing.Size(1264, 934);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panelTimKiem.ResumeLayout(false);
			this.panelTimKiem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvLoaiSanPham)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTen;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenPhanLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaLoaiSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaPhanLoai;
        private System.Windows.Forms.Panel panelTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgrvLoaiSanPham;
    }
}
