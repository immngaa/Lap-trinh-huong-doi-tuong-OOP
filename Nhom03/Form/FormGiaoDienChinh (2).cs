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
        public FormGiaoDienChinh()
        {
            InitializeComponent();
            customizeDesing();
			

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

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
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
            anMenu();

        }

        private void btnNhomKH_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_NhomKH uc_NhomKH = new UC_NhomKH();
            uc_NhomKH.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_NhomKH);
            anMenu();
        }

        private void btnThongTinSanPham_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_ThongTinSanPham uc_ThongTinSanPham = new UC_ThongTinSanPham();
            uc_ThongTinSanPham.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_ThongTinSanPham);
            anMenu();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_LoaiSanPham uc_LoaiSanPham = new UC_LoaiSanPham();
            uc_LoaiSanPham.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_LoaiSanPham);
            anMenu();
        }

        private void btnThongTinDonHang_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_ThongTinDonHang uc_LoaiSanPham = new UC_ThongTinDonHang();
            uc_LoaiSanPham.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_LoaiSanPham);
            anMenu();
        }

        private void btnCTKhuyenMai_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_CTKhuyenMai uc_CTKhuyenMai = new UC_CTKhuyenMai();
            uc_CTKhuyenMai.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_CTKhuyenMai);
            anMenu();
        }

        private void btnCTKHThanThiet_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_CTKHThanThiet uc_CTKHThanThiet = new UC_CTKHThanThiet();
            uc_CTKHThanThiet.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_CTKHThanThiet);
            anMenu();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_BaoHanh uc_BaoHanh = new UC_BaoHanh();
            uc_BaoHanh.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_BaoHanh);
            anMenu();
        }

        private void btnLichSuTuVan_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_LichSuTuVan uc_LichSuTuVan = new UC_LichSuTuVan();
            uc_LichSuTuVan.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_LichSuTuVan);
            anMenu();
        }

        private void btnThongTinKhieuNai_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_ThongTinKhieuNai uc_ThongTinKhieuNai = new UC_ThongTinKhieuNai();
            uc_ThongTinKhieuNai.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_ThongTinKhieuNai);
            anMenu();
        }

        private void btnThongTinDanhGiaKH_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_ThongTinDanhGiaKH uc_ThongTinDanhGiaKH = new UC_ThongTinDanhGiaKH();
            uc_ThongTinDanhGiaKH.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_ThongTinDanhGiaKH);
            anMenu();
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            panelTrungTam.Controls.Clear();
            UC_ThongTinNhanVien uc_ThongTinNhanVien = new UC_ThongTinNhanVien();
            uc_ThongTinNhanVien.Dock = DockStyle.Fill;
            panelTrungTam.Controls.Add(uc_ThongTinNhanVien);
            anMenu();

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
			anMenu();
		}

        private void btnXuLyTuVan_Click(object sender, EventArgs e)
        {
		
		}

        private void btnTheoDoiTuVan_Click(object sender, EventArgs e)
        {

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

        }

        private void btnPhanHoiKhieuNai_Click(object sender, EventArgs e)
        {

        }

        private void btnTheoDoiTinhHinh_Click(object sender, EventArgs e)
        {

        }
        #endregion XuLyKhieuNai
        private void btnDichVuHauMai_Click(object sender, EventArgs e)
        {
            hienMenu(panelDichVuHauMai);
        }
        #region DichVuHauMai
        private void btnBaoHanhBaoTri_Click(object sender, EventArgs e)
        {

        }

        private void btnCTKHTTDoiDiem_Click(object sender, EventArgs e)
        {

        }
        #endregion DichVuHauMai
        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            hienMenu(panelBaoCaoThongKe);
        }
        #region BaoCaoThongKe
        private void btnMucDoHaiLongCuaKH_Click(object sender, EventArgs e)
        {
			panelTrungTam.Controls.Clear();
			UC_MucDoHaiLongCuaKH uc_MucDoHaiLongCuaKH = new UC_MucDoHaiLongCuaKH();
			uc_MucDoHaiLongCuaKH.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_MucDoHaiLongCuaKH);
			anMenu();
		}

        private void btnPhanTichHVXHKH_Click(object sender, EventArgs e)
        {
			panelTrungTam.Controls.Clear();
			UC_PhanTichHVXHCuaKH uc_Phantichhvmh = new UC_PhanTichHVXHCuaKH();
			uc_Phantichhvmh.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_Phantichhvmh);
			anMenu();
		}

        private void btnKhieuNaiCuaKH_Click(object sender, EventArgs e)
        {

        }

        private void btnHieuQuaCTKhuyenMai_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnHieuSuatNhanVien_Click(object sender, EventArgs e)
        {
			panelTrungTam.Controls.Clear();
			UC_HieuSuatNhanVien uc_HieuSuatNhanVien = new UC_HieuSuatNhanVien();
			uc_HieuSuatNhanVien.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(uc_HieuSuatNhanVien);
			anMenu();
		}
		#endregion BaoCaoThongKe
		public void LoadUserControl(UserControl newUserControl)
		{
			panelTrungTam.Controls.Clear(); // Xóa nội dung cũ
			newUserControl.Dock = DockStyle.Fill;
			panelTrungTam.Controls.Add(newUserControl); // Thêm UserControl mới
		}

	}

}
