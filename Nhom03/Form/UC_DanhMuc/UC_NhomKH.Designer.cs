namespace Nhom03
{
    partial class UC_NhomKH
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
			this.panelTimKiem = new System.Windows.Forms.Panel();
			this.btnSua = new Guna.UI2.WinForms.Guna2Button();
			this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnXem = new Guna.UI2.WinForms.Guna2Button();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.dtgrvNhomKH = new System.Windows.Forms.DataGridView();
			this.grbNhomKH = new System.Windows.Forms.GroupBox();
			this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
			this.cbbTenNKH = new System.Windows.Forms.ComboBox();
			this.cbbMaNKH = new System.Windows.Forms.ComboBox();
			this.lbMoTa = new System.Windows.Forms.Label();
			this.lbTenNhomKH = new System.Windows.Forms.Label();
			this.lbMaNhomKH = new System.Windows.Forms.Label();
			this.panelTimKiem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvNhomKH)).BeginInit();
			this.grbNhomKH.SuspendLayout();
			this.SuspendLayout();
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
			this.panelTimKiem.Location = new System.Drawing.Point(0, 346);
			this.panelTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTimKiem.Name = "panelTimKiem";
			this.panelTimKiem.Size = new System.Drawing.Size(1221, 101);
			this.panelTimKiem.TabIndex = 113;
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
			this.label1.Size = new System.Drawing.Size(205, 32);
			this.label1.TabIndex = 71;
			this.label1.Text = "Nhập mã NKH";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimKiem.Location = new System.Drawing.Point(225, 31);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(271, 40);
			this.txtTimKiem.TabIndex = 64;
			// 
			// dtgrvNhomKH
			// 
			this.dtgrvNhomKH.BackgroundColor = System.Drawing.Color.White;
			this.dtgrvNhomKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrvNhomKH.Location = new System.Drawing.Point(0, 454);
			this.dtgrvNhomKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtgrvNhomKH.Name = "dtgrvNhomKH";
			this.dtgrvNhomKH.RowHeadersWidth = 62;
			this.dtgrvNhomKH.RowTemplate.Height = 28;
			this.dtgrvNhomKH.Size = new System.Drawing.Size(1220, 284);
			this.dtgrvNhomKH.TabIndex = 112;
			this.dtgrvNhomKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvNhomKH_CellClick);
			// 
			// grbNhomKH
			// 
			this.grbNhomKH.Controls.Add(this.rtxtMoTa);
			this.grbNhomKH.Controls.Add(this.cbbTenNKH);
			this.grbNhomKH.Controls.Add(this.cbbMaNKH);
			this.grbNhomKH.Controls.Add(this.lbMoTa);
			this.grbNhomKH.Controls.Add(this.lbTenNhomKH);
			this.grbNhomKH.Controls.Add(this.lbMaNhomKH);
			this.grbNhomKH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbNhomKH.Location = new System.Drawing.Point(0, 2);
			this.grbNhomKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbNhomKH.Name = "grbNhomKH";
			this.grbNhomKH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbNhomKH.Size = new System.Drawing.Size(1221, 339);
			this.grbNhomKH.TabIndex = 111;
			this.grbNhomKH.TabStop = false;
			this.grbNhomKH.Text = "Nhóm khách hàng";
			// 
			// rtxtMoTa
			// 
			this.rtxtMoTa.Location = new System.Drawing.Point(819, 71);
			this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rtxtMoTa.Name = "rtxtMoTa";
			this.rtxtMoTa.Size = new System.Drawing.Size(367, 232);
			this.rtxtMoTa.TabIndex = 5;
			this.rtxtMoTa.Text = "";
			// 
			// cbbTenNKH
			// 
			this.cbbTenNKH.FormattingEnabled = true;
			this.cbbTenNKH.Items.AddRange(new object[] {
            "Khách hàng thân thiết",
            "Khách hàng tiềm năng"});
			this.cbbTenNKH.Location = new System.Drawing.Point(227, 144);
			this.cbbTenNKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbbTenNKH.Name = "cbbTenNKH";
			this.cbbTenNKH.Size = new System.Drawing.Size(445, 46);
			this.cbbTenNKH.TabIndex = 4;
			// 
			// cbbMaNKH
			// 
			this.cbbMaNKH.FormattingEnabled = true;
			this.cbbMaNKH.Items.AddRange(new object[] {
            "NKH01",
            "NKH02"});
			this.cbbMaNKH.Location = new System.Drawing.Point(227, 71);
			this.cbbMaNKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbbMaNKH.Name = "cbbMaNKH";
			this.cbbMaNKH.Size = new System.Drawing.Size(445, 46);
			this.cbbMaNKH.TabIndex = 3;
			// 
			// lbMoTa
			// 
			this.lbMoTa.AutoSize = true;
			this.lbMoTa.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMoTa.Location = new System.Drawing.Point(696, 71);
			this.lbMoTa.Name = "lbMoTa";
			this.lbMoTa.Size = new System.Drawing.Size(90, 32);
			this.lbMoTa.TabIndex = 2;
			this.lbMoTa.Text = "Mô tả";
			// 
			// lbTenNhomKH
			// 
			this.lbTenNhomKH.AutoSize = true;
			this.lbTenNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTenNhomKH.Location = new System.Drawing.Point(15, 151);
			this.lbTenNhomKH.Name = "lbTenNhomKH";
			this.lbTenNhomKH.Size = new System.Drawing.Size(199, 32);
			this.lbTenNhomKH.TabIndex = 1;
			this.lbTenNhomKH.Text = "Tên nhóm KH";
			// 
			// lbMaNhomKH
			// 
			this.lbMaNhomKH.AutoSize = true;
			this.lbMaNhomKH.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNhomKH.Location = new System.Drawing.Point(15, 79);
			this.lbMaNhomKH.Name = "lbMaNhomKH";
			this.lbMaNhomKH.Size = new System.Drawing.Size(188, 32);
			this.lbMaNhomKH.TabIndex = 0;
			this.lbMaNhomKH.Text = "Mã nhóm KH";
			// 
			// UC_NhomKH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelTimKiem);
			this.Controls.Add(this.dtgrvNhomKH);
			this.Controls.Add(this.grbNhomKH);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UC_NhomKH";
			this.Size = new System.Drawing.Size(1273, 771);
			this.panelTimKiem.ResumeLayout(false);
			this.panelTimKiem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrvNhomKH)).EndInit();
			this.grbNhomKH.ResumeLayout(false);
			this.grbNhomKH.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dtgrvNhomKH;
        private System.Windows.Forms.GroupBox grbNhomKH;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.ComboBox cbbMaNKH;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbTenNhomKH;
        private System.Windows.Forms.Label lbMaNhomKH;
        private System.Windows.Forms.ComboBox cbbTenNKH;
    }
}
