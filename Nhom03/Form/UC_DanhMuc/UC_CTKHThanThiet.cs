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
    public partial class UC_CTKHThanThiet : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_CTKHThanThiet()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaCT.Clear(); // Làm trống TextBox
            txtTenCT.Clear(); // Làm trống TextBox
            cbbMaNKH.SelectedIndex = -1; // Làm trống ComboBox
            dtpBatDau.Value = DateTime.Now; // Thiết lập giá trị mặc định cho DateTimePicker
            dtpKetThuc.Value = DateTime.Now; // Thiết lập giá trị mặc định cho DateTimePicker
            rtxtMoTa.Clear(); // Làm trống RichTextBox
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM ctkhthanthiet";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvCTKHTT.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaCT.Text) || string.IsNullOrEmpty(txtTenCT.Text) ||
                    string.IsNullOrEmpty(rtxtMoTa.Text) || cbbMaNKH.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm chương trình khuyến mãi
                string query = $"INSERT INTO CTKHThanThiet (MaChuongTrinh, TenChuongTrinh, MaNhomKH, ThoiGianBatDau, ThoiGianKetThuc, MoTa) " +
                               $"VALUES ('{txtMaCT.Text}', '{txtTenCT.Text}', '{cbbMaNKH.SelectedItem}', '{dtpBatDau.Value}', '{dtpKetThuc.Value}', '{rtxtMoTa.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm chương trình thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm chương trình thất bại!");
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
                // Kiểm tra mã chương trình không bị trống
                if (string.IsNullOrEmpty(txtMaCT.Text))
                {
                    MessageBox.Show("Vui lòng chọn chương trình để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa chương trình khuyến mãi
                string query = $"DELETE FROM CTKHThanThiet WHERE MaChuongTrinh = '{txtMaCT.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa chương trình thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa chương trình thất bại!");
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
                if (string.IsNullOrEmpty(txtMaCT.Text) || string.IsNullOrEmpty(txtTenCT.Text) ||
                    string.IsNullOrEmpty(rtxtMoTa.Text) || cbbMaNKH.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa chương trình khuyến mãi
                string query = $"UPDATE CTKHThanThiet SET TenChuongTrinh = '{txtTenCT.Text}', " +
                               $"MaNhomKH = '{cbbMaNKH.SelectedItem}', ThoiGianBatDau = '{dtpBatDau.Value}', " +
                               $"ThoiGianKetThuc = '{dtpKetThuc.Value}', MoTa = '{rtxtMoTa.Text}' " +
                               $"WHERE MaChuongTrinh = '{txtMaCT.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa chương trình thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa chương trình thất bại!");
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
                string query = $"SELECT * FROM ctkhthanthiet WHERE MaChuongTrinh = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvCTKHTT.DataSource = dt;
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

        private void dtgrvCTKHTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvCTKHTT.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaCT.Text = row.Cells["MaChuongTrinh"].Value.ToString();
                txtTenCT.Text = row.Cells["TenChuongTrinh"].Value.ToString();
                cbbMaNKH.SelectedItem = row.Cells["MaNhomKH"].Value.ToString();
                dtpBatDau.Value = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);
                dtpKetThuc.Value = Convert.ToDateTime(row.Cells["ThoiGianKetThuc"].Value);
                rtxtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
