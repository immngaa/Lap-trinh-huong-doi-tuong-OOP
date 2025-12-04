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
using System.IO;


namespace Nhom03
{
    public partial class UC_TiepNhanKhieuNai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        public UC_TiepNhanKhieuNai()
        {
            InitializeComponent();
        }
        // Hàm xóa dữ liệu nhập
        private void ClearFields()
        {
            txtMaKhieuNai.Clear();
            txtMaKH.Clear();
            txtMaNhanVien.Clear();
            dtpNgayKhieuNai.Value = DateTime.Now;
            cbbTinhTrang.SelectedIndex = -1;
            rtxtNDKhieuNai.Clear();
        }
        private void LoadDataGridView()
        {
            try
            {
                string query = "SELECT * FROM khieunai";
                DataTable dt = ketNoi.ExecuteQuery(query);
                dtgrvTiepNhanKhieuNai.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maKhieuNai = txtMaKhieuNai.Text.Trim();
                string maKH = txtMaKH.Text.Trim();
                string maNhanVien = txtMaNhanVien.Text.Trim();
                DateTime ngayKhieuNai = dtpNgayKhieuNai.Value;
                string tinhTrang = cbbTinhTrang.SelectedItem?.ToString();
                string noiDungKhieuNai = rtxtNDKhieuNai.Text.Trim();

                // Kiểm tra dữ liệu không rỗng
                if (string.IsNullOrEmpty(maKhieuNai) || string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(maNhanVien) ||
                    string.IsNullOrEmpty(tinhTrang) || string.IsNullOrEmpty(noiDungKhieuNai))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh SQL
                string query = $"INSERT INTO khieunai (MaKhieuNai, MaKhachHang, MaNhanVien, NgayKhieuNai, TinhTrang, NoiDungKhieuNai) " +
                               $"VALUES ('{maKhieuNai}', '{maKH}', '{maNhanVien}', '{ngayKhieuNai:yyyy-MM-dd}', '{tinhTrang}', '{noiDungKhieuNai}')";

                // Thực hiện lệnh SQL
                if (ketNoi.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Tiếp nhận khiếu nại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView(); // Cập nhật DataGridView
                    ClearFields(); // Xóa dữ liệu nhập
                }
                else
                {
                    MessageBox.Show("Tiếp nhận khiếu nại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiQuyet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi khiếu nại đến Văn Phòng giải quyết khiếu nại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void UC_TiepNhanKhieuNai_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnTiepNhan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
