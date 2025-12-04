namespace Nhom03
{
    partial class FormQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMatKhau));
            this.ptrThoat = new System.Windows.Forms.PictureBox();
            this.lbNAN = new System.Windows.Forms.Label();
            this.panelPhai = new System.Windows.Forms.Panel();
            this.panelTrai = new System.Windows.Forms.Panel();
            this.panelTrungTam = new System.Windows.Forms.Panel();
            this.grbDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhapLaiMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbXacNhanTaiKhoan = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).BeginInit();
            this.panelPhai.SuspendLayout();
            this.panelTrai.SuspendLayout();
            this.panelTrungTam.SuspendLayout();
            this.grbDoiMatKhau.SuspendLayout();
            this.grbXacNhanTaiKhoan.SuspendLayout();
            this.SuspendLayout();
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
            this.panelPhai.TabIndex = 4;
            // 
            // panelTrai
            // 
            this.panelTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.panelTrai.Controls.Add(this.lbNAN);
            this.panelTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrai.Location = new System.Drawing.Point(0, 0);
            this.panelTrai.Name = "panelTrai";
            this.panelTrai.Size = new System.Drawing.Size(104, 500);
            this.panelTrai.TabIndex = 3;
            // 
            // panelTrungTam
            // 
            this.panelTrungTam.Controls.Add(this.grbDoiMatKhau);
            this.panelTrungTam.Controls.Add(this.grbXacNhanTaiKhoan);
            this.panelTrungTam.Controls.Add(this.lbDangNhap);
            this.panelTrungTam.Controls.Add(this.lbCauHoi);
            this.panelTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrungTam.Location = new System.Drawing.Point(104, 51);
            this.panelTrungTam.Name = "panelTrungTam";
            this.panelTrungTam.Size = new System.Drawing.Size(696, 449);
            this.panelTrungTam.TabIndex = 5;
            // 
            // grbDoiMatKhau
            // 
            this.grbDoiMatKhau.Controls.Add(this.btnGui);
            this.grbDoiMatKhau.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.grbDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.grbDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.grbDoiMatKhau.Location = new System.Drawing.Point(355, 79);
            this.grbDoiMatKhau.Name = "grbDoiMatKhau";
            this.grbDoiMatKhau.Size = new System.Drawing.Size(300, 253);
            this.grbDoiMatKhau.TabIndex = 18;
            this.grbDoiMatKhau.TabStop = false;
            this.grbDoiMatKhau.Text = "Đổi mật khẩu";
            this.grbDoiMatKhau.Visible = false;
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 20;
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnGui.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(8, 186);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(283, 40);
            this.btnGui.TabIndex = 17;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtNhapLaiMatKhauMoi.BorderRadius = 20;
            this.txtNhapLaiMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMatKhauMoi.DefaultText = "";
            this.txtNhapLaiMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtNhapLaiMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(8, 88);
            this.txtNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '\0';
            this.txtNhapLaiMatKhauMoi.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNhapLaiMatKhauMoi.SelectedText = "";
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(283, 40);
            this.txtNhapLaiMatKhauMoi.TabIndex = 2;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMatKhauMoi.BorderRadius = 20;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(8, 38);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '\0';
            this.txtMatKhauMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(283, 40);
            this.txtMatKhauMoi.TabIndex = 1;
            // 
            // grbXacNhanTaiKhoan
            // 
            this.grbXacNhanTaiKhoan.Controls.Add(this.btnXacNhan);
            this.grbXacNhanTaiKhoan.Controls.Add(this.txtEmail);
            this.grbXacNhanTaiKhoan.Controls.Add(this.txtMaNhanVien);
            this.grbXacNhanTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.grbXacNhanTaiKhoan.Location = new System.Drawing.Point(28, 79);
            this.grbXacNhanTaiKhoan.Name = "grbXacNhanTaiKhoan";
            this.grbXacNhanTaiKhoan.Size = new System.Drawing.Size(300, 253);
            this.grbXacNhanTaiKhoan.TabIndex = 17;
            this.grbXacNhanTaiKhoan.TabStop = false;
            this.grbXacNhanTaiKhoan.Text = "Xác nhận tài khoản";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 20;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(8, 186);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(283, 40);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(8, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(283, 40);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMaNhanVien.BorderRadius = 20;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(8, 38);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.PlaceholderText = "Mã NV";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(283, 40);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangNhap.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbDangNhap.Location = new System.Drawing.Point(364, 404);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(120, 22);
            this.lbDangNhap.TabIndex = 12;
            this.lbDangNhap.Text = "Đăng nhập";
            this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbCauHoi.Location = new System.Drawing.Point(160, 404);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(198, 22);
            this.lbCauHoi.TabIndex = 13;
            this.lbCauHoi.Text = "Bạn đã có tài khoản?";
            // 
            // FormQuenMatKhau
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
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).EndInit();
            this.panelPhai.ResumeLayout(false);
            this.panelTrai.ResumeLayout(false);
            this.panelTrai.PerformLayout();
            this.panelTrungTam.ResumeLayout(false);
            this.panelTrungTam.PerformLayout();
            this.grbDoiMatKhau.ResumeLayout(false);
            this.grbXacNhanTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrThoat;
        private System.Windows.Forms.Label lbNAN;
        private System.Windows.Forms.Panel panelPhai;
        private System.Windows.Forms.Panel panelTrai;
        private System.Windows.Forms.Panel panelTrungTam;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.GroupBox grbDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private System.Windows.Forms.GroupBox grbXacNhanTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMatKhauMoi;
    }
}