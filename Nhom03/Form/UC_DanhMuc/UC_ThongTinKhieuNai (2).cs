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
    public partial class UC_ThongTinKhieuNai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinKhieuNai()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaKhieuNai.Clear(); // Làm trống TextBox
            txtMaKH.Clear(); // Làm trống TextBox
            txtMaNhanVien.Clear(); // Làm trống TextBox
            rtxtNDKhieuNai.Clear(); // Làm trống RichTextBox
            rtxtPhanHoiKhieuNai.Clear(); // Làm trống RichTextBox
            cbbTinhTrang.SelectedIndex = -1; // Làm trống ComboBox
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM khieunai";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinKhieuNai.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaKhieuNai.Text) || string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) ||
                    cbbTinhTrang.SelectedIndex == -1 || string.IsNullOrEmpty(rtxtNDKhieuNai.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm khiếu nại
                string query = $"INSERT INTO KhieuNai (MaKhieuNai, MaKhachHang, MaNhanVien, NgayKhieuNai, TinhTrang, NoiDungKhieuNai, PhanHoiKhieuNai) " +
                               $"VALUES ('{txtMaKhieuNai.Text}', '{txtMaKH.Text}', '{txtMaNhanVien.Text}', '{dtpNgayKhieuNai.Value}', " +
                               $"'{cbbTinhTrang.SelectedItem}', '{rtxtNDKhieuNai.Text}', '{rtxtPhanHoiKhieuNai.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm khiếu nại thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm khiếu nại thất bại!");
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
                // Kiểm tra mã khiếu nại không bị trống
                if (string.IsNullOrEmpty(txtMaKhieuNai.Text))
                {
                    MessageBox.Show("Vui lòng chọn khiếu nại để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa khiếu nại
                string query = $"DELETE FROM KhieuNai WHERE MaKhieuNai = '{txtMaKhieuNai.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa khiếu nại thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa khiếu nại thất bại!");
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
                if (string.IsNullOrEmpty(txtMaKhieuNai.Text) || string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) ||
                    cbbTinhTrang.SelectedIndex == -1 || string.IsNullOrEmpty(rtxtNDKhieuNai.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa khiếu nại
                string query = $"UPDATE KhieuNai SET MaKhachHang = '{txtMaKH.Text}', MaNhanVien = '{txtMaNhanVien.Text}', " +
                               $"NgayKhieuNai = '{dtpNgayKhieuNai.Value}', TinhTrang = '{cbbTinhTrang.SelectedItem}', " +
                               $"NoiDungKhieuNai = '{rtxtNDKhieuNai.Text}', PhanHoiKhieuNai = '{rtxtPhanHoiKhieuNai.Text}' " +
                               $"WHERE MaKhieuNai = '{txtMaKhieuNai.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa khiếu nại thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa khiếu nại thất bại!");
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
                string query = $"SELECT * FROM khieunai WHERE MaKhieuNai = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinKhieuNai.DataSource = dt;
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

        private void dtgrvThongTinKhieuNai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvThongTinKhieuNai.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaKhieuNai.Text = row.Cells["MaKhieuNai"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                dtpNgayKhieuNai.Value = Convert.ToDateTime(row.Cells["NgayKhieuNai"].Value);
                cbbTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value.ToString();
                rtxtNDKhieuNai.Text = row.Cells["NoiDungKhieuNai"].Value.ToString();
                rtxtPhanHoiKhieuNai.Text = row.Cells["PhanHoiKhieuNai"].Value.ToString();
            }
        }
    }
}
