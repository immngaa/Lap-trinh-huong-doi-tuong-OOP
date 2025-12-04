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
            this.lbDoiMatKhau = new System.Windows.Forms.Label();
            this.btnGuiYeuCau = new Guna.UI2.WinForms.Guna2Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).BeginInit();
            this.panelPhai.SuspendLayout();
            this.panelTrai.SuspendLayout();
            this.panelTrungTam.SuspendLayout();
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
            this.panelTrungTam.Controls.Add(this.lbDoiMatKhau);
            this.panelTrungTam.Controls.Add(this.btnGuiYeuCau);
            this.panelTrungTam.Controls.Add(this.lbDangNhap);
            this.panelTrungTam.Controls.Add(this.lbCauHoi);
            this.panelTrungTam.Controls.Add(this.txtNhapLaiMatKhau);
            this.panelTrungTam.Controls.Add(this.txtMatKhau);
            this.panelTrungTam.Controls.Add(this.txtEmail);
            this.panelTrungTam.Controls.Add(this.txtTenDangNhap);
            this.panelTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrungTam.Location = new System.Drawing.Point(104, 51);
            this.panelTrungTam.Name = "panelTrungTam";
            this.panelTrungTam.Size = new System.Drawing.Size(696, 449);
            this.panelTrungTam.TabIndex = 5;
            // 
            // lbDoiMatKhau
            // 
            this.lbDoiMatKhau.AutoSize = true;
            this.lbDoiMatKhau.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbDoiMatKhau.Location = new System.Drawing.Point(252, 29);
            this.lbDoiMatKhau.Name = "lbDoiMatKhau";
            this.lbDoiMatKhau.Size = new System.Drawing.Size(191, 29);
            this.lbDoiMatKhau.TabIndex = 15;
            this.lbDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.BorderRadius = 20;
            this.btnGuiYeuCau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiYeuCau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiYeuCau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuiYeuCau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuiYeuCau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuiYeuCau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnGuiYeuCau.Location = new System.Drawing.Point(131, 296);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(435, 45);
            this.btnGuiYeuCau.TabIndex = 14;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangNhap.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.lbDangNhap.Location = new System.Drawing.Point(364, 389);
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
            this.lbCauHoi.Location = new System.Drawing.Point(160, 389);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(198, 22);
            this.lbCauHoi.TabIndex = 13;
            this.lbCauHoi.Text = "Bạn đã có tài khoản?";
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
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(131, 234);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtNhapLaiMatKhau.SelectedText = "";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(435, 40);
            this.txtNhapLaiMatKhau.TabIndex = 8;
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
            this.txtMatKhau.Location = new System.Drawing.Point(131, 184);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "Mật khẩu mới";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(435, 40);
            this.txtMatKhau.TabIndex = 9;
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
            this.txtEmail.Location = new System.Drawing.Point(131, 134);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(435, 40);
            this.txtEmail.TabIndex = 10;
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
            this.txtTenDangNhap.Location = new System.Drawing.Point(131, 84);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(435, 40);
            this.txtTenDangNhap.TabIndex = 11;
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
            this.Text = "FormQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.ptrThoat)).EndInit();
            this.panelPhai.ResumeLayout(false);
            this.panelTrai.ResumeLayout(false);
            this.panelTrai.PerformLayout();
            this.panelTrungTam.ResumeLayout(false);
            this.panelTrungTam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrThoat;
        private System.Windows.Forms.Label lbNAN;
        private System.Windows.Forms.Panel panelPhai;
        private System.Windows.Forms.Panel panelTrai;
        private System.Windows.Forms.Panel panelTrungTam;
        private System.Windows.Forms.Label lbDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnGuiYeuCau;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbCauHoi;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
    }
}