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
    public partial class UC_ThongTinKH : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinKH()
        {
            InitializeComponent();
        }

        private void ClearInputFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtDiemTichLuy.Clear();
            cbbMaNKH.SelectedIndex = -1;
            cbbCapDoTV.SelectedIndex = -1;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM KhachHang";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinKH.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) ||
                    string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDiemTichLuy.Text) ||
                    cbbCapDoTV.SelectedIndex == -1 || cbbMaNKH.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Xác định giới tính
                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";

                // Sử dụng câu lệnh SQL để thêm khách hàng
                string query = $"INSERT INTO KhachHang (MaKhachHang, TenKhachHang, Email, SoDienThoai, DiaChi, " +
                               $"MaNhomKH, DiemTichLuy, NgaySinh, GioiTinh, CapDoThanhVien) " +
                               $"VALUES ('{txtMaKH.Text}', '{txtTenKH.Text}', '{txtEmail.Text}', '{txtSDT.Text}', " +
                               $"'{txtDiaChi.Text}', '{cbbMaNKH.SelectedItem}', {txtDiemTichLuy.Text}, " +
                               $"'{dtpNgaySinh.Value.ToString("yyyy-MM-dd")}', '{gioiTinh}', '{cbbCapDoTV.SelectedItem}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!");
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
                // Kiểm tra mã khách hàng không bị trống
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa khách hàng
                string query = $"DELETE FROM KhachHang WHERE MaKhachHang = '{txtMaKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!");
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
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) ||
                    string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDiemTichLuy.Text) ||
                    cbbCapDoTV.SelectedIndex == -1 || cbbMaNKH.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Xác định giới tính
                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";

                // Sử dụng câu lệnh SQL để sửa thông tin khách hàng
                string query = $"UPDATE KhachHang SET " +
                               $"TenKhachHang = '{txtTenKH.Text}', " +
                               $"Email = '{txtEmail.Text}', " +
                               $"SoDienThoai = '{txtSDT.Text}', " +
                               $"DiaChi = '{txtDiaChi.Text}', " +
                               $"MaNhomKH = '{cbbMaNKH.SelectedItem}', " +
                               $"DiemTichLuy = {txtDiemTichLuy.Text}, " +
                               $"NgaySinh = '{dtpNgaySinh.Value.ToString("yyyy-MM-dd")}', " +
                               $"GioiTinh = '{gioiTinh}', " +
                               $"CapDoThanhVien = '{cbbCapDoTV.SelectedItem}' " +
                               $"WHERE MaKhachHang = '{txtMaKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại!");
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
                string query = $"SELECT * FROM khachhang WHERE MaKhachHang = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinKH.DataSource = dt;
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

        private void dtgrvThongTinKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvThongTinKH.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                // Chọn giới tính
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                rbtnNam.Checked = gioiTinh == "Nam";
                rbtnNu.Checked = gioiTinh == "Nữ";

                // Chọn cấp độ thành viên
                cbbCapDoTV.SelectedItem = row.Cells["CapDoThanhVien"].Value.ToString();

                // Chọn nhóm khách hàng
                cbbMaNKH.SelectedItem = row.Cells["MaNhomKH"].Value.ToString();
            }
        }
    }
}
