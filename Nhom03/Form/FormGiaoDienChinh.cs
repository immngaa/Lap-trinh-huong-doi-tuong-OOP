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
	public partial class FormGiaoDienChinh : Form
	{
		//private Form formCon;
		private string tenDangNhap;
		public FormGiaoDienChinh(string tenDangNhap)
		{
			InitializeComponent();
			customizeDesing();
			this.tenDangNhap = tenDangNhap;


		}

		#region ThietKeMenu
		private void customizeDesing()
		{
			panelDanhMuc.Visible = false;
			panelTuVanGiaiDap.Visible = false;
			panelDichVuHauMai.Visible = false;
			panelXuLyKhieuNai.Visible = false;
			panelBaoCaoThongKe.Visible = false;


		}

		//Ẩn các chức năng con
		private void anMenu()
		{
			if (panelDanhMuc.Visible == true)
			{
				panelDanhMuc.Visible = false;
			}

			if (panelTuVanGiaiDap.Visible == true)
			{
				panelTuVanGiaiDap.Visible = false;
			}

			if (panelDichVuHauMai.Visible == true)
			{
				panelDichVuHauMai.Visible = false;
			}

			if (panelXuLyKhieuNai.Visible == true)
			{
				panelXuLyKhieuNai.Visible = false;
			}

			if (panelBaoCaoThongKe.Visible == true)
			{
				panelBaoCaoThongKe.Visible = false;
			}


		}

		// Hiện Menu của các chức năng
		private void hienMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				anMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;

		}
		/*
        //Hàm mở form con trên form cha
        private void moFormCon(Form conForm)
        {

            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = conForm;
            conForm.TopLevel = false;
            conForm.FormBorderStyle = FormBorderStyle.None;
            conForm.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(conForm);
            panelTrungTam.Tag = conForm;
            conForm.BringToFront();
            conForm.Show();


        }*/

		#endregion ThietKeMenu

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			FormDangXuat formDangXuat = new FormDangXuat();
			formDangXuat.Show();
			this.Close();

		}

		private void btnTrangChu_Click(object sender, EventArgs e)
		{
			FormGiaoDienChinh formGiaoDienChinh = new FormGiaoDienChinh(tenDangNhap);
			formGiaoDienChinh.Show();
			this.Close();
			anMenu();
		}

		private void btnDanhMuc_Click(object sender, EventArgs e)
		{
			hienMenu(panelDanhMuc);
		}
		#region DanhMuc
		private void btnThongTinKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongTinKH uc_ThongTinKH = new UC_ThongTinKH();
			uc_ThongTinKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_ThongTinKH);
			lbThayDoiTheoMenu.Text = btnThongTinKH.Text;
			anMenu();

		}

		private void btnNhomKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_NhomKH uc_NhomKH = new UC_NhomKH();
			uc_NhomKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_NhomKH);
			lbThayDoiTheoMenu.Text = btnNhomKH.Text;
			anMenu();
		}

		private void btnThongTinSanPham_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongTinSanPham uc_ThongTinSanPham = new UC_ThongTinSanPham();
			uc_ThongTinSanPham.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_ThongTinSanPham);
			lbThayDoiTheoMenu.Text = btnThongTinSanPham.Text;
			anMenu();

		}

		private void btnLoaiSanPham_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_LoaiSanPham uc_LoaiSanPham = new UC_LoaiSanPham();
			uc_LoaiSanPham.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_LoaiSanPham);
			lbThayDoiTheoMenu.Text = btnLoaiSanPham.Text;
			anMenu();
		}

		private void btnThongTinDonHang_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongTinDonHang uc_LoaiSanPham = new UC_ThongTinDonHang();
			uc_LoaiSanPham.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_LoaiSanPham);
			lbThayDoiTheoMenu.Text = btnThongTinDonHang.Text;
			anMenu();
		}

		private void btnCTKhuyenMai_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_CTKhuyenMai uc_CTKhuyenMai = new UC_CTKhuyenMai();
			uc_CTKhuyenMai.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_CTKhuyenMai);
			lbThayDoiTheoMenu.Text = btnCTKhuyenMai.Text;
			anMenu();
		}

		private void btnCTKHThanThiet_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_CTKHThanThiet uc_CTKHThanThiet = new UC_CTKHThanThiet();
			uc_CTKHThanThiet.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_CTKHThanThiet);
			lbThayDoiTheoMenu.Text = btnCTKHThanThiet.Text;
			anMenu();
		}

		private void btnBaoHanh_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_BaoHanh uc_BaoHanh = new UC_BaoHanh();
			uc_BaoHanh.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_BaoHanh);
			lbThayDoiTheoMenu.Text = btnBaoHanh.Text;
			anMenu();
		}

		private void btnLichSuTuVan_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_LichSuTuVan uc_LichSuTuVan = new UC_LichSuTuVan();
			uc_LichSuTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_LichSuTuVan);
			lbThayDoiTheoMenu.Text = btnLichSuTuVan.Text;
			anMenu();
		}

		private void btnThongTinKhieuNai_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongTinKhieuNai uc_ThongTinKhieuNai = new UC_ThongTinKhieuNai();
			uc_ThongTinKhieuNai.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_ThongTinKhieuNai);
			lbThayDoiTheoMenu.Text = btnThongTinKhieuNai.Text;
			anMenu();
		}

		private void btnThongTinDanhGiaKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongTinDanhGiaKH uc_ThongTinDanhGiaKH = new UC_ThongTinDanhGiaKH();
			uc_ThongTinDanhGiaKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_ThongTinDanhGiaKH);
			lbThayDoiTheoMenu.Text = btnThongTinDanhGiaKH.Text;
			anMenu();
		}

		private void btnThongTinNhanVien_Click(object sender, EventArgs e)
		{
			if (PhanQuyen.ViTriHienTai == ViTri.QuanLy) // Kiểm tra quyền của người dùng
			{
				// Người dùng là Quản lý -> mở UC_ThongTinNhanVien
				panelTrungTam.Controls.Clear();
				UC_ThongTinNhanVien uc_ThongTinNhanVien = new UC_ThongTinNhanVien();
				uc_ThongTinNhanVien.Dock = DockStyle.Fill;
				panelTrungTam.Controls.Add(uc_ThongTinNhanVien);
				lbThayDoiTheoMenu.Text = btnThongTinNhanVien.Text;
				anMenu(); // Ẩn menu nếu cần
			}
			else
			{
				// Người dùng không có quyền -> hiển thị thông báo
				MessageBox.Show("Bạn không có quyền truy cập vào Thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				// Không thêm UC_ThongTinNhanVien vào panel
				panelTrungTam.Controls.Clear(); // Đảm bảo panel không bị thêm bất kỳ nội dung nào
			}
		}

		#endregion DanhMuc
		private void btnTuVanGiaiDap_Click(object sender, EventArgs e)
		{
			hienMenu(panelTuVanGiaiDap);
		}
		#region TuVanGiaiDap
		private void btnTiepNhanTuVan_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_TiepNhanTuVan uc_TiepNhanTuVan = new UC_TiepNhanTuVan();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnTiepNhanTuVan.Text;

			anMenu();
		}

		private void btnXuLyTuVan_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_XuLyTuVan uc_TiepNhanTuVan = new UC_XuLyTuVan();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnXuLyTuVan.Text;
			anMenu();
		}

		private void btnTheoDoiTuVan_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_TheoDoiTuVan uc_TiepNhanTuVan = new UC_TheoDoiTuVan();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnTheoDoiTuVan.Text;
			anMenu();
		}

		private void btnChatbox_Click(object sender, EventArgs e)
		{

		}
		#endregion TuVanGiaiDap
		private void btnXuLyKhieuNai_Click(object sender, EventArgs e)
		{
			hienMenu(panelXuLyKhieuNai);
		}
		#region XuLyKhieuNai

		private void btnTiepNhanKhieuNai_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_TiepNhanKhieuNai uc_TiepNhanTuVan = new UC_TiepNhanKhieuNai();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnXuLyKhieuNai.Text;
		}

		private void btnPhanHoiKhieuNai_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_PhanHoiKhieuNai uc_TiepNhanTuVan = new UC_PhanHoiKhieuNai();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnPhanHoiKhieuNai.Text;
			anMenu();
		}

		private void btnTheoDoiTinhHinh_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_TheoDoiTinhHinhKhieuNai uc_TiepNhanTuVan = new UC_TheoDoiTinhHinhKhieuNai();
			uc_TiepNhanTuVan.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_TiepNhanTuVan);
			lbThayDoiTheoMenu.Text = btnTheoDoiTinhHinh.Text;
			anMenu();
		}
		#endregion XuLyKhieuNai
		private void btnDichVuHauMai_Click(object sender, EventArgs e)
		{
			hienMenu(panelDichVuHauMai);
		}
		#region DichVuHauMai
		private void btnBaoHanhBaoTri_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_BaoHanhBaoTri uc_BaoHanhBaoTri = new UC_BaoHanhBaoTri();
			uc_BaoHanhBaoTri.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_BaoHanhBaoTri);
			lbThayDoiTheoMenu.Text = btnBaoHanhBaoTri.Text;
			anMenu();
		}

		private void btnCTKHTTDoiDiem_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_CTKHTTDoiDiem uc_CTKHTTDoiDiem = new UC_CTKHTTDoiDiem();
			uc_CTKHTTDoiDiem.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_CTKHTTDoiDiem);
			lbThayDoiTheoMenu.Text = btnCTKHTTDoiDiem.Text;
			anMenu();
		}
		#endregion DichVuHauMai
		private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
		{
			if (PhanQuyen.ViTriHienTai == ViTri.QuanLy) // Chỉ Admin mới được phép truy cập
			{
				// Nếu là Admin, mở panel và chạy bình thường
				hienMenu(panelBaoCaoThongKe);
			}
			else
			{
				// Hiển thị thông báo nếu không có quyền
				MessageBox.Show("Bạn không có quyền truy cập vào Báo cáo thống kê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				// Đóng panelBaoCaoThongKe nếu nó đang mở
				if (panelBaoCaoThongKe.Visible)
				{
					panelBaoCaoThongKe.Visible = false;
				}
			}

		}
		#region BaoCaoThongKe
		private void btnMucDoHaiLongCuaKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_MucDoHaiLongCuaKH uc_MucDoHaiLongCuaKH = new UC_MucDoHaiLongCuaKH();
			uc_MucDoHaiLongCuaKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_MucDoHaiLongCuaKH);
			lbThayDoiTheoMenu.Text = btnMucDoHaiLongCuaKH.Text;

			anMenu();
			//if (PhanQuyen.ViTriHienTai == ViTri.QuanLy)
			//{
			//    // Chỉ cho phép admin truy cập
			//    UC_MucDoHaiLongCuaKH form = new UC_MucDoHaiLongCuaKH();
			//    form.Show();
			//}
			//else
			//{
			//    MessageBox.Show("Bạn không có quyền truy cập vào Báo cáo thống kê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}

		private void btnPhanTichHVXHKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_PhanTichHVXHCuaKH uc_Phantichhvmh = new UC_PhanTichHVXHCuaKH();
			uc_Phantichhvmh.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_Phantichhvmh);
			lbThayDoiTheoMenu.Text = btnPhanTichHVXHKH.Text;

			anMenu();
		}

		private void btnKhieuNaiCuaKH_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_KhieuNaiCuaKH uc_KhieuNaiCuaKH = new UC_KhieuNaiCuaKH();
			uc_KhieuNaiCuaKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_KhieuNaiCuaKH);
			lbThayDoiTheoMenu.Text = btnKhieuNaiCuaKH.Text;
			anMenu();
		}

		private void btnHieuQuaCTKhuyenMai_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_HieuQuaCTKhuyenMai uc_HieuQuaCTKhuyenMai = new UC_HieuQuaCTKhuyenMai();
			uc_HieuQuaCTKhuyenMai.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_HieuQuaCTKhuyenMai);
			lbThayDoiTheoMenu.Text = btnHieuQuaCTKhuyenMai.Text;
			anMenu();
		}

		private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_ThongKeDoanhThu uc_ThongKeDoanhThu = new UC_ThongKeDoanhThu();
			uc_ThongKeDoanhThu.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_ThongKeDoanhThu);
			lbThayDoiTheoMenu.Text = btnThongKeDoanhThu.Text;
			anMenu();
		}

		private void btnHieuSuatNhanVien_Click(object sender, EventArgs e)
		{
			panelTrungTam.Controls.Clear();
			UC_HieuSuatNhanVien uc_HieuSuatNhanVien = new UC_HieuSuatNhanVien();
			uc_HieuSuatNhanVien.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_HieuSuatNhanVien);
			lbThayDoiTheoMenu.Text = btnHieuSuatNhanVien.Text;

			anMenu();
		}
		#endregion BaoCaoThongKe
		public void LoadUserControl(UserControl newUserControl)
		{
			panelTrungTam.Controls.Clear(); // Xóa nội dung cũ
			newUserControl.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(newUserControl); // Thêm UserControl mới
		}

		private void FormGiaoDienChinh_Load(object sender, EventArgs e)
		{
			//lbXinChao.Text = $"Xin chào, {tenDangNhap}";
			// Hiển thị thông tin chào mừng
			lbXinChao.Text = $"Chào mừng {PhanQuyen.TenDangNhap} - {PhanQuyen.ViTriHienTai}";

		}


	}
}



