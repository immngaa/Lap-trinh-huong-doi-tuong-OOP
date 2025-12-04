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
    public partial class FormQuenMatKhau : Form
    {
        KetNoiCSDL db = new KetNoiCSDL();
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void ptrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            grbDoiMatKhau.Visible = false;
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kết nối CSDL
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string query = $@"
                SELECT * FROM nhanvienhotro 
                WHERE MaNhanVien = '{txtMaNhanVien.Text}' 
                AND Email = '{txtEmail.Text}'";

            try
            {
                DataTable result = ketNoi.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    // Nếu thông tin chính xác
                    grbXacNhanTaiKhoan.Visible = false;
                    grbDoiMatKhau.Visible = true;
                }
                else
                {
                    // Nếu sai thông tin
                    MessageBox.Show("Bạn đã nhập sai thông tin, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu mới
            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) || string.IsNullOrWhiteSpace(txtNhapLaiMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin mật khẩu mới vào CSDL
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string updateQuery = $@"
                UPDATE taikhoan 
                SET MatKhau = '{txtMatKhauMoi.Text}' 
                WHERE MaNhanVien = '{txtMaNhanVien.Text}'";

            try
            {
                if (ketNoi.ExecuteNonQuery(updateQuery))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển sang Form Đăng nhập
                    FormDangNhap formDangNhap = new FormDangNhap();
                    formDangNhap.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
