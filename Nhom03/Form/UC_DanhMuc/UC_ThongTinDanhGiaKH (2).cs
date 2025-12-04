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
    public partial class UC_ThongTinDanhGiaKH : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinDanhGiaKH()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtPH.Clear(); // Làm trống TextBox
            txtMaKH.Clear(); // Làm trống TextBox
            txtMaSP.Clear(); // Làm trống TextBox
            cbbMucDoHaiLong.SelectedIndex = -1; // Làm trống ComboBox
            rtxtND.Clear(); // Làm trống RichTextBox
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM phanhoi";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinDanhGiaKH.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtPH.Text) || string.IsNullOrEmpty(txtMaKH.Text) ||
                    string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(rtxtND.Text) ||
                    cbbMucDoHaiLong.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm phản hồi
                string query = $"INSERT INTO PhanHoi (MaPhanHoi, MaKhachHang, MaSanPham, NgayPhanHoi, MucDoHaiLong, NoiDung) " +
                               $"VALUES ('{txtPH.Text}', '{txtMaKH.Text}', '{txtMaSP.Text}', '{dtpNgay.Value}', '{cbbMucDoHaiLong.SelectedItem}', '{rtxtND.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm phản hồi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm phản hồi thất bại!");
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
                // Kiểm tra mã phản hồi không bị trống
                if (string.IsNullOrEmpty(txtPH.Text))
                {
                    MessageBox.Show("Vui lòng chọn phản hồi để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa phản hồi
                string query = $"DELETE FROM PhanHoi WHERE MaPhanHoi = '{txtPH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa phản hồi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa phản hồi thất bại!");
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
                if (string.IsNullOrEmpty(txtPH.Text) || string.IsNullOrEmpty(txtMaKH.Text) ||
                    string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(rtxtND.Text) ||
                    cbbMucDoHaiLong.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa phản hồi
                string query = $"UPDATE PhanHoi SET MaKhachHang = '{txtMaKH.Text}', MaSanPham = '{txtMaSP.Text}', " +
                               $"NgayPhanHoi = '{dtpNgay.Value}', MucDoHaiLong = '{cbbMucDoHaiLong.SelectedItem}', " +
                               $"NoiDung = '{rtxtND.Text}' WHERE MaPhanHoi = '{txtPH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa phản hồi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa phản hồi thất bại!");
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
                string query = $"SELECT * FROM phanhoi WHERE MaKhachHang = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinDanhGiaKH.DataSource = dt;
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

        private void dtgrvThongTinDanhGiaKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvThongTinDanhGiaKH.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtPH.Text = row.Cells["MaPhanHoi"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                cbbMucDoHaiLong.SelectedItem = row.Cells["MucDoHaiLong"].Value.ToString();
                dtpNgay.Value = Convert.ToDateTime(row.Cells["NgayPhanHoi"].Value);
                rtxtND.Text = row.Cells["NoiDung"].Value.ToString();
            }
        }
    }
}
