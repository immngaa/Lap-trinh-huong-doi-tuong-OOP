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
    public partial class FormDangKy : Form
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public FormDangKy()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtViTri.Clear();
            txtTinhTrang.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMatKhau.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
        }
        private void ptrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void chbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
            txtNhapLaiMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng kết nối cơ sở dữ liệu
            KetNoiCSDL ketNoi = new KetNoiCSDL();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã nhân viên đã tồn tại hay chưa
            string checkMaNVQuery = $"SELECT COUNT(*) FROM nhanvienhotro WHERE MaNhanVien = '{txtMaNV.Text}'";
            try
            {
                object result = ketNoi.ExecuteScalar(checkMaNVQuery);
                int count = result != null ? Convert.ToInt32(result) : 0;

                if (count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra mã nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chèn thông tin vào bảng nhanvienhotro
            string insertNhanVienQuery = $@"
        INSERT INTO nhanvienhotro (MaNhanVien, HoTen, Email, SoDienThoai, ViTri, NgayBatDau, TinhTrang)
        VALUES ('{txtMaNV.Text}', '{txtHoTen.Text}', '{txtEmail.Text}', '{txtSDT.Text}', 
                '{txtViTri.Text}', '{dtpNgayBatDau.Value:yyyy-MM-dd}', '{txtTinhTrang.Text}')";

            try
            {
                if (!ketNoi.ExecuteNonQuery(insertNhanVienQuery))
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chèn thông tin vào bảng taikhoan
            string insertTaiKhoanQuery = $@"
        INSERT INTO taikhoan (TenDangNhap, MaNhanVien, MatKhau)
        VALUES ('{txtTenDangNhap.Text}', '{txtMaNV.Text}', '{txtMatKhau.Text}')";

            try
            {
                if (!ketNoi.ExecuteNonQuery(insertTaiKhoanQuery))
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset các trường dữ liệu
                ClearInputFields();
                FormDangNhap formDangNhap = new FormDangNhap(); // Khởi tạo Form đăng nhập
                formDangNhap.Show(); // Hiển thị Form đăng nhập
                this.Close(); // Đóng Form hiện tại (Form đăng ký)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
