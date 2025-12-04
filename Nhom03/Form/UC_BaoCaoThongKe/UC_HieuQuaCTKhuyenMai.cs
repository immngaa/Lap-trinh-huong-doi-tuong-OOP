using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace Nhom03
{
    public partial class UC_HieuQuaCTKhuyenMai : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

        public UC_HieuQuaCTKhuyenMai()
        {
            InitializeComponent();
            LoadBangThongKeUuDai();  // Load data into DataGridView
            LoadChartHieuQuaUuDai(); // Load data into Chart
        }

        private void LoadBangThongKeUuDai()
        {
            try
            {
                string query = @"
                SELECT 
                    km.TenKhuyenMai AS TenChuongTrinh,
                    km.NgayBatDau,
                    km.NgayKetThuc,
                    COUNT(cthd.MaSanPham) AS SoLuongSanPhamBan,
                    SUM(cthd.TongTien) AS TongDoanhThu,
                    DATEDIFF(km.NgayKetThuc, km.NgayBatDau) + 1 AS SoNgayApDung,
                    SUM(cthd.TongTien) / (DATEDIFF(km.NgayKetThuc, km.NgayBatDau) + 1) AS HieuQua
                FROM KhuyenMai km
                LEFT JOIN chitiethoadon cthd ON km.MaKhuyenMai = cthd.MaKhuyenMai
                GROUP BY km.MaKhuyenMai
                ORDER BY TongDoanhThu DESC;";

                DataTable dataTable = ketNoi.ExecuteQuery(query);

                // Ensure there is data to display
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable; // Bind the data to DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị trong bảng thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear any existing data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartHieuQuaUuDai()
        {
            try
            {
                string query = @"
                SELECT 
                    km.TenKhuyenMai AS TenChuongTrinh,
                    SUM(cthd.TongTien) / (DATEDIFF(km.NgayKetThuc, km.NgayBatDau) + 1) AS HieuQua
                FROM KhuyenMai km
                LEFT JOIN chitiethoadon cthd ON km.MaKhuyenMai = cthd.MaKhuyenMai
                GROUP BY km.MaKhuyenMai
                ORDER BY HieuQua DESC;";

                DataTable dataTable = ketNoi.ExecuteQuery(query);

                // Clear previous chart data
                chart1.Series.Clear();
                var series = chart1.Series.Add("Hiệu quả chương trình");
                series.ChartType = SeriesChartType.Line;

                // Check if there is data for the chart
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string tenChuongTrinh = row["TenChuongTrinh"].ToString();

                        // Handle null values for "HieuQua"
                        decimal hieuQua = row["HieuQua"] != DBNull.Value ? Convert.ToDecimal(row["HieuQua"]) : 0;

                        series.Points.AddXY(tenChuongTrinh, hieuQua);
                    }

                    // Configure chart axes
                    chart1.ChartAreas[0].AxisX.Title = "Tên Chương Trình";
                    chart1.ChartAreas[0].AxisY.Title = "Hiệu Quả (Doanh Thu / Ngày)";
                    chart1.ChartAreas[0].AxisX.Interval = 1; // Ensure all labels are displayed
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị trong biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			try
			{
				// Chuẩn bị nội dung báo cáo
				StringBuilder reportContent = new StringBuilder();
				reportContent.AppendLine("Báo cáo thống kê hiệu quả chương trình khuyến mãi");
				reportContent.AppendLine("\n--- Bảng thống kê chi tiết ---\n");

				// Lấy dữ liệu từ bảng thống kê
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (!row.IsNewRow) // Loại bỏ hàng trống trong DataGridView
					{
						reportContent.AppendLine(
							$"Tên chương trình: {row.Cells["TenChuongTrinh"].Value} | " +
							$"Thời gian: {row.Cells["NgayBatDau"].Value} | " +
							$"Hiệu quả: {row.Cells["HieuQua"].Value}");
					}
				}

				// Chuẩn bị biểu đồ dưới dạng hình ảnh
				string chartFilePath = Path.Combine(Path.GetTempPath(), "chart.png");
				chart1.SaveImage(chartFilePath, ChartImageFormat.Png);

				// Tạo file PDF
				string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BaoCaoKhuyenMai.pdf");
				CreatePDFWithChart(reportContent.ToString(), chartFilePath, pdfFilePath);

				// Hiển thị thông báo và mở file PDF
				MessageBox.Show("Báo cáo đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = pdfFilePath,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi khi tạo báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CreatePDFWithChart(string reportContent, string chartFilePath, string pdfFilePath)
		{
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);

			// Font
			XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
			XFont normalFont = new XFont("Arial", 12, XFontStyle.Regular);

			// Vẽ tiêu đề
			gfx.DrawString("Báo cáo thống kê hiệu quả chương trình khuyến mãi", titleFont, XBrushes.DarkBlue, new XRect(20, 20, page.Width - 40, 50), XStringFormats.TopLeft);

			// Vẽ nội dung thống kê
			double yOffset = 80;
			foreach (var line in reportContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
			{
				gfx.DrawString(line, normalFont, XBrushes.Black, new XRect(20, yOffset, page.Width - 40, 20), XStringFormats.TopLeft);
				yOffset += 20;
			}

			// Thêm biểu đồ
			XImage chartImage = XImage.FromFile(chartFilePath);
			gfx.DrawImage(chartImage, 20, yOffset + 20, page.Width - 40, 200);

			// Lưu PDF
			document.Save(pdfFilePath);
		}
	}
}
