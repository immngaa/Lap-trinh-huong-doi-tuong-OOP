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
    public partial class UC_NhomKH : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_NhomKH()
        {
            InitializeComponent();
        }

        private void ClearInputFields()
        {
            cbbMaNKH.SelectedIndex = -1; // Làm trống ComboBox
            cbbTenNKH.SelectedIndex = -1; // Làm trống ComboBox
            rtxtMoTa.Clear(); // Làm trống RichTextBox
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM NhomKH";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvNhomKH.DataSource = dt;
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
                if (string.IsNullOrEmpty(cbbMaNKH.Text) || string.IsNullOrEmpty(cbbTenNKH.Text) || string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm nhóm khách hàng
                string query = $"INSERT INTO NhomKH (MaNhomKH, TenNhomKH, MoTa) VALUES ('{cbbMaNKH.Text}', '{cbbTenNKH.Text}', '{rtxtMoTa.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm nhóm khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm nhóm khách hàng thất bại!");
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
                // Kiểm tra mã nhóm khách hàng không bị trống
                if (string.IsNullOrEmpty(cbbMaNKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhóm khách hàng để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa nhóm khách hàng
                string query = $"DELETE FROM NhomKH WHERE MaNhomKH = '{cbbMaNKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa nhóm khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa nhóm khách hàng thất bại!");
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
                if (string.IsNullOrEmpty(cbbMaNKH.Text) || string.IsNullOrEmpty(cbbTenNKH.Text) || string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa nhóm khách hàng
                string query = $"UPDATE NhomKH SET TenNhomKH = '{cbbTenNKH.Text}', MoTa = '{rtxtMoTa.Text}' WHERE MaNhomKH = '{cbbMaNKH.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa nhóm khách hàng thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa nhóm khách hàng thất bại!");
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
                string query = $"SELECT * FROM nhomkh WHERE MaNhomKH = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvNhomKH.DataSource = dt;
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

        private void dtgrvNhomKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvNhomKH.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                cbbMaNKH.Text = row.Cells["MaNhomKH"].Value.ToString();
                cbbTenNKH.Text = row.Cells["TenNhomKH"].Value.ToString();
                rtxtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
