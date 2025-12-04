namespace Nhom03
{
    partial class UC_PhanHoiKhieuNai
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
            this.dtgrvPhanHoiKhieuNai = new System.Windows.Forms.DataGridView();
            this.grbPhanHoiKhieuNai = new System.Windows.Forms.GroupBox();
            this.dtpNgayKhieuNai = new System.Windows.Forms.DateTimePicker();
            this.btnPhanHoi = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaKhieuNai = new System.Windows.Forms.TextBox();
            this.rtxtPhanHoiKhieuNai = new System.Windows.Forms.RichTextBox();
            this.lbPhanHoiKhieuNai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxtNDKhieuNai = new System.Windows.Forms.RichTextBox();
            this.lbNDKhieuNai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbNgayTuVan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTinhTrang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbMaNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbMaKhieuNai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvPhanHoiKhieuNai)).BeginInit();
            this.grbPhanHoiKhieuNai.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvPhanHoiKhieuNai
            // 
            this.dtgrvPhanHoiKhieuNai.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvPhanHoiKhieuNai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvPhanHoiKhieuNai.Location = new System.Drawing.Point(0, 3);
            this.dtgrvPhanHoiKhieuNai.Name = "dtgrvPhanHoiKhieuNai";
            this.dtgrvPhanHoiKhieuNai.RowHeadersWidth = 62;
            this.dtgrvPhanHoiKhieuNai.RowTemplate.Height = 28;
            this.dtgrvPhanHoiKhieuNai.Size = new System.Drawing.Size(950, 256);
            this.dtgrvPhanHoiKhieuNai.TabIndex = 96;
            this.dtgrvPhanHoiKhieuNai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvPhanHoiKhieuNai_CellClick);
            // 
            // grbPhanHoiKhieuNai
            // 
            this.grbPhanHoiKhieuNai.Controls.Add(this.dtpNgayKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.btnPhanHoi);
            this.grbPhanHoiKhieuNai.Controls.Add(this.txtMaNhanVien);
            this.grbPhanHoiKhieuNai.Controls.Add(this.txtMaKH);
            this.grbPhanHoiKhieuNai.Controls.Add(this.txtMaKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.rtxtPhanHoiKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbPhanHoiKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.rtxtNDKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbNDKhieuNai);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbNgayTuVan);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbTinhTrang);
            this.grbPhanHoiKhieuNai.Controls.Add(this.cbbTinhTrang);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbMaNhanVien);
            this.grbPhanHoiKhieuNai.Controls.Add(this.guna2HtmlLabel2);
            this.grbPhanHoiKhieuNai.Controls.Add(this.lbMaKhieuNai);
            this.grbPhanHoiKhieuNai.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhanHoiKhieuNai.Location = new System.Drawing.Point(0, 265);
            this.grbPhanHoiKhieuNai.Name = "grbPhanHoiKhieuNai";
            this.grbPhanHoiKhieuNai.Size = new System.Drawing.Size(950, 422);
            this.grbPhanHoiKhieuNai.TabIndex = 97;
            this.grbPhanHoiKhieuNai.TabStop = false;
            this.grbPhanHoiKhieuNai.Text = "Phản hồi khiếu nại";
            // 
            // dtpNgayKhieuNai
            // 
            this.dtpNgayKhieuNai.Enabled = false;
            this.dtpNgayKhieuNai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhieuNai.Location = new System.Drawing.Point(179, 233);
            this.dtpNgayKhieuNai.Name = "dtpNgayKhieuNai";
            this.dtpNgayKhieuNai.Size = new System.Drawing.Size(242, 37);
            this.dtpNgayKhieuNai.TabIndex = 80;
            // 
            // btnPhanHoi
            // 
            this.btnPhanHoi.BackColor = System.Drawing.Color.Transparent;
            this.btnPhanHoi.BorderColor = System.Drawing.Color.Transparent;
            this.btnPhanHoi.BorderRadius = 20;
            this.btnPhanHoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanHoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanHoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanHoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanHoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(38)))), ((int)(((byte)(26)))));
            this.btnPhanHoi.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.btnPhanHoi.ForeColor = System.Drawing.Color.White;
            this.btnPhanHoi.Location = new System.Drawing.Point(361, 362);
            this.btnPhanHoi.Name = "btnPhanHoi";
            this.btnPhanHoi.Size = new System.Drawing.Size(163, 45);
            this.btnPhanHoi.TabIndex = 78;
            this.btnPhanHoi.Text = "Phản hồi";
            this.btnPhanHoi.Click += new System.EventHandler(this.btnPhanHoi_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(179, 169);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(242, 37);
            this.txtMaNhanVien.TabIndex = 77;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(179, 120);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(242, 37);
            this.txtMaKH.TabIndex = 77;
            // 
            // txtMaKhieuNai
            // 
            this.txtMaKhieuNai.Location = new System.Drawing.Point(179, 64);
            this.txtMaKhieuNai.Name = "txtMaKhieuNai";
            this.txtMaKhieuNai.ReadOnly = true;
            this.txtMaKhieuNai.Size = new System.Drawing.Size(242, 37);
            this.txtMaKhieuNai.TabIndex = 77;
            // 
            // rtxtPhanHoiKhieuNai
            // 
            this.rtxtPhanHoiKhieuNai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPhanHoiKhieuNai.Location = new System.Drawing.Point(521, 251);
            this.rtxtPhanHoiKhieuNai.Name = "rtxtPhanHoiKhieuNai";
            this.rtxtPhanHoiKhieuNai.Size = new System.Drawing.Size(333, 92);
            this.rtxtPhanHoiKhieuNai.TabIndex = 76;
            this.rtxtPhanHoiKhieuNai.Text = "";
            // 
            // lbPhanHoiKhieuNai
            // 
            this.lbPhanHoiKhieuNai.BackColor = System.Drawing.Color.Transparent;
            this.lbPhanHoiKhieuNai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanHoiKhieuNai.Location = new System.Drawing.Point(481, 219);
            this.lbPhanHoiKhieuNai.Name = "lbPhanHoiKhieuNai";
            this.lbPhanHoiKhieuNai.Size = new System.Drawing.Size(169, 27);
            this.lbPhanHoiKhieuNai.TabIndex = 75;
            this.lbPhanHoiKhieuNai.Text = "Phản hồi của KH";
            // 
            // rtxtNDKhieuNai
            // 
            this.rtxtNDKhieuNai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNDKhieuNai.Location = new System.Drawing.Point(521, 97);
            this.rtxtNDKhieuNai.Name = "rtxtNDKhieuNai";
            this.rtxtNDKhieuNai.ReadOnly = true;
            this.rtxtNDKhieuNai.Size = new System.Drawing.Size(333, 109);
            this.rtxtNDKhieuNai.TabIndex = 76;
            this.rtxtNDKhieuNai.Text = "";
            // 
            // lbNDKhieuNai
            // 
            this.lbNDKhieuNai.BackColor = System.Drawing.Color.Transparent;
            this.lbNDKhieuNai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNDKhieuNai.Location = new System.Drawing.Point(481, 65);
            this.lbNDKhieuNai.Name = "lbNDKhieuNai";
            this.lbNDKhieuNai.Size = new System.Drawing.Size(134, 27);
            this.lbNDKhieuNai.TabIndex = 75;
            this.lbNDKhieuNai.Text = "ND khiếu nại";
            // 
            // lbNgayTuVan
            // 
            this.lbNgayTuVan.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayTuVan.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTuVan.Location = new System.Drawing.Point(18, 233);
            this.lbNgayTuVan.Name = "lbNgayTuVan";
            this.lbNgayTuVan.Size = new System.Drawing.Size(155, 27);
            this.lbNgayTuVan.TabIndex = 69;
            this.lbNgayTuVan.Text = "Ngày khiếu nại";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.lbTinhTrang.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.Location = new System.Drawing.Point(18, 312);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(108, 27);
            this.lbTinhTrang.TabIndex = 69;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cbbTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTinhTrang.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.cbbTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbbTinhTrang.ItemHeight = 30;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Đã xử lý",
            "Đang xử lý"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(179, 307);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(242, 36);
            this.cbbTinhTrang.TabIndex = 72;
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(18, 174);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(140, 27);
            this.lbMaNhanVien.TabIndex = 68;
            this.lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 27);
            this.guna2HtmlLabel2.TabIndex = 68;
            this.guna2HtmlLabel2.Text = "Mã KH";
            // 
            // lbMaKhieuNai
            // 
            this.lbMaKhieuNai.BackColor = System.Drawing.Color.Transparent;
            this.lbMaKhieuNai.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhieuNai.Location = new System.Drawing.Point(18, 65);
            this.lbMaKhieuNai.Name = "lbMaKhieuNai";
            this.lbMaKhieuNai.Size = new System.Drawing.Size(133, 27);
            this.lbMaKhieuNai.TabIndex = 68;
            this.lbMaKhieuNai.Text = "Mã khiếu nại";
            // 
            // UC_PhanHoiKhieuNai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPhanHoiKhieuNai);
            this.Controls.Add(this.dtgrvPhanHoiKhieuNai);
            this.Name = "UC_PhanHoiKhieuNai";
            this.Size = new System.Drawing.Size(950, 750);
            this.Load += new System.EventHandler(this.UC_PhanHoiKhieuNai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvPhanHoiKhieuNai)).EndInit();
            this.grbPhanHoiKhieuNai.ResumeLayout(false);
            this.grbPhanHoiKhieuNai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvPhanHoiKhieuNai;
        private System.Windows.Forms.GroupBox grbPhanHoiKhieuNai;
        private Guna.UI2.WinForms.Guna2Button btnPhanHoi;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaKhieuNai;
        private System.Windows.Forms.RichTextBox rtxtPhanHoiKhieuNai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPhanHoiKhieuNai;
        private System.Windows.Forms.RichTextBox rtxtNDKhieuNai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNDKhieuNai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNgayTuVan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTinhTrang;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMaNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMaKhieuNai;
        private System.Windows.Forms.DateTimePicker dtpNgayKhieuNai;
    }
}
