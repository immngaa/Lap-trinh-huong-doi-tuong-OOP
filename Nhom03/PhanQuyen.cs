using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom03
{
   
        public static class PhanQuyen
        {
            public static string TenDangNhap { get; set; } // Tên đăng nhập của người dùng
            public static ViTri ViTriHienTai { get; set; }        // Vị trí của người dùng
        }

        public enum ViTri
        {
            QuanLy,    // Quản lý
            NhanVien   // Nhân viên
        }

}
