using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom03
{
	public partial class UC_MucDoHaiLongCuaKH : UserControl
	{
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();

		public UC_MucDoHaiLongCuaKH()
		{
			InitializeComponent();
		}

		// Method to load data with a date filter
		private void LoadDataGridView(DateTime startDate, DateTime endDate)
		{
			// Modify the query to filter by date range
			string query = $"SELECT * FROM phanhoi WHERE ngayphanhoi >= '{startDate:yyyy-MM-dd}' AND ngayphanhoi <= '{endDate:yyyy-MM-dd}'";

			try
			{
				// Execute the query and get the result in a DataTable
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				// Bind the DataTable to the DataGridView
				dtgrvTKHaiLong.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				// Show error message if something goes wrong
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Method to create PDF
		private void CreatePDF(string result, string pdfFilePath)
		{
			// Create a new PDF document
			PdfDocument doc = new PdfDocument();
			PdfPage page = doc.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);

			// Set fonts for title and normal text
			XFont fontTitle = new XFont("Arial", 16, XFontStyle.Bold);
			XFont fontNormal = new XFont("Arial", 12, XFontStyle.Regular);

			// Calculate the width of the title and content to center them
			double titleWidth = gfx.MeasureString("Thống kê mức độ hài lòng của khách hàng", fontTitle).Width;
			double contentWidth = gfx.MeasureString(result, fontNormal).Width;

			// Draw the title centered at the top
			gfx.DrawString("Thống kê mức độ hài lòng của khách hàng", fontTitle, XBrushes.DarkBlue, new XPoint((page.Width - titleWidth) / 2, 20));

			// Split the result into individual lines
			string[] lines = result.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

			// Draw each line, aligned to the left
			double yPosition = 60; // Starting vertical position for the first line
			foreach (var line in lines)
			{
				// Draw the line on the PDF, aligned to the left
				gfx.DrawString(line, fontNormal, XBrushes.Black, new XPoint(20, yPosition));

				// Increment the Y position for the next line
				yPosition += fontNormal.GetHeight();
			}

			// Save the PDF to the file
			doc.Save(pdfFilePath);
		}


		// Method to get statistics of ratings (5, 4, 3, 2, 1 stars)
		private void GetThongKeData(DateTime startDate, DateTime endDate)
		{
			// SQL query to count ratings by star level
			string query = $@"
                SELECT 
                    SUM(CASE WHEN mucdohailong = 5 THEN 1 ELSE 0 END) AS Rating5,
                    SUM(CASE WHEN mucdohailong = 4 THEN 1 ELSE 0 END) AS Rating4,
                    SUM(CASE WHEN mucdohailong = 3 THEN 1 ELSE 0 END) AS Rating3,
                    SUM(CASE WHEN mucdohailong = 2 THEN 1 ELSE 0 END) AS Rating2,
                    SUM(CASE WHEN mucdohailong = 1 THEN 1 ELSE 0 END) AS Rating1
                FROM phanhoi 
                WHERE ngayphanhoi >= '{startDate:yyyy-MM-dd}' AND ngayphanhoi <= '{endDate:yyyy-MM-dd}'";

			try
			{
				// Execute the query to get the statistics
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				if (dataTable.Rows.Count > 0)
				{
					var row = dataTable.Rows[0];
					int rating5 = Convert.ToInt32(row["Rating5"]);
					int rating4 = Convert.ToInt32(row["Rating4"]);
					int rating3 = Convert.ToInt32(row["Rating3"]);
					int rating2 = Convert.ToInt32(row["Rating2"]);
					int rating1 = Convert.ToInt32(row["Rating1"]);

					// Display the statistics
					string result = $@"
                    Thống kê trong khoảng thời gian từ {startDate:dd/MM/yyyy} đến {endDate:dd/MM/yyyy}:


					 - Đánh giá 5 sao có: {rating5} lượt
					 - Đánh giá 4 sao có: {rating4} lượt
					 - Đánh giá 3 sao có: {rating3} lượt
					 - Đánh giá 2 sao có: {rating2} lượt
					 - Đánh giá 1 sao có: {rating1} lượt


                    ";

					// Show statistics and allow for PDF generation
					ShowThongKeAndPrint(result);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Method to display statistics and allow printing
		private void ShowThongKeAndPrint(string result)
		{
			// Define the file path for the PDF
			string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ThongKemucDoHaiLong.pdf");

			// Create PDF
			CreatePDF(result, pdfFilePath);

			// Open the generated PDF in the default PDF viewer
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
			{
				FileName = pdfFilePath,
				UseShellExecute = true
			});
		}

		// Method to print the statistics
		private void PrintThongKe(string result)
		{
			// Create a print document
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrintPage += (sender, e) =>
			{
				// Set the text to be printed
				e.Graphics.DrawString(result, new Font("Arial", 12), Brushes.Black, 10, 10);
			};

			// Show the print dialog
			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = printDoc;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDoc.Print();
			}
		}

		// Load event handler for the UserControl
		private void UC_MucDoHaiLongCuaKH_Load(object sender, EventArgs e)
		{
			// Initial data load with all available records (optional)
			LoadDataGridView(DateTime.MinValue, DateTime.MaxValue);
		}

		// Event handler for the tra cứu (lookup) button
		private void btnThongKe_Click(object sender, EventArgs e)
		{
			// Get the start and end dates from the DateTimePickers
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			// Check if the start date is after the end date
			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Exit the method if the dates are invalid
			}

			// Call the method to get statistics with the selected date range
			GetThongKeData(startDate, endDate);
		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			// Get the start and end dates from the DateTimePickers
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			// Check if the start date is after the end date
			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Exit the method if the dates are invalid
			}

			// Call the method to load data with the selected date range
			LoadDataGridView(startDate, endDate);
		}
		private void btnTaoBieuDo_Click(object sender, EventArgs e)
		{
			// Lấy ngày bắt đầu và ngày kết thúc từ DateTimePickers
			DateTime startDate = dtpNgayBĐ.Value;
			DateTime endDate = dtpNgayKT.Value;

			// Kiểm tra xem ngày bắt đầu có lớn hơn ngày kết thúc không
			if (startDate > endDate)
			{
				MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc. Vui lòng chọn lại ngày.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Thoát nếu ngày không hợp lệ
			}

			// Gọi phương thức lấy dữ liệu thống kê với khoảng thời gian đã chọn
			GetThongKeDataForChart(startDate, endDate);
		}

		private void GetThongKeDataForChart(DateTime startDate, DateTime endDate)
		{
			// Truy vấn SQL để đếm số lượng đánh giá theo từng mức sao
			string query = $@"
    SELECT 
        SUM(CASE WHEN mucdohailong = 5 THEN 1 ELSE 0 END) AS Rating5,
        SUM(CASE WHEN mucdohailong = 4 THEN 1 ELSE 0 END) AS Rating4,
        SUM(CASE WHEN mucdohailong = 3 THEN 1 ELSE 0 END) AS Rating3,
        SUM(CASE WHEN mucdohailong = 2 THEN 1 ELSE 0 END) AS Rating2,
        SUM(CASE WHEN mucdohailong = 1 THEN 1 ELSE 0 END) AS Rating1
    FROM phanhoi 
    WHERE ngayphanhoi >= '{startDate:yyyy-MM-dd}' AND ngayphanhoi <= '{endDate:yyyy-MM-dd}'";

			try
			{
				// Thực thi truy vấn và lấy kết quả
				DataTable dataTable = ketNoi.ExecuteQuery(query);

				if (dataTable.Rows.Count > 0)
				{
					var row = dataTable.Rows[0];
					int rating5 = Convert.ToInt32(row["Rating5"]);
					int rating4 = Convert.ToInt32(row["Rating4"]);
					int rating3 = Convert.ToInt32(row["Rating3"]);
					int rating2 = Convert.ToInt32(row["Rating2"]);
					int rating1 = Convert.ToInt32(row["Rating1"]);

					// Mở form biểu đồ và truyền dữ liệu thống kê vào
					ChartFormMucDoHaiLong chartForm = new ChartFormMucDoHaiLong(rating1, rating2, rating3, rating4, rating5);
					chartForm.ShowDialog(); // Dùng ShowDialog nếu muốn form chặn thao tác cho đến khi đóng
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





	}
}
