using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nhom03
{
	public partial class FormDangNhap : Form
	{
		private readonly string connectionString = "Server=localhost;Database=cskh;Uid=root;Pwd=01072004;Port=3306;";

		public FormDangNhap()
		{
			InitializeComponent();
		}

		private void ptrThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			try
			{
				string username = txtTenDangNhap.Text.Trim();
				string password = txtMatKhau.Text.Trim();

				// Kiểm tra nếu tên đăng nhập và mật khẩu bị bỏ trống
				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				{
					MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Truy vấn kiểm tra thông tin đăng nhập và vai trò
				string query = @"
                    SELECT VaiTro 
                    FROM taikhoan 
                    WHERE TenDangNhap = @username AND MatKhau = @password";

				using (MySqlConnection conn = new MySqlConnection(connectionString))
				{
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", username);
						cmd.Parameters.AddWithValue("@password", password);

						object result = cmd.ExecuteScalar();

						if (result != null)
						{
							// Lấy vai trò người dùng từ kết quả truy vấn
							string vaiTro = result.ToString();

							// Lưu thông tin vào class PhanQuyen
							PhanQuyen.TenDangNhap = username;
							PhanQuyen.ViTriHienTai = vaiTro == "Admin" ? ViTri.QuanLy : ViTri.NhanVien;

							// Hiển thị thông báo đăng nhập thành công kèm theo vai trò
							MessageBox.Show($"Đăng nhập thành công! - Vai trò: {PhanQuyen.ViTriHienTai}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

							// Mở Form chính
							FormGiaoDienChinh formChinh = new FormGiaoDienChinh(PhanQuyen.TenDangNhap);
							formChinh.Show();
							this.Hide(); // Ẩn form đăng nhập
						}
						else
						{
							MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lbQuenMatKhau_Click(object sender, EventArgs e)
		{
			FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
			formQuenMatKhau.Show();
			this.Hide();
		}

		private void chbHienMatKhau_CheckedChanged(object sender, EventArgs e)
		{
			txtMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
		}

		private void lbDangKy_Click(object sender, EventArgs e)
		{
			FormDangKy formDangKy = new FormDangKy();
			formDangKy.Show();
			this.Hide();
		}
	}
}



