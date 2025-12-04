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
    public partial class UC_ThongTinNhanVien : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinNhanVien()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaNV.Clear(); // Làm trống TextBox
            txtTenNV.Clear(); // Làm trống TextBox
            txtEmail.Clear(); // Làm trống TextBox
            txtSDT.Clear(); // Làm trống TextBox
            cbbViTri.SelectedIndex = -1; // Làm trống ComboBox
            cbbTinhTrang.SelectedIndex = -1; // Làm trống ComboBox
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM nhanvienhotro";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinNV.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtSDT.Text) || cbbViTri.SelectedIndex == -1 || cbbTinhTrang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm nhân viên
                string query = $"INSERT INTO NhanVienHotro (aNhanVien, HoTen, Email, SoDienThoai, ViTri, NgayBatDau, TinhTrang) " +
                               $"VALUES ('{txtMaNV.Text}', '{txtTenNV.Text}', '{txtEmail.Text}', '{txtSDT.Text}', '{cbbViTri.SelectedItem}', " +
                               $"'{dtpNgayBatDau.Value}', {cbbTinhTrang.SelectedItem})";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
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
                // Kiểm tra mã nhân viên không bị trống
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa nhân viên
                string query = $"DELETE FROM NhanVienHotro WHERE aNhanVien = '{txtMaNV.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
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
                if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtSDT.Text) || cbbViTri.SelectedIndex == -1 || cbbTinhTrang.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa thông tin nhân viên
                string query = $"UPDATE NhanVienHotro SET HoTen = '{txtTenNV.Text}', Email = '{txtEmail.Text}', SoDienThoai = '{txtSDT.Text}', " +
                               $"ViTri = '{cbbViTri.SelectedItem}', NgayBatDau = '{dtpNgayBatDau.Value}', TinhTrang = {cbbTinhTrang.SelectedItem} " +
                               $"WHERE aNhanVien = '{txtMaNV.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!");
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
                string query = $"SELECT * FROM nhanvienhotro WHERE MaNhanVien = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinNV.DataSource = dt;
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

        private void dtgrvThongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvThongTinNV.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaNV.Text = row.Cells["aNhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                cbbViTri.SelectedItem = row.Cells["ViTri"].Value.ToString();
                cbbTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
            }
        }
    }
}
