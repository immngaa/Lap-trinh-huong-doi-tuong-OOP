using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

using MySql.Data.MySqlClient; // Thư viện MySQL Connector

namespace Nhom03
{
    public partial class UC_ThongKeDoanhThu : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

        public UC_ThongKeDoanhThu()
        {
            InitializeComponent();
            LoadBangDoanhThu();
            LoadChiTietSanPham();
            LoadChart();
        }

        private void LoadBangDoanhThu()
        {
            try
            {
                string query = @"
                    SELECT 
                        DATE(NgayXuatHoaDon) AS Ngay,
                        COUNT(cthd.MaSanPham) AS SoLuongSanPham,
                        SUM(cthd.TongTien) AS TongDoanhThu,
                        '' AS GhiChu
                    FROM hoadon hd
                    JOIN chitiethoadon cthd ON hd.MaHoaDon = cthd.MaHoaDon
                    WHERE hd.TinhTrangThanhToan = 'Đã thanh toán'
                    GROUP BY DATE(NgayXuatHoaDon)
                    ORDER BY Ngay";

                DataTable dataTable = ketNoi.ExecuteQuery(query);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào bảng doanh thu: " + ex.Message);
            }
        }

        private void LoadChiTietSanPham()
        {
            try
            {
                string query = @"
                    SELECT 
                        sp.TenSanPham,
                        SUM(cthd.SoLuong) AS SoLuongBan,
                        SUM(cthd.TongTien) AS DoanhThu
                    FROM chitiethoadon cthd
                    JOIN sanpham sp ON cthd.MaSanPham = sp.MaSanPham
                    GROUP BY sp.TenSanPham
                    ORDER BY DoanhThu DESC";

                DataTable dataTable = ketNoi.ExecuteQuery(query);
                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào bảng chi tiết sản phẩm: " + ex.Message);
            }
        }

        private void LoadChart()
        {
            try
            {
                string query = @"
                    SELECT 
                        DATE(NgayXuatHoaDon) AS Ngay,
                        SUM(TongTien) AS TongDoanhThu
                    FROM hoadon
                    WHERE TinhTrangThanhToan = 'Đã thanh toán'
                    GROUP BY DATE(NgayXuatHoaDon)
                    ORDER BY Ngay";

                DataTable dataTable = ketNoi.ExecuteQuery(query);

                chart1.Series.Clear();
                var series = chart1.Series.Add("Doanh thu");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["Ngay"]);
                    decimal revenue = Convert.ToDecimal(row["TongDoanhThu"]);
                    series.Points.AddXY(date.ToString("dd/MM/yyyy"), revenue);
                }

                chart1.ChartAreas[0].AxisX.Title = "Ngày";
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào biểu đồ: " + ex.Message);
            }
        }

		private void btnXuatFile_Click(object sender, EventArgs e)
		{
				try
				{
					// Chuẩn bị nội dung báo cáo
					StringBuilder reportContent = new StringBuilder();
					reportContent.AppendLine("Báo cáo thống kê doanh thu");
					reportContent.AppendLine("\n--- Bảng thống kê doanh thu ---\n");

					// Thêm dữ liệu từ DataGridView (bảng thống kê doanh thu)
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						if (!row.IsNewRow)
						{
							reportContent.AppendLine(
								$"Ngày: {row.Cells["Ngay"].Value} | " +
								$"Doanh thu: {row.Cells["TongDoanhThu"].Value}");
						}
					}

					

					// Chuẩn bị biểu đồ dưới dạng hình ảnh
					string chartFilePath = Path.Combine(Path.GetTempPath(), "chart.png");
					chart1.SaveImage(chartFilePath, ChartImageFormat.Png);

					// Tạo file PDF
					string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BaoCaoDoanhThu.pdf");
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
				gfx.DrawString("Báo cáo thống kê doanh thu", titleFont, XBrushes.DarkBlue, new XRect(20, 20, page.Width - 40, 50), XStringFormats.TopLeft);

				// Vẽ nội dung thống kê
				double yOffset = 80;
				foreach (var line in reportContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
				{
					gfx.DrawString(line, normalFont, XBrushes.Black, new XRect(20, yOffset, page.Width - 40, 20), XStringFormats.TopLeft);
					yOffset += 20;

					// Nếu vượt quá chiều cao trang, thêm trang mới
					if (yOffset > page.Height - 50)
					{
						page = document.AddPage();
						gfx = XGraphics.FromPdfPage(page);
						yOffset = 20;
					}
				}

				// Thêm biểu đồ
				if (File.Exists(chartFilePath))
				{
					XImage chartImage = XImage.FromFile(chartFilePath);
					gfx.DrawImage(chartImage, 20, yOffset + 20, page.Width - 40, 200);
				}

				// Lưu PDF
				document.Save(pdfFilePath);
			}
		}

	}

