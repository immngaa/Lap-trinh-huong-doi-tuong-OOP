using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nhom03
{
    public partial class FormDangNhap : Form
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void ptrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTenDangNhap.Text;
                string password = txtMatKhau.Text;

                // Kiểm tra thông tin đăng nhập
                if (username == "Admin" && password == "123")
                {
                    // Hiển thị FormGiaoDienChinh
                    FormGiaoDienChinh formChinh = new FormGiaoDienChinh();
                    formChinh.Show();
                    this.Hide();
                    return;
                }
                    // Truy vấn kiểm tra thông tin đăng nhập từ CSDL
                    string query = $"SELECT * FROM taikhoan WHERE TenDangNhap = '{txtTenDangNhap.Text}' AND MatKhau = '{txtMatKhau.Text}'";
                    DataTable dt = ketNoi.ExecuteQuery(query);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở FormMain
                        FormGiaoDienChinh formMain = new FormGiaoDienChinh();
                        formMain.Show();
                        this.Hide(); // Ẩn form đăng nhập
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
}

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.Show();
            this.Hide();
        }

        private void chbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.Show();
            this.Hide();
        }
    }
}
