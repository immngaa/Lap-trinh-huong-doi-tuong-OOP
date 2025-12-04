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
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
//using iText.Layout.Properties;
//using iText.IO.Font;
//using iText.Kernel.Font;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using PdfSharpCore.Pdf.Advanced;
using PdfSharpCore.Pdf;
using System.Xml.Linq;
using PdfSharpCore.Drawing;
using System.IO;


namespace Nhom03
{
    public partial class UC_BaoHanhBaoTri : UserControl
    {
        private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
        // Chuỗi kết nối với MySQL
        private readonly string connectionString = "Server=localhost;Port=3306;Database=cskh;Uid=root;Pwd=01072004;";

        public UC_BaoHanhBaoTri()
        {
            InitializeComponent();
            LoadData();
            dtgrv1.CellClick += DataGridView1_CellClick;
            btnTimKiem.Click += btnTimKiem_Click;
            //btnXuatFile.Click += btnXuatFile_Click;
        }

        private void LoadData()
        {
            string query = @"SELECT sp.MaSanPham, sp.TenSanPham, kh.TenKhachHang, kh.SoDienThoai, kh.Email, kh.DiaChi, 
                                    pbh.MaBaoHanh, pbh.MoTa AS MoTaBaoHanh, 
                                    lsb.NgayKichHoat AS NgayBatDau, lsb.NgayHetHan AS NgayKetThuc, lsb.TinhTrangBaoHanh
                             FROM sanpham sp
                             INNER JOIN phieubaohanh pbh ON sp.MaSanPham = pbh.MaSanPham
                             INNER JOIN lichsubaohanh lsb ON pbh.MaBaoHanh = lsb.MaBaoHanh
                             INNER JOIN khachhang kh ON lsb.MaKhachHang = kh.MaKhachHang";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgrv1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra người dùng có click vào hàng hợp lệ
            {
                DataGridViewRow row = dtgrv1.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtMaBaoHanh.Text = row.Cells["MaBaoHanh"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTaBaoHanh"].Value?.ToString();
                txtTinhTrangBaoHanh.Text = row.Cells["TinhTrangBaoHanh"].Value?.ToString();

                // Xử lý cho DateTimePicker
                if (DateTime.TryParse(row.Cells["NgayBatDau"].Value?.ToString(), out DateTime ngayBatDau))
                {
                    dtpNgayBatDau.Value = ngayBatDau;
                }
                else
                {
                    dtpNgayBatDau.Value = DateTime.Now;
                }

                if (DateTime.TryParse(row.Cells["NgayKetThuc"].Value?.ToString(), out DateTime ngayKetThuc))
                {
                    dtpNgayKetThuc.Value = ngayKetThuc;
                }
                else
                {
                    dtpNgayKetThuc.Value = DateTime.Now;
                }
            }
        }

        //private void btnXuatFile_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Đường dẫn lưu file PDF
        //        string filePath = @"C:\test\ThongTinBaoHanh.pdf";

        //        // Kiểm tra thư mục Download có tồn tại không, nếu không thì tạo mới
        //        if (!System.IO.Directory.Exists(@"C:\test"))
        //        {
        //            System.IO.Directory.CreateDirectory(@"C:\test");
        //        }

        //        using (PdfWriter writer = new PdfWriter(filePath))
        //        {
        //            using (PdfDocument pdf = new PdfDocument(writer))
        //            {
        //                Document document = new Document(pdf);

        //                // Thêm tiêu đề
        //                PdfFont boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);
        //                Paragraph title = new Paragraph("Thông Tin Bảo Hành")
        //                    .SetFont(boldFont)
        //                    .SetFontSize(14)
        //                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
        //                document.Add(title);

        //                // Thêm thông tin chi tiết
        //                document.Add(new Paragraph($"Mã sản phẩm: {txtMaSanPham.Text}"));
        //                document.Add(new Paragraph($"Tên sản phẩm: {txtTenSanPham.Text}"));
        //                document.Add(new Paragraph($"Tên khách hàng: {txtTenKhachHang.Text}"));
        //                document.Add(new Paragraph($"Số điện thoại: {txtSoDienThoai.Text}"));
        //                document.Add(new Paragraph($"Email: {txtEmail.Text}"));
        //                document.Add(new Paragraph($"Địa chỉ: {txtDiaChi.Text}"));
        //                document.Add(new Paragraph($"Mã bảo hành: {txtMaBaoHanh.Text}"));
        //                document.Add(new Paragraph($"Mô tả bảo hành: {txtMoTa.Text}"));
        //                document.Add(new Paragraph($"Ngày bắt đầu: {dtpNgayBatDau.Value:dd/MM/yyyy}"));
        //                document.Add(new Paragraph($"Ngày kết thúc: {dtpNgayKetThuc.Value:dd/MM/yyyy}"));
        //                document.Add(new Paragraph($"Tình trạng bảo hành: {txtTinhTrangBaoHanh.Text}"));

        //                document.Close();
        //            }
        //        }

        //        // Thông báo thành công
        //        MessageBox.Show($"Xuất file PDF thành công tại {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi xuất file PDF: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT sp.MaSanPham, sp.TenSanPham, kh.TenKhachHang, kh.SoDienThoai, kh.Email, kh.DiaChi, " +
                               "pbh.MaBaoHanh, pbh.MoTa AS MoTaBaoHanh, " +
                               "lsb.NgayKichHoat AS NgayBatDau, lsb.NgayHetHan AS NgayKetThuc, lsb.TinhTrangBaoHanh " +
                               "FROM sanpham sp " +
                               "INNER JOIN phieubaohanh pbh ON sp.MaSanPham = pbh.MaSanPham " +
                               "INNER JOIN lichsubaohanh lsb ON pbh.MaBaoHanh = lsb.MaBaoHanh " +
                               "INNER JOIN khachhang kh ON lsb.MaKhachHang = kh.MaKhachHang " +
                               "WHERE sp.MaSanPham = @MaSanPham";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaSanPham", txtTimKiem.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dtgrv1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			try
			{
				// Chuẩn bị nội dung báo cáo
				StringBuilder reportContent = new StringBuilder();
				reportContent.AppendLine("Thông tin bảo hành chi tiết của khách hàng");
				reportContent.AppendLine("\n--- Thông tin khách hàng ---\n");

				// Lấy dữ liệu từ các TextBox trong groupBox2
				string maSanPham = txtMaSanPham.Text;
				string tenSanPham = txtTenSanPham.Text;
				string tenKhachHang = txtTenKhachHang.Text;
				string soDienThoai = txtSoDienThoai.Text;
				string email = txtEmail.Text;
				string diaChi = txtDiaChi.Text;
				string maBaoHanh = txtMaBaoHanh.Text;
				string moTa = txtMoTa.Text;
				string ngayBatDau = dtpNgayBatDau.Value.ToString("yyyy-MM-dd");
				string ngayKetThuc = dtpNgayKetThuc.Value.ToString("yyyy-MM-dd");
				string tinhTrang = txtTinhTrangBaoHanh.Text;

				// Thêm thông tin vào nội dung báo cáo
				reportContent.AppendLine($"Mã sản phẩm: {maSanPham}");
				reportContent.AppendLine($"Tên sản phẩm: {tenSanPham}");
				reportContent.AppendLine($"Tên khách hàng: {tenKhachHang}");
				reportContent.AppendLine($"Số điện thoại: {soDienThoai}");
				reportContent.AppendLine($"Email: {email}");
				reportContent.AppendLine($"Địa chỉ: {diaChi}");
				reportContent.AppendLine($"Mã bảo hành: {maBaoHanh}");
				reportContent.AppendLine($"Mô tả: {moTa}");
				reportContent.AppendLine($"Ngày bắt đầu: {ngayBatDau}");
				reportContent.AppendLine($"Ngày kết thúc: {ngayKetThuc}");
				reportContent.AppendLine($"Tình trạng bảo hành: {tinhTrang}");

				// Tạo file PDF
				string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ThongTinBaoHanhKhachHang.pdf");
				CreatePDF(reportContent.ToString(), pdfFilePath);

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

		private void CreatePDF(string reportContent, string pdfFilePath)
		{
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);

			// Font
			XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
			XFont normalFont = new XFont("Arial", 12, XFontStyle.Regular);

			// Vẽ tiêu đề
			gfx.DrawString("Thông tin bảo hành chi tiết của khách hàng", titleFont, XBrushes.DarkBlue, new XRect(20, 20, page.Width - 40, 50), XStringFormats.TopLeft);

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

			// Lưu PDF
			document.Save(pdfFilePath);
		}
	}
}

