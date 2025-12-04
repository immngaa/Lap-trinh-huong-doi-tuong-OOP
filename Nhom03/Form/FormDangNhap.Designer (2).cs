namespace Nhom03
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panelTrai = new System.Windows.Forms.Panel();
            this.lbNAN = new System.Windows.Forms.Label();
            this.panelTren = new System.Windows.Forms.Panel();
            this.ptrThoat = new System.Windows.Forms.PictureBox();
            this.panelTrungTam = new System.Windows.Forms.Panel();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.chbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            this.lbDangKy = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.panelTrai.SuspendLayout();
            this.panelTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).BeginInit();
            this.panelTrungTam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrai
            // 
            this.panelTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.panelTrai.Controls.Add(this.lbNAN);
            this.panelTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrai.Location = new System.Drawing.Point(0, 0);
            this.panelTrai.Name = "panelTrai";
            this.panelTrai.Size = new System.Drawing.Size(104, 452);
            this.panelTrai.TabIndex = 0;
            // 
            // lbNAN
            // 
            this.lbNAN.AutoSize = true;
            this.lbNAN.Font = new System.Drawing.Font("Broadway", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNAN.ForeColor = System.Drawing.Color.White;
            this.lbNAN.Location = new System.Drawing.Point(3, 0);
            this.lbNAN.Name = "lbNAN";
            this.lbNAN.Size = new System.Drawing.Size(156, 63);
            this.lbNAN.TabIndex = 1;
            this.lbNAN.Text = "NAN";
            // 
            // panelTren
            // 
            this.panelTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.panelTren.Controls.Add(this.ptrThoat);
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(104, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(630, 51);
            this.panelTren.TabIndex = 1;
            // 
            // ptrThoat
            // 
            this.ptrThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptrThoat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrThoat.Image = ((System.Drawing.Image)(resources.GetObject("ptrThoat.Image")));
            this.ptrThoat.Location = new System.Drawing.Point(600, 0);
            this.ptrThoat.Name = "ptrThoat";
            this.ptrThoat.Size = new System.Drawing.Size(30, 24);
            this.ptrThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrThoat.TabIndex = 1;
            this.ptrThoat.TabStop = false;
            this.ptrThoat.Click += new System.EventHandler(this.ptrThoat_Click);
            // 
            // panelTrungTam
            // 
            this.panelTrungTam.Controls.Add(this.btnDangNhap);
            this.panelTrungTam.Controls.Add(this.chbHienMatKhau);
            this.panelTrungTam.Controls.Add(this.lbQuenMatKhau);
            this.panelTrungTam.Controls.Add(this.lbDangKy);
            this.panelTrungTam.Controls.Add(this.lbCauHoi);
            this.panelTrungTam.Controls.Add(this.txtMatKhau);
            this.panelTrungTam.Controls.Add(this.txtTenDangNhap);
            this.panelTrungTam.Controls.Add(this.ptrLogo);
            this.panelTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrungTam.Location = new System.Drawing.Point(104, 51);
            this.panelTrungTam.MinimumSize = new System.Drawing.Size(630, 401);
            this.panelTrungTam.Name = "panelTrungTam";
            this.panelTrungTam.Size = new System.Drawing.Size(630, 401);
            this.panelTrungTam.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(150, 290);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(328, 45);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chbHienMatKhau
            // 
            this.chbHienMatKhau.AutoSize = true;
            this.chbHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbHienMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.chbHienMatKhau.Location = new System.Drawing.Point(316, 255);
            this.chbHienMatKhau.Name = "chbHienMatKhau";
            this.chbHienMatKhau.Size = new System.Drawing.Size(187, 29);
            this.chbHienMatKhau.TabIndex = 8;
            this.chbHienMatKhau.Text = "Hiện mật khẩu";
            this.chbHienMatKhau.UseVisualStyleBackColor = true;
            this.chbHienMatKhau.CheckedChanged += new System.EventHandler(this.chbHienMatKhau_CheckedChanged);
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbQuenMatKhau.Location = new System.Drawing.Point(146, 259);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(164, 22);
            this.lbQuenMatKhau.TabIndex = 6;
            this.lbQuenMatKhau.Text = "Quên mật khẩu";
            this.lbQuenMatKhau.Click += new System.EventHandler(this.lbQuenMatKhau_Click);
            // 
            // lbDangKy
            // 
            this.lbDangKy.AutoSize = true;
            this.lbDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangKy.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbDangKy.Location = new System.Drawing.Point(360, 370);
            this.lbDangKy.Name = "lbDangKy";
            this.lbDangKy.Size = new System.Drawing.Size(93, 22);
            this.lbDangKy.TabIndex = 6;
            this.lbDangKy.Text = "Đăng ký";
            this.lbDangKy.Click += new System.EventHandler(this.lbDangKy_Click);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbCauHoi.Location = new System.Drawing.Point(146, 370);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(218, 22);
            this.lbCauHoi.TabIndex = 7;
            this.lbCauHoi.Text = "Bạn chưa có tài khoản?";
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
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Location = new System.Drawing.Point(150, 200);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(328, 54);
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
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(150, 136);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(328, 54);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // ptrLogo
            // 
            this.ptrLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ptrLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptrLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptrLogo.Image")));
            this.ptrLogo.Location = new System.Drawing.Point(0, 0);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(630, 112);
            this.ptrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrLogo.TabIndex = 1;
            this.ptrLogo.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 452);
            this.Controls.Add(this.panelTrungTam);
            this.Controls.Add(this.panelTren);
            this.Controls.Add(this.panelTrai);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.panelTrai.ResumeLayout(false);
            this.panelTrai.PerformLayout();
            this.panelTren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).EndInit();
            this.panelTrungTam.ResumeLayout(false);
            this.panelTrungTam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrai;
        private System.Windows.Forms.Label lbNAN;
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.PictureBox ptrThoat;
        private System.Windows.Forms.Panel panelTrungTam;
        private System.Windows.Forms.PictureBox ptrLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private System.Windows.Forms.CheckBox chbHienMatKhau;
        private System.Windows.Forms.Label lbQuenMatKhau;
        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.Label lbCauHoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
    }
}