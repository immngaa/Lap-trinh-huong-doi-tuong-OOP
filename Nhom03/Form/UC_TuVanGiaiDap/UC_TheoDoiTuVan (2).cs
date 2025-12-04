using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom03
{
    public partial class UC_TheoDoiTuVan : UserControl
    {
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
		public UC_TheoDoiTuVan(string maYeuCau, string maKH, string trangThai, string noiDungYeuCau, DateTime ngayGui, string maNV)
		{
			InitializeComponent();

			// Gán dữ liệu vào các ô trong GroupBox
			txtMaYeuCau.Text = maYeuCau;
			txtMaKH.Text = maKH;
			cbbTrangThai.Text = trangThai;
			rtxtNoiDungYeuCau.Text = noiDungYeuCau;
			dtpNgayGui.Value = ngayGui;
			txtMaNV.Text = maNV;
		}

		public UC_TheoDoiTuVan()
		{
		}

		private void dtgrvTheoDoiYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem người dùng có click vào dòng hợp lệ hay không (không phải header)
			if (e.RowIndex >= 0)
			{
				// Lấy các giá trị từ dòng đã chọn
				DataGridViewRow row = dtgrvTheoDoiYeuCau.Rows[e.RowIndex];

				// Gán giá trị từ các ô trong dòng vào các ô nhập liệu
				txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
				txtMaYeuCau.Text = row.Cells["MaYeuCau"].Value.ToString();
				txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
				rtxtNoiDungYeuCau.Text = row.Cells["NoiDungYeuCau"].Value.ToString();
				dtpNgayGui.Value = Convert.ToDateTime(row.Cells["NgayGui"].Value);
				cbbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

			}
		}

		private void UC_TheoDoiTuVan_Load(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void LoadDataGridView()
		{
			string query = "SELECT * FROM yeucautuvan"; // Câu truy vấn
			try
			{
				// Thực thi câu truy vấn để lấy dữ liệu từ cơ sở dữ liệu
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				// Gán dữ liệu vào DataGridView
				dtgrvTheoDoiYeuCau.DataSource = dataTable;

				// Cập nhật tổng phiếu
				UpdateSummary();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			try
			{
				string query = $"UPDATE yeucautuvan SET TrangThai = '{cbbTrangThai.Text}' WHERE MaYeuCau = '{txtMaYeuCau.Text}'";

				// Thực thi câu lệnh SQL
				if (ketNoi.ExecuteNonQuery(query))
				{
					MessageBox.Show("Cập nhật trạng thái thành công!");
					LoadDataGridView(); // Tải lại dữ liệu
				}
				else
				{
					MessageBox.Show("Sửa trạng thái thất bại!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}


		private void gbTheoDoiTuVan_Enter(object sender, EventArgs e)
		{

		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT * FROM yeucautuvan";
				DataTable dt = ketNoi.ExecuteQuery(query);
				dtgrvTheoDoiYeuCau.DataSource = dt;

				// Cập nhật tổng phiếu
				UpdateSummary();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

		private void UpdateSummary()
		{
			// Khởi tạo biến đếm
			int tong = 0;
			int chuaGiaiQuyet = 0;
			int dangGiaiQuyet = 0;
			int daGiaiQuyet = 0;

			// Duyệt qua các hàng trong DataGridView
			foreach (DataGridViewRow row in dtgrvTheoDoiYeuCau.Rows)
			{
				if (row.Cells["TrangThai"].Value != null) // "TrangThai" là tên cột trạng thái
				{
					string trangThai = row.Cells["TrangThai"].Value.ToString();
					tong++; // Đếm tổng số phiếu

					// Kiểm tra giá trị trạng thái và tăng biến đếm tương ứng
					if (trangThai == "Chưa giải quyết")
					{
						chuaGiaiQuyet++;
					}
					else if (trangThai == "Đang giải quyết")
					{
						dangGiaiQuyet++;
					}
					else if (trangThai == "Đã giải quyết")
					{
						daGiaiQuyet++;
					}
				}
			}

			// Cập nhật giá trị vào TextBox
			txtTong.Text = tong.ToString();
			txtChuaGQ.Text = chuaGiaiQuyet.ToString();
			txtDangGQ.Text = dangGiaiQuyet.ToString();
			txtDaGQ.Text = daGiaiQuyet.ToString();
		}
		
		private void dtgrvTheoDoiYeuCau_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			UpdateSummary();
		}


	}

}
