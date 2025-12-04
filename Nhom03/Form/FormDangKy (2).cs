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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void ptrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void chbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
            txtNhapLaiMatKhau.PasswordChar = chbHienMatKhau.Checked ? '\0' : '*';
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
