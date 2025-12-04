using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using Nhom03;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom03
{
	public partial class UC_PhanTichHVXHCuaKH : UserControl
	{
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

		public UC_PhanTichHVXHCuaKH()
		{
			InitializeComponent();
			LoadThuongHieu();
			LoadTenLoaiSP();
		}

		private void LoadThuongHieu()
		{
			try
			{
				// Câu truy vấn lấy tất cả các thương hiệu từ bảng sanpham
				string query = "SELECT DISTINCT ThuongHieu FROM sanpham WHERE ThuongHieu IS NOT NULL";

				// Thực thi câu truy vấn và lấy dữ liệu vào DataTable
				DataTable dt = ketNoi.ExecuteQuery(query);

				// Xóa các mục có sẵn trong ComboBox trước khi thêm mới
				cbbThuongHieu.Items.Clear();

				// Thêm các giá trị vào ComboBox
				foreach (DataRow row in dt.Rows)
				{
					cbbThuongHieu.Items.Add(row["ThuongHieu"].ToString());
				}

				// Tự động chọn giá trị đầu tiên trong ComboBox nếu có ít nhất một giá trị
				if (cbbThuongHieu.Items.Count > 0)
				{
					cbbThuongHieu.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tải danh sách thương hiệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadTenLoaiSP()
		{
			try
			{
				// Câu truy vấn lấy tất cả các loại sản phẩm từ bảng loaisp
				string query = "SELECT DISTINCT TenLoaiSP FROM loaisp WHERE TenLoaiSP IS NOT NULL";

				// Thực thi câu truy vấn và lấy dữ liệu vào DataTable
				DataTable dt = ketNoi.ExecuteQuery(query);

				// Xóa các mục có sẵn trong ComboBox trước khi thêm mới
				cbbTenLoaiSP.Items.Clear();

				// Thêm các giá trị vào ComboBox
				foreach (DataRow row in dt.Rows)
				{
					cbbTenLoaiSP.Items.Add(row["TenLoaiSP"].ToString());
				}

				// Tự động chọn giá trị đầu tiên trong ComboBox nếu có ít nhất một giá trị
				if (cbbTenLoaiSP.Items.Count > 0)
				{
					cbbTenLoaiSP.SelectedIndex = 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tải danh sách loại sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	

		private void CreatePDF(string result, string pdfFilePath)
		{
			PdfDocument doc = new PdfDocument();
			PdfPage page = doc.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);

			XFont fontTitle = new XFont("Arial", 16, XFontStyle.Bold);
			XFont fontNormal = new XFont("Arial", 12, XFontStyle.Regular);

			// In tiêu đề
			gfx.DrawString("Thống kê Sản Phẩm và Thương Hiệu Bán Chạy", fontTitle, XBrushes.DarkBlue, new XPoint(20, 20));

			// In nội dung bảng thống kê
			double yPosition = 60;
			string[] lines = result.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			foreach (var line in lines)
			{
				gfx.DrawString(line, fontNormal, XBrushes.Black, new XPoint(20, yPosition));
				yPosition += fontNormal.GetHeight();
			}

			// Lưu báo cáo vào file
			doc.Save(pdfFilePath);
		}

		private void dtgrvTKXuHuongMua_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			try
			{
				// Câu truy vấn SQL với tham số
				string query = @"
        SELECT 
            nhomkh.TenNhomKH AS `Tên nhóm KH`,
            DATE(hd.NgayXuatHoaDon) AS `Ngày`,
            lsp.TenLoaiSP AS `Tên loại SP`,
            sp.ThuongHieu AS `Tên thương hiệu`,
            SUM(ct.SoLuong) AS `Tổng số lượng`
        FROM 
            chitiethoadon ct
        JOIN 
            hoadon hd ON ct.MaHoaDon = hd.MaHoaDon
        JOIN 
            khachhang kh ON hd.MaKhachHang = kh.MaKhachHang
        JOIN 
            sanpham sp ON ct.MaSanPham = sp.MaSanPham
        JOIN 
            loaisp lsp ON lsp.MaLoaiSP = sp.MaPhanLoai
        JOIN 
            nhomkh ON nhomkh.MaNhomKH = kh.MaNhomKH
        WHERE 
            1 = 1
        AND (@TenLoaiSP IS NULL OR sp.MaPhanLoai = @TenLoaiSP)
        AND (@TenNhomKH IS NULL OR nhomkh.TenNhomKH = @TenNhomKH)
        AND (@ThuongHieu IS NULL OR sp.ThuongHieu = @ThuongHieu)
        AND (@NgayBatDau IS NULL OR hd.NgayXuatHoaDon >= @NgayBatDau)
        AND (@NgayKetThuc IS NULL OR hd.NgayXuatHoaDon <= @NgayKetThuc)
        GROUP BY
            nhomkh.TenNhomKH, DATE(hd.NgayXuatHoaDon), lsp.TenLoaiSP, sp.ThuongHieu
        ORDER BY 
            DATE(hd.NgayXuatHoaDon);";

				// Khởi tạo kết nối MySQL và câu lệnh
				MySqlConnection conn = ketNoi.GetConnection(); // Lấy kết nối từ lớp KetNoiCSDL của bạn
				MySqlCommand cmd = new MySqlCommand(query, conn);

				// Thêm tham số vào câu lệnh SQL
				cmd.Parameters.AddWithValue("@TenLoaiSP", cbTenLoaiSP.Checked ? cbbTenLoaiSP.Text : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@TenNhomKH", cbTenNhomKH.Checked ? cbbTenNhomKH.Text : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@ThuongHieu", cbThuongHieu.Checked ? cbbThuongHieu.Text : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@NgayBatDau", dptNgayBD.Value != null ? (object)dptNgayBD.Value : DBNull.Value);
				cmd.Parameters.AddWithValue("@NgayKetThuc", dptNgayKT.Value != null ? (object)dptNgayKT.Value : DBNull.Value);

				// Mở kết nối và thực thi câu lệnh
				conn.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dtgrvTKXuHuongMua.DataSource = dt;

				// Đóng kết nối
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThongKe_Click_1(object sender, EventArgs e)
		{
			try
			{
				// Câu truy vấn SQL để lấy dữ liệu thống kê
				string query = @"
        SELECT 
            lsp.TenLoaiSP AS `Tên loại sản phẩm`,
            sp.ThuongHieu AS `Tên thương hiệu`,
            SUM(ct.SoLuong) AS `Tổng số lượng`
        FROM 
            chitiethoadon ct
        JOIN 
            hoadon hd ON ct.MaHoaDon = hd.MaHoaDon
        JOIN 
            sanpham sp ON ct.MaSanPham = sp.MaSanPham
        JOIN 
            loaisp lsp ON sp.MaPhanLoai = lsp.MaLoaiSP
        WHERE 
            1 = 1
            AND (@TenLoaiSP IS NULL OR lsp.TenLoaiSP = @TenLoaiSP)
            AND (@ThuongHieu IS NULL OR sp.ThuongHieu = @ThuongHieu)
            AND (@NgayBatDau IS NULL OR hd.NgayXuatHoaDon >= @NgayBatDau)
            AND (@NgayKetThuc IS NULL OR hd.NgayXuatHoaDon <= @NgayKetThuc)
        GROUP BY 
            lsp.TenLoaiSP, sp.ThuongHieu
        ORDER BY 
            `Tổng số lượng` DESC;
        ";

				// Khởi tạo kết nối MySQL và câu lệnh
				MySqlConnection conn = ketNoi.GetConnection();
				MySqlCommand cmd = new MySqlCommand(query, conn);

				// Thêm tham số vào câu lệnh SQL
				cmd.Parameters.AddWithValue("@TenLoaiSP", cbTenLoaiSP.Checked ? cbbTenLoaiSP.Text : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@ThuongHieu", cbThuongHieu.Checked ? cbbThuongHieu.Text : (object)DBNull.Value);
				cmd.Parameters.AddWithValue("@NgayBatDau", dptNgayBD.Value != null ? (object)dptNgayBD.Value : DBNull.Value);
				cmd.Parameters.AddWithValue("@NgayKetThuc", dptNgayKT.Value != null ? (object)dptNgayKT.Value : DBNull.Value);

				// Mở kết nối và thực thi câu lệnh
				conn.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				conn.Close();

				// Kiểm tra nếu có dữ liệu
				if (dt.Rows.Count > 0)
				{
					// Chuẩn bị nội dung báo cáo
					StringBuilder result = new StringBuilder();
					result.AppendLine("Thống kê sản phẩm và thương hiệu bán chạy\n");
					result.AppendLine("Bảng thống kê:\n");

					// Tạo bảng thống kê trong PDF
					result.AppendLine("Tên loại sản phẩm | Tên thương hiệu | Tổng số lượng");
					foreach (DataRow row in dt.Rows)
					{
						result.AppendLine($"{row["Tên loại sản phẩm"]} | {row["Tên thương hiệu"]} | {row["Tổng số lượng"]}");
					}

					// Tạo kết luận về sản phẩm và thương hiệu được mua nhiều nhất
					result.AppendLine("\nKết luận:");
					result.AppendLine("- Tên loại sản phẩm được mua nhiều nhất và thương hiệu phổ biến nhất: ");
					result.AppendLine($"   {dt.Rows[0]["Tên loại sản phẩm"]} và {dt.Rows[0]["Tên thương hiệu"]}");

					// Tạo báo cáo PDF
					string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ThongKeSanPhamThuongHieu.pdf");
					CreatePDF(result.ToString(), pdfFilePath);

					// Mở file PDF sau khi tạo xong
					System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
					{
						FileName = pdfFilePath,
						UseShellExecute = true
					});
				}
				else
				{
					MessageBox.Show("Không có dữ liệu phù hợp với yêu cầu tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
