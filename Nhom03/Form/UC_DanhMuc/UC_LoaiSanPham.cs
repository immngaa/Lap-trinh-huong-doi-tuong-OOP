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
    public partial class UC_LoaiSanPham : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_LoaiSanPham()
        {
            InitializeComponent();
        }

        private void ClearInputFields()
        {
            cbbMaLoaiSP.SelectedIndex = -1; // Làm trống ComboBox
            cbbTenPhanLoai.SelectedIndex = -1; // Làm trống ComboBox
            rtxtMoTa.Clear(); // Làm trống RichTextBox
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM loaisp";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvLoaiSanPham.DataSource = dt;
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
                if (string.IsNullOrEmpty(cbbMaLoaiSP.Text) || string.IsNullOrEmpty(cbbTenPhanLoai.Text) || string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm loại sản phẩm
                string query = $"INSERT INTO LoaiSP (MaLoaiSP, TenLoaiSP, MoTa) VALUES ('{cbbMaLoaiSP.Text}', '{cbbTenPhanLoai.Text}', '{rtxtMoTa.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại!");
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
                // Kiểm tra mã loại sản phẩm không bị trống
                if (string.IsNullOrEmpty(cbbMaLoaiSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa loại sản phẩm
                string query = $"DELETE FROM LoaiSP WHERE MaLoaiSP = '{cbbMaLoaiSP.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa loại sản phẩm thất bại!");
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
                if (string.IsNullOrEmpty(cbbMaLoaiSP.Text) || string.IsNullOrEmpty(cbbTenPhanLoai.Text) || string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa loại sản phẩm
                string query = $"UPDATE LoaiSP SET TenLoaiSP = '{cbbTenPhanLoai.Text}', MoTa = '{rtxtMoTa.Text}' WHERE MaLoaiSP = '{cbbMaLoaiSP.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa loại sản phẩm thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa loại sản phẩm thất bại!");
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
                string query = $"SELECT * FROM loaisp WHERE MaLoaiSP = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvLoaiSanPham.DataSource = dt;
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

        private void dtgrvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvLoaiSanPham.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                cbbMaLoaiSP.Text = row.Cells["MaLoaiSP"].Value.ToString();
                cbbTenPhanLoai.Text = row.Cells["TenLoaiSP"].Value.ToString();
                rtxtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
