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
    public partial class UC_CTKhuyenMai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_CTKhuyenMai()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtMaKM.Clear(); // Làm trống TextBox
            txtTenKM.Clear(); // Làm trống TextBox
            txtMaSP.Clear(); // Làm trống TextBox
            txtMucGiamGia.Clear(); // Làm trống TextBox
            txtDiemCanDoi.Clear(); // Làm trống TextBox
            rtxtMoTa.Clear(); // Làm trống RichTextBox
            cbbTinhTrang.SelectedIndex = -1; // Làm trống ComboBox
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM khuyenmai";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvCTKhuyenMai.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaKM.Text) || string.IsNullOrEmpty(txtTenKM.Text) || string.IsNullOrEmpty(txtMaSP.Text) ||
                    string.IsNullOrEmpty(txtMucGiamGia.Text) || string.IsNullOrEmpty(txtDiemCanDoi.Text) ||
                    string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để thêm khuyến mãi
                string query = $"INSERT INTO KhuyenMai (MaKhuyenMai, TenKhuyenMai, MoTa, NgayBatDau, NgayKetThuc, MucGiamGia, TinhTrang, MaSanPham, DiemCanDoi) " +
                               $"VALUES ('{txtMaKM.Text}', '{txtTenKM.Text}', '{rtxtMoTa.Text}', '{dtpNgayBatDau.Value}', '{dtpNgayKetThuc.Value}', " +
                               $"'{txtMucGiamGia.Text}', '{cbbTinhTrang.SelectedItem}', '{txtMaSP.Text}', '{txtDiemCanDoi.Text}')";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại!");
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
                // Kiểm tra mã khuyến mãi không bị trống
                if (string.IsNullOrEmpty(txtMaKM.Text))
                {
                    MessageBox.Show("Vui lòng chọn khuyến mãi để xóa!");
                    return;
                }

                // Sử dụng câu lệnh SQL để xóa khuyến mãi
                string query = $"DELETE FROM KhuyenMai WHERE MaKhuyenMai = '{txtMaKM.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Xóa khuyến mãi thất bại!");
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
                if (string.IsNullOrEmpty(txtMaKM.Text) || string.IsNullOrEmpty(txtTenKM.Text) || string.IsNullOrEmpty(txtMaSP.Text) ||
                    string.IsNullOrEmpty(txtMucGiamGia.Text) || string.IsNullOrEmpty(txtDiemCanDoi.Text) ||
                    string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng câu lệnh SQL để sửa khuyến mãi
                string query = $"UPDATE KhuyenMai SET TenKhuyenMai = '{txtTenKM.Text}', MoTa = '{rtxtMoTa.Text}', " +
                               $"NgayBatDau = '{dtpNgayBatDau.Value}', NgayKetThuc = '{dtpNgayKetThuc.Value}', " +
                               $"MucGiamGia = '{txtMucGiamGia.Text}', TinhTrang = '{cbbTinhTrang.SelectedItem}', " +
                               $"MaSanPham = '{txtMaSP.Text}', DiemCanDoi = '{txtDiemCanDoi.Text}' " +
                               $"WHERE MaKhuyenMai = '{txtMaKM.Text}'";

                // Thực thi câu lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa khuyến mãi thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();  // Làm trống các ô nhập liệu
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại!");
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
                string query = $"SELECT * FROM khuyenmai WHERE MaKhuyenMai = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvCTKhuyenMai.DataSource = dt;
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

        private void dtgrvCTKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ dòng đã chọn
                DataGridViewRow row = dtgrvCTKhuyenMai.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các ô nhập liệu
                txtMaKM.Text = row.Cells["MaKhuyenMai"].Value.ToString();
                txtTenKM.Text = row.Cells["TenKhuyenMai"].Value.ToString();
                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                txtMucGiamGia.Text = row.Cells["MucGiamGia"].Value.ToString();
                txtDiemCanDoi.Text = row.Cells["DiemCanDoi"].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                rtxtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                cbbTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value.ToString();
            }
        }
    }
}
