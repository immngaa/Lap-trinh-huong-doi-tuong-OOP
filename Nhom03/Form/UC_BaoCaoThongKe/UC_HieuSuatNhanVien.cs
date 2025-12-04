using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom03
{
	public partial class UC_HieuSuatNhanVien : UserControl
	{
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

		public UC_HieuSuatNhanVien()
		{
			InitializeComponent();
		}

		// Method to load data with a date filter
		private void LoadDataGridView(DateTime startDate, DateTime endDate)
		{
			// Cập nhật câu truy vấn để lấy thêm mã nhân viên, số điện thoại, và email
			string query = $@"
        SELECT 
            nv.MaNhanVien,
            nv.HoTen AS TenNhanVien,
            nv.SoDienThoai AS SoDienThoai,
            nv.Email,
            COUNT(ls.MaKhachHang) AS SoLanTuVan
        FROM lichsutuvan AS ls
        JOIN nhanvienhotro AS nv ON ls.MaNhanVien = nv.MaNhanVien
        WHERE ls.ThoiGian >= '{startDate:yyyy-MM-dd}' AND ls.ThoiGian <= '{endDate:yyyy-MM-dd}'
        GROUP BY nv.MaNhanVien, nv.HoTen, nv.SoDienThoai, nv.Email
        ORDER BY SoLanTuVan DESC
    ";

			try
			{
				// Execute the query and get the result in a DataTable
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				// Bind the DataTable to the DataGridView
				dtgrvHieuSuatNV.DataSource = dataTable;

				// Optional: Customize column headers if necessary
				dtgrvHieuSuatNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
				dtgrvHieuSuatNV.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
				dtgrvHieuSuatNV.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
				dtgrvHieuSuatNV.Columns["Email"].HeaderText = "Email";
				dtgrvHieuSuatNV.Columns["SoLanTuVan"].HeaderText = "Số Lần Tư Vấn";
			}
			catch (Exception ex)
			{
				// Show error message if something goes wrong
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Method to create PDF report with a table
		private void CreatePDF(string result, string pdfFilePath)
		{
			PdfDocument doc = new PdfDocument();
			PdfPage page = doc.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);

			XFont fontTitle = new XFont("Arial", 16, XFontStyle.Bold);
			XFont fontNormal = new XFont("Arial", 12, XFontStyle.Regular);

			double titleWidth = gfx.MeasureString("Thống kê số lần tư vấn của nhân viên", fontTitle).Width;
			double contentWidth = gfx.MeasureString(result, fontNormal).Width;

			gfx.DrawString("Thống kê số lần tư vấn của nhân viên", fontTitle, XBrushes.DarkBlue, new XPoint((page.Width - titleWidth) / 2, 20));

			// Tách chuỗi kết quả thành các dòng để in ra từng dòng
			string[] lines = result.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

			double yPosition = 60;
			foreach (var line in lines)
			{
				gfx.DrawString(line, fontNormal, XBrushes.Black, new XPoint(20, yPosition));
				yPosition += fontNormal.GetHeight();
			}

			doc.Save(pdfFilePath);
		}


		// Method to get statistics for the selected date range
		private void GetThongKeData(DateTime startDate, DateTime endDate)
		{
			string query = $@"
        SELECT 
            nv.MaNhanVien, nv.HoTen AS TenNhanVien,
            COUNT(ls.MaKhachHang) AS SoLanTuVan
        FROM lichsutuvan AS ls
        JOIN nhanvienhotro AS nv ON ls.MaNhanVien = nv.MaNhanVien
        WHERE ls.ThoiGian >= '{startDate:yyyy-MM-dd}' AND ls.ThoiGian <= '{endDate:yyyy-MM-dd}'
        GROUP BY nv.MaNhanVien, nv.HoTen
        ORDER BY SoLanTuVan DESC
    ";

			try
			{
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				if (dataTable.Rows.Count > 0)
				{
					// Tạo báo cáo kết quả
					string result = "Thống kê số lần tư vấn của nhân viên trong khoảng thời gian từ " +
									$"{startDate:dd/MM/yyyy} đến {endDate:dd/MM/yyyy}:\n\n";

					// In ra thông tin cho từng nhân viên
					foreach (DataRow row in dataTable.Rows)
					{
						string maNhanVien = row["MaNhanVien"].ToString();
						string tenNhanVien = row["TenNhanVien"].ToString();
						int soLanTuVan = Convert.ToInt32(row["SoLanTuVan"]);

						result += $"Nhân viên: {tenNhanVien} (Mã NV: {maNhanVien}) đã tư vấn {soLanTuVan} lần.\n";
					}

					// Lấy 3 người hoàn thành tốt nhất (3 người có số lần tư vấn cao nhất)
					result += "\n3 người hoàn thành tốt nhất:\n";
					int topCount = Math.Min(3, dataTable.Rows.Count); // Đảm bảo có ít nhất 3 người
					for (int i = 0; i < topCount; i++)
					{
						DataRow row = dataTable.Rows[i];
						result += $"{i + 1}. {row["TenNhanVien"]} (Mã NV: {row["MaNhanVien"]}) - {row["SoLanTuVan"]} lần tư vấn\n";
					}

					// Lấy 3 người cần cải thiện nhất (3 người có số lần tư vấn thấp nhất)
					result += "\n3 nhân viên cần cố gắng hơn:\n";
					int bottomCount = Math.Min(3, dataTable.Rows.Count); // Đảm bảo có ít nhất 3 người
					for (int i = dataTable.Rows.Count - 1; i >= dataTable.Rows.Count - bottomCount; i--)
					{
						DataRow row = dataTable.Rows[i];
						result += $"{dataTable.Rows.Count - i}. {row["TenNhanVien"]} (Mã NV: {row["MaNhanVien"]}) - {row["SoLanTuVan"]} lần tư vấn\n";
					}

					// Hiển thị báo cáo và cho phép in hoặc lưu PDF
					ShowThongKeAndPrint(result);
				}
				else
				{
					MessageBox.Show("Không có dữ liệu trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		// Method to display statistics and allow printing or PDF generation
		private void ShowThongKeAndPrint(string result)
		{
			string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ThongKeHieuSuatNV.pdf");

			CreatePDF(result, pdfFilePath);

			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
			{
				FileName = pdfFilePath,
				UseShellExecute = true
			});
		}

		// Method to print the statistics
		private void PrintThongKe(string result)
		{
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrintPage += (sender, e) =>
			{
				e.Graphics.DrawString(result, new Font("Arial", 12), Brushes.Black, 10, 10);
			};

			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = printDoc;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDoc.Print();
			}
		}


		// Load event handler for the UserControl
		private void UC_HieuSuatNV_Load(object sender, EventArgs e)
		{
			LoadDataGridView(DateTime.MinValue, DateTime.MaxValue);  // Load all data by default
		}
		

		// Method to generate a chart
		private void GetThongKeDataForChart(DateTime startDate, DateTime endDate)
		{
			string query = $@"
        SELECT 
            nv.HoTen AS TenNhanVien,
            COUNT(ls.MaKhachHang) AS SoLanTuVan
        FROM lichsutuvan AS ls
        JOIN nhanvienhotro AS nv ON ls.MaNhanVien = nv.MaNhanVien
        WHERE ls.ThoiGian >= '{startDate:yyyy-MM-dd}' AND ls.ThoiGian <= '{endDate:yyyy-MM-dd}'
        GROUP BY nv.HoTen
        ORDER BY SoLanTuVan DESC
    ";

			try
			{
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				if (dataTable.Rows.Count > 0)
				{
					// Truyền DataTable vào ChartFormHieuSuatNV
					ChartFormHieuSuatNV chartForm = new ChartFormHieuSuatNV(dataTable);
					chartForm.ShowDialog(); // Hiển thị biểu đồ trong một form modal
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTraCuu_Click_1(object sender, EventArgs e)
		{
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			LoadDataGridView(startDate, endDate);
		}

		private void btnTaoBieuDo_Click_1(object sender, EventArgs e)
		{
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			GetThongKeDataForChart(startDate, endDate);
		}

		private void btnThongKe_Click_1(object sender, EventArgs e)
		{
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			GetThongKeData(startDate, endDate);
		}
	}
}
