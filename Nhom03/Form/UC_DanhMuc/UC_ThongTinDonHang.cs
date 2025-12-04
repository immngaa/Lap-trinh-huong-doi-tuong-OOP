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
    public partial class UC_ThongTinDonHang : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinDonHang()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaHD.Clear(); // Làm trống TextBox
            txtMaKH.Clear(); // Làm trống TextBox
            txtTongTien.Clear(); // Làm trống TextBox
            cbbPhuongThucThanhToan.SelectedIndex = -1; // Làm trống ComboBox
            cbbTinhTrangThanhToan.SelectedIndex = -1; // Làm trống ComboBox
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM hoadon";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinDonHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các ô nhập liệu không bị trống
                if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTongTien.Text) ||
                    cbbPhuongThucThanhToan.SelectedIndex == -1 || cbbTinhTrangThanhToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm hóa đơn
                string query = $"INSERT INTO HoaDon (MaHoaDon, MaKhachHang, NgayXuatHoaDon, TongTien, PhuongThucThanhToan, TinhTrangThanhToan) " +
                               $"VALUES ('{txtMaHD.Text}', '{txtMaKH.Text}', '{dtpNgayXuatHD.Value}', '{txtTongTien.Text}', " +
                               $"'{cbbPhuongThucThanhToan.SelectedItem}', '{cbbTinhTrangThanhToan.SelectedItem}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã hóa đơn không bị trống
                if (string.IsNullOrEmpty(txtMaHD.Text))
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa hóa đơn
                string query = $"DELETE FROM HoaDon WHERE MaHoaDon = '{txtMaHD.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các ô nhập liệu không bị trống
                if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTongTien.Text) ||
                    cbbPhuongThucThanhToan.SelectedIndex == -1 || cbbTinhTrangThanhToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa hóa đơn
                string query = $"UPDATE HoaDon SET MaKhachHang = '{txtMaKH.Text}', NgayXuatHoaDon = '{dtpNgayXuatHD.Value}', " +
                               $"TongTien = '{txtTongTien.Text}', PhuongThucThanhToan = '{cbbPhuongThucThanhToan.SelectedItem}', " +
                               $"TinhTrangThanhToan = '{cbbTinhTrangThanhToan.SelectedItem}' " +
                               $"WHERE MaHoaDon = '{txtMaHD.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM hoadon WHERE MaHoaDon = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinDonHang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void dtgrvThongTinDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvThongTinDonHang.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaHD.Text = row.Cells["MaHoaDon"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                dtpNgayXuatHD.Value = Convert.ToDateTime(row.Cells["NgayXuatHoaDon"].Value);
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                cbbPhuongThucThanhToan.SelectedItem = row.Cells["PhuongThucThanhToan"].Value.ToString();
                cbbTinhTrangThanhToan.SelectedItem = row.Cells["TinhTrangThanhToan"].Value.ToString();
            }
        }
    }
}
