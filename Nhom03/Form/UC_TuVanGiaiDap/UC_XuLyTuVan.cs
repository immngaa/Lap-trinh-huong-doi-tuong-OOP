using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Nhom03
{
	public partial class UC_XuLyTuVan : UserControl
	{
		private readonly KetNoiCSDL ketNoi = new KetNoiCSDL();
		public UC_XuLyTuVan(string maYeuCau, string maKH, string trangThai, string noiDungYeuCau, DateTime ngayGui, string maNV)
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

		public UC_XuLyTuVan()
		{
		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT * FROM sanpham WHERE 1=1";

				// Lọc theo mã phân loại
				if (cbMaPhanLoai.Checked && !string.IsNullOrEmpty(cbbMaLoaiSP.Text))
				{
					query += $" AND MaPhanLoai = '{cbbMaLoaiSP.Text}'";
				}

				// Lọc theo tên sản phẩm
				if (cbTenSP.Checked && !string.IsNullOrEmpty(txtTenSP.Text))
				{
					string keyword = txtTenSP.Text.ToLower(); // Chuyển từ khóa tìm kiếm sang chữ thường
					query += $" AND LOWER(TenSanPham) LIKE '%{keyword}%'";
				}
				// Lọc theo thương hiệu
				if (cbThuongHieu.Checked && !string.IsNullOrEmpty(txtThuongHieu.Text))
				{
					string keyword1 = txtThuongHieu.Text.ToLower();
					query += $" AND LOWER(ThuongHieu) LIKE '%{keyword1}%'";
				}

				// Lọc theo ngân sách
				if (cbNganSach.Checked)
				{
					int giaMin = 0, giaMax = int.MaxValue; // Mặc định nếu rỗng
					if (!string.IsNullOrEmpty(txtGiaMin.Text))
					{
						int.TryParse(txtGiaMin.Text, out giaMin); // Nếu không nhập, giá trị mặc định là 0
					}
					if (!string.IsNullOrEmpty(txtGiaMax.Text))
					{
						int.TryParse(txtGiaMax.Text, out giaMax); // Nếu không nhập, giá trị mặc định là Max
					}
					query += $" AND Gia BETWEEN {giaMin} AND {giaMax}";
				}


				// Thực thi câu truy vấn và hiển thị kết quả
				DataTable dt = ketNoi.ExecuteQuery(query);
				dtgrvSanPhamPhuHop.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnSaoChep_Click(object sender, EventArgs e)
		{
			try
			{
				if (dtgrvSanPhamPhuHop.Rows.Count > 0)
				{
					// Tạo đối tượng StringBuilder để chứa dữ liệu
					StringBuilder sb = new StringBuilder();

					// Thêm tiêu đề cột
					foreach (DataGridViewColumn column in dtgrvSanPhamPhuHop.Columns)
					{
						sb.Append(column.HeaderText + "\t");
					}
					sb.AppendLine();

					// Thêm dữ liệu từng dòng
					foreach (DataGridViewRow row in dtgrvSanPhamPhuHop.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							sb.Append(cell.Value?.ToString() + "\t");
						}
						sb.AppendLine();
					}

					// Sao chép vào Clipboard
					Clipboard.SetText(sb.ToString());
					MessageBox.Show("Dữ liệu đã được sao chép vào Clipboard!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Không có dữ liệu để sao chép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi sao chép dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDan_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra xem có dữ liệu trong Clipboard không
				if (Clipboard.ContainsText())
				{
					// Lấy dữ liệu từ clipboard
					string clipboardData = Clipboard.GetText();

					// Xóa nội dung hiện tại trong RichTextBox
					rtxtNoiDung.Clear();

					// Tạo Graphics từ RichTextBox để vẽ
					Graphics g = rtxtNoiDung.CreateGraphics();
					Font font = new Font("Arial", 10);
					Brush brush = Brushes.Black;

					// Các tham số để vẽ bảng
					int startX = 10;
					int startY = 10;
					int rowHeight = 25;
					int colWidth = 100;
					int numberOfColumns = 6;  // Bảng có 6 cột
					int lineWidth = 2;  // Độ dày của đường kẻ

					// Tạo StringFormat để căn giữa văn bản trong các ô
					StringFormat stringFormat = new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					};

					// Tách dữ liệu thành các dòng
					string[] rows = clipboardData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

					// Vẽ từng dòng dữ liệu
					for (int i = 0; i < rows.Length; i++)
					{
						string[] cells = rows[i].Split('\t');

						// Đảm bảo số ô trong mỗi dòng bằng với số cột
						string[] formattedCells = new string[numberOfColumns];
						for (int j = 0; j < numberOfColumns; j++)
						{
							formattedCells[j] = j < cells.Length ? cells[j] : ""; // Điền dữ liệu hoặc để trống
						}

						// Vẽ từng ô trong dòng
						for (int j = 0; j < numberOfColumns; j++)
						{
							// Tính toán vị trí của mỗi ô
							Rectangle cellRect = new Rectangle(startX + j * colWidth, startY + i * rowHeight, colWidth, rowHeight);

							// Vẽ đường viền của ô
							g.DrawRectangle(new Pen(Brushes.Black, lineWidth), cellRect);

							// Vẽ văn bản vào ô (căn giữa)
							g.DrawString(formattedCells[j], font, brush, cellRect, stringFormat);
						}
					}

					MessageBox.Show("Dữ liệu đã được dán và vẽ thành bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Không có dữ liệu trong Clipboard để dán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi dán và vẽ bảng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnGui_Click(object sender, EventArgs e)
		{
			// Predefined sender's email address and password (use actual values in production)
			string from = "oop20241@gmail.com"; // Sender's email address (should be preconfigured)
			string pass = "20241oop"; // Sender's email password
			string to = txtDen.Text.Trim(); // Recipient's email address
			string content = rtxtNoiDung.Text; // Email content
			string subject = txtChuDe.Text.Trim(); // Subject input by user

			// Check if the recipient's email is empty
			if (string.IsNullOrEmpty(to))
			{
				MessageBox.Show("Email người nhận không thể trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if the subject is empty
			if (string.IsNullOrEmpty(subject))
			{
				MessageBox.Show("Chủ đề không thể trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Create a new MailMessage object
			MailMessage mail = new MailMessage();
			mail.From = new MailAddress(from); // Set the sender's email
			mail.To.Add(to); // Set the recipient's email
			mail.Subject = subject; // Use the subject entered by the user
			mail.Body = content; // Email content

			// Create a new SmtpClient object
			SmtpClient smtp = new SmtpClient("smtp.gmail.com");
			smtp.EnableSsl = true;
			smtp.Port = 587;
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(from, pass); // Sender's credentials

			try
			{
				// Send the email
				smtp.Send(mail);
				MessageBox.Show("Gửi Email tư vấn thành công!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Show an error message if sending fails
				MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void btnCapNhat_Click(object sender, EventArgs e)
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
				UC_TheoDoiTuVan ucTheodoituvan = new UC_TheoDoiTuVan(
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
					parentForm.LoadUserControl(ucTheodoituvan);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

		private void txtMK_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
 



	
