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
    public partial class UC_ThongTinSanPham : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_ThongTinSanPham()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            // Làm trống các ô nhập liệu
            txtMaSP.Clear();
            txtTenSP.Clear();
            cbbMaLoaiSP.SelectedIndex = -1;
            rtxtMoTa.Clear();
            txtGia.Clear();
            txtThuongHieu.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM sanpham";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvThongTinSanPham.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text) ||
                    string.IsNullOrEmpty(cbbMaLoaiSP.ValueMember) || string.IsNullOrEmpty(rtxtMoTa.Text) ||
                    string.IsNullOrEmpty(txtThuongHieu.Text) || string.IsNullOrEmpty(txtGia.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng tham số hóa để tránh SQL Injection
                string query = "INSERT INTO sanpham (MaSanPham, TenSanPham, MoTa, Gia, MaPhanLoai, ThuongHieu) " +
                               "VALUES (@MaSanPham, @TenSanPham, @MoTa, @Gia, @MaPhanLoai, @ThuongHieu)";

                // Sử dụng kết nối và câu lệnh chuẩn
                using (MySqlConnection conn = ketNoi.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSanPham", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@MoTa", rtxtMoTa.Text);
                    cmd.Parameters.AddWithValue("@Gia", txtGia.Text);
                    cmd.Parameters.AddWithValue("@MaPhanLoai", cbbMaLoaiSP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ThuongHieu", txtThuongHieu.Text);

                    // Thực thi câu lệnh SQL
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        btnXem.PerformClick(); // Tải lại dữ liệu trong DataGridView
                        ClearInputFields();  // Làm trống các ô nhập liệu
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
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
                string query = $"DELETE FROM sanpham WHERE MaBaoHanh = '{txtMaSP.Text}'";

                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Xóa thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();
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
                if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text) ||
                    string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(cbbMaLoaiSP.Text) ||
                    string.IsNullOrEmpty(rtxtMoTa.Text) || string.IsNullOrEmpty(txtThuongHieu.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                string query = $"UPDATE SanPham SET " +
                      $"TenSanPham = '{txtTenSP.Text}', " +
                      $"MoTa = '{rtxtMoTa.Text}', " +
                      $"Gia = '{txtGia.Text}', " +
                      $"MaPhanLoai = '{cbbMaLoaiSP.SelectedItem.ToString()}', " +
                      $"ThuongHieu = '{txtThuongHieu.Text}' " +
                      $"WHERE MaSanPham = '{txtMaSP.Text}'";

                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Sửa thành công!");
                    btnXem.PerformClick(); // Tải lại dữ liệu
                    ClearInputFields();
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
                string query = $"SELECT * FROM sanpham WHERE MaSanPham = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvThongTinSanPham.DataSource = dt;
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

        private void dtgrvThongTinSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrvThongTinSanPham.Rows[e.RowIndex];

                // Gán giá trị từ dòng được chọn vào các điều khiển
                txtMaSP.Text = row.Cells["MaSanPHam"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSanPham"].Value?.ToString();
                rtxtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                txtGia.Text = row.Cells["Gia"].Value?.ToString();
				cbbMaLoaiSP.Text = row.Cells["MaPhanLoai"].Value?.ToString();
				txtThuongHieu.Text = row.Cells["ThuongHieu"].Value?.ToString();
            }
        }

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
