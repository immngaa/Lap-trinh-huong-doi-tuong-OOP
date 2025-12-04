using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Thư viện MySQL

namespace Nhom03
{
    public partial class UC_CTKHTTDoiDiem : UserControl
    {
        // Sử dụng đối tượng KetNoiCSDL để kết nối cơ sở dữ liệu
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

        public UC_CTKHTTDoiDiem()
        {
            InitializeComponent();
            LoadKhuyenMai();
            LoadKhachHang();
            AttachEvents();
        }

        private void AttachEvents()
        {
            dtgrvKhachHang.CellClick += DtgrvKhachHang_CellClick;
            dtgrvChuongTrinhKhuyenMai.CellClick += DtgrvChuongTrinhKhuyenMai_CellClick;
            btnTimKiem.Click += BtnTimKiem_Click;
            btnDoiDiem.Click += BtnDoiDiem_Click;
            btnTaiLai.Click += BtnTaiLai_Click;
        }

        private void LoadKhuyenMai()
        {
            try
            {
                string query = "SELECT * FROM khuyenmai"; // Thay "khuyenmai" bằng tên bảng thực tế
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvChuongTrinhKhuyenMai.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu Khuyến mãi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKhachHang()
        {
            try
            {
                string query = "SELECT * FROM khachhang"; // Thay "khachhang" bằng tên bảng thực tế
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvKhachHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu Khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgrvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrvKhachHang.Rows[e.RowIndex];
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtTongDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value?.ToString();
            }
        }

        private void DtgrvChuongTrinhKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrvChuongTrinhKhuyenMai.Rows[e.RowIndex];
                txtMaKhuyenMai.Text = row.Cells["MaKhuyenMai"].Value?.ToString();
                txtTenKhuyenMai.Text = row.Cells["TenKhuyenMai"].Value?.ToString();
                txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                txtMucGiamGia.Text = row.Cells["MucGiamGia"].Value?.ToString();
                txtTinhTrang.Text = row.Cells["TinhTrang"].Value?.ToString();
                txtDiemCanDoi.Text = row.Cells["DiemCanDoi"].Value?.ToString();
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã khuyến mãi cần tìm từ TextBox
                string query = $"SELECT * FROM khuyenmai WHERE MaKhuyenMai = '{txtTimKiem.Text}'";

                // Sử dụng phương thức ExecuteQuery từ KetNoiCSDL
                DataTable dt = ketNoi.ExecuteQuery(query);

                // Kiểm tra kết quả
                if (dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào DataGridView
                    dtgrvChuongTrinhKhuyenMai.DataSource = dt;
                }
                else
                {
                    // Thông báo nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnDoiDiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTongDiemTichLuy.Text) && !string.IsNullOrEmpty(txtDiemCanDoi.Text))
            {
                try
                {
                    int diemTichLuy = int.Parse(txtTongDiemTichLuy.Text);
                    int diemCanDoi = int.Parse(txtDiemCanDoi.Text);

                    if (diemTichLuy >= diemCanDoi)
                    {
                        int diemTichLuyMoi = diemTichLuy - diemCanDoi;
                        txtTongDiemTichLuy.Text = diemTichLuyMoi.ToString();

                        // Cập nhật điểm tích lũy mới vào cơ sở dữ liệu
                        string query = $"UPDATE khachhang SET DiemTichLuy = {diemTichLuyMoi} WHERE TenKhachHang = '{txtTenKhachHang.Text}'";
                        ketNoi.ExecuteQuery(query); // Gọi phương thức ExecuteQuery hiện tại

                        MessageBox.Show($"Đổi mã thành công! Điểm tích lũy mới của {txtTenKhachHang.Text} là: {diemTichLuyMoi}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không đủ điểm để đổi mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đổi điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin khách hàng và mã khuyến mãi để đổi điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM khachhang"; // Truy vấn lấy toàn bộ thông tin khách hàng
                DataTable dt = ketNoi.ExecuteQuery(query); // Không cần truyền tham số

                dtgrvKhachHang.DataSource = dt; // Cập nhật lại DataGridView với dữ liệu mới
                MessageBox.Show("Thông tin đã được tải lại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lại dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
