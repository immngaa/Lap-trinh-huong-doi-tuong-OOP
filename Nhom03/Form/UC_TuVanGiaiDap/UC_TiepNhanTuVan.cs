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
	public partial class UC_TiepNhanTuVan : UserControl
	{
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

		public UC_TiepNhanTuVan()
		{
			InitializeComponent();
		}
		private void ClearInputFields()
		{
			txtMaYeuCau.Clear();
			txtMaKH.Clear();
			txtMaNV.Clear();
			rtxtNoiDungYeuCau.Clear();
			dtpNgayGui.Value = DateTime.Now;
			cbbTrangThai.SelectedIndex = -1;
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

		private void UC_TiepNhanTuVan_Load(object sender, EventArgs e)
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXuLy_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra các ô nhập liệu không bị trống
				if (string.IsNullOrEmpty(txtMaKH.Text) ||
					string.IsNullOrEmpty(txtMaYeuCau.Text) ||
					string.IsNullOrEmpty(rtxtNoiDungYeuCau.Text) ||
					cbbTrangThai.SelectedIndex == -1)
				{
					MessageBox.Show("Vui lòng chọn thông tin tư vấn!");
					return;
				}

				// Tạo instance UC_XuLyTuVan với dữ liệu từ UC_TiepNhanTuVan
				UC_XuLyTuVan ucXuLyTuVan = new UC_XuLyTuVan(
					txtMaYeuCau.Text,
					txtMaKH.Text,
					cbbTrangThai.Text,
					rtxtNoiDungYeuCau.Text,
					dtpNgayGui.Value,
					txtMaNV.Text
				);

				// Chuyển sang UC_XuLyTuVan
				FormGiaoDienChinh parentForm = this.ParentForm as FormGiaoDienChinh;
				if (parentForm != null)
				{
					parentForm.LoadUserControl(ucXuLyTuVan);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

	}

}


