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
    public partial class UC_BaoHanh : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_BaoHanh()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            // Làm trống các ô nhập liệu
            txtMaBH.Clear();
            txtMaSP.Clear();
            txtThoiHan.Clear();
            rtxtMoTa.Clear();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM phieubaohanh";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvBaoHanh.DataSource = dt;
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
                if (string.IsNullOrEmpty(txtMaBH.Text) || string.IsNullOrEmpty(txtMaSP.Text) ||
                    string.IsNullOrEmpty(txtThoiHan.Text) || string.IsNullOrEmpty(rtxtMoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Sử dụng tham số hóa để tránh SQL Injection
                string query = "INSERT INTO phieubaohanh (MaBaoHanh, MaSanPham, MoTa, ThoiHan) " +
                               "VALUES (@MaBaoHanh, @MaSanPham, @MoTa, @ThoiHan)";

                // Sử dụng kết nối và câu lệnh chuẩn
                using (MySqlConnection conn = ketNoi.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaBaoHanh", txtMaBH.Text);
                    cmd.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@MoTa", rtxtMoTa.Text);
                    cmd.Parameters.AddWithValue("@ThoiHan", txtThoiHan.Text);

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
                string query = $"DELETE FROM phieubaohanh WHERE MaBaoHanh = '{txtMaBH.Text}'";

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
                string query = $"UPDATE phieubaohanh SET MaSanPham = '{txtMaSP.Text}', " +
                               $"MoTa = '{rtxtMoTa.Text}', ThoiHan = '{txtThoiHan.Text}' " +
                               $"WHERE MaBaoHanh = '{txtMaBH.Text}'";

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
                string query = $"SELECT * FROM phieubaohanh WHERE MaBaoHanh = '{txtTimKiem.Text}'";
                DataTable dt = ketNoi.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgrvBaoHanh.DataSource = dt;
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

        private void dtgrvBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrvBaoHanh.Rows[e.RowIndex];

                // Gán giá trị từ dòng được chọn vào các điều khiển
                txtMaBH.Text = row.Cells["MaBaoHanh"].Value?.ToString();
                txtMaSP.Text = row.Cells["MaSanPham"].Value?.ToString();
                txtThoiHan.Text = row.Cells["ThoiHan"].Value?.ToString();
                rtxtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }
    }
}
