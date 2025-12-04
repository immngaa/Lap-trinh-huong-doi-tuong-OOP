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
    public partial class UC_TheoDoiTinhHinhKhieuNai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_TheoDoiTinhHinhKhieuNai()
        {
            InitializeComponent();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                string query = "SELECT * FROM danhgiasaukhieunai"; // Truy vấn dữ liệu
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvTheoDoiTinhHinhKhieuNai.DataSource = dt; // Gắn dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgrvTheoDoiTinhHinhKhieuNai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgrvTheoDoiTinhHinhKhieuNai.Rows[e.RowIndex] != null)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dtgrvTheoDoiTinhHinhKhieuNai.Rows[e.RowIndex];
                // Gán dữ liệu từ dòng được chọn vào các control
                txtMaDanhGia.Text = row.Cells["MaDanhGia"].Value?.ToString();
                txtMaKhieuNai.Text = row.Cells["MaKhieuNai"].Value?.ToString();
                cbbDiemDanhGia.SelectedItem = row.Cells["DiemDanhGia"].Value?.ToString();
                rtxtNDDanhGia.Text = row.Cells["BinhLuan"].Value?.ToString();

            }
        }

        private void btnPhanHoiLai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các control
                string maDanhGia = txtMaDanhGia.Text.Trim();
                string traLoi = rtxtNDDanhGia.Text.Trim();

                // Kiểm tra trường bắt buộc
                if (string.IsNullOrEmpty(maDanhGia))
                {
                    MessageBox.Show("Vui lòng chọn một mục để phản hồi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(traLoi))
                {
                    MessageBox.Show("Vui lòng nhập nội dung phản hồi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu lệnh SQL chỉ cập nhật cột TraLoiSauKhieuNai
                string query = $@"UPDATE danhgiasaukhieunai 
                          SET TraLoiSauKhieuNai = '{traLoi}' 
                          WHERE MaDanhGia = '{maDanhGia}'";

                // Thực thi câu lệnh
                KetNoiCSDL ketNoi = new KetNoiCSDL();
                bool isUpdated = ketNoi.ExecuteNonQuery(query);

                if (isUpdated)
                {
                    MessageBox.Show("Phản hồi đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm trống các control sau khi cập nhật
                    txtMaDanhGia.Clear();
                    rtxtNDDanhGia.Clear();

                    // Tải lại dữ liệu trong DataGridView
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể gửi phản hồi. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_TheoDoiTinhHinhKhieuNai_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
