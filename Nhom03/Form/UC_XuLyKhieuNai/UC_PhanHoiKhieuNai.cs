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
using System.Configuration;


namespace Nhom03
{
    public partial class UC_PhanHoiKhieuNai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_PhanHoiKhieuNai()
        {
            InitializeComponent();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                string query = "SELECT * FROM khieunai"; // Truy vấn dữ liệu
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvPhanHoiKhieuNai.DataSource = dt; // Gắn dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtgrvPhanHoiKhieuNai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Kiểm tra người dùng có click vào một dòng hợp lệ
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dtgrvPhanHoiKhieuNai.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng vào các control
                txtMaKhieuNai.Text = selectedRow.Cells["MaKhieuNai"].Value?.ToString();
                txtMaKH.Text = selectedRow.Cells["MaKhachHang"].Value?.ToString();
                txtMaNhanVien.Text = selectedRow.Cells["MaNhanVien"].Value?.ToString();
                dtpNgayKhieuNai.Value = DateTime.Parse(selectedRow.Cells["NgayKhieuNai"].Value?.ToString());
                cbbTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value?.ToString();
                rtxtNDKhieuNai.Text = selectedRow.Cells["NoiDungKhieuNai"].Value?.ToString();
                rtxtPhanHoiKhieuNai.Text = ""; // Xóa nội dung cũ để nhân viên nhập mới
            }
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            try
            {
                string maKhieuNai = txtMaKhieuNai.Text;
                string phanHoi = rtxtPhanHoiKhieuNai.Text;

                if (string.IsNullOrEmpty(maKhieuNai) || string.IsNullOrEmpty(phanHoi))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phản hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $"UPDATE khieunai SET PhanHoiKhachHang = '{phanHoi}', TinhTrang = 'Đã xử lý' WHERE MaKhieuNai = '{maKhieuNai}'";

                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Phản hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataToDataGridView(); // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Không thể phản hồi, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phản hồi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_PhanHoiKhieuNai_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
