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
    public partial class UC_LichSuTuVan : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_LichSuTuVan()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaKH.Clear(); // Làm trống TextBox
            txtMaNhanVien.Clear(); // Làm trống TextBox
            rtxtNDTuVan.Clear(); // Làm trống RichTextBox
            rtxtNDPhanHoi.Clear(); // Làm trống RichTextBox
            cbbPhuongThucLienHe.SelectedIndex = -1; // Làm trống ComboBox
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM lichsutuvan";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvLichSuTuVan.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) ||
                    string.IsNullOrEmpty(rtxtNDTuVan.Text) || string.IsNullOrEmpty(rtxtNDPhanHoi.Text) ||
                    cbbPhuongThucLienHe.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm lịch sử tư vấn
                string query = $"INSERT INTO LichSuTuVan (MaKhachHang, PhuongThucLienHe, NoiDungTuVan, ThoiGian, NoiDungPhanHoi, MaNhanVien) " +
                               $"VALUES ('{txtMaKH.Text}', '{cbbPhuongThucLienHe.SelectedItem}', '{rtxtNDTuVan.Text}', '{dtpNgayTuVan.Value}', " +
                               $"'{rtxtNDPhanHoi.Text}', '{txtMaNhanVien.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm lịch sử tư vấn thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm lịch sử tư vấn thất bại!");
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
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa lịch sử tư vấn!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa lịch sử tư vấn
                string query = $"DELETE FROM LichSuTuVan WHERE MaKhachHang = '{txtMaKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa lịch sử tư vấn thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa lịch sử tư vấn thất bại!");
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
                if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) ||
                    string.IsNullOrEmpty(rtxtNDTuVan.Text) || string.IsNullOrEmpty(rtxtNDPhanHoi.Text) ||
                    cbbPhuongThucLienHe.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa thông tin lịch sử tư vấn
                string query = $"UPDATE LichSuTuVan SET PhuongThucLienHe = '{cbbPhuongThucLienHe.SelectedItem}', " +
                               $"NoiDungTuVan = '{rtxtNDTuVan.Text}', ThoiGian = '{dtpNgayTuVan.Value}', " +
                               $"NoiDungPhanHoi = '{rtxtNDPhanHoi.Text}', MaNhanVien = '{txtMaNhanVien.Text}' " +
                               $"WHERE MaKhachHang = '{txtMaKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa lịch sử tư vấn thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa lịch sử tư vấn thất bại!");
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
                string query = $"SELECT * FROM lichsutuvan WHERE MaKhachHang = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                   dtgrvLichSuTuVan.DataSource = dt;
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

        private void dtgrvLichSuTuVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvLichSuTuVan.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                cbbPhuongThucLienHe.SelectedItem = row.Cells["PhuongThucLienHe"].Value.ToString();
                dtpNgayTuVan.Value = Convert.ToDateTime(row.Cells["ThoiGian"].Value);
                rtxtNDTuVan.Text = row.Cells["NoiDungTuVan"].Value.ToString();
                rtxtNDPhanHoi.Text = row.Cells["NoiDungPhanHoi"].Value.ToString();
            }
        }
    }
}
