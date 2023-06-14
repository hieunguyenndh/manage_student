using BTL_CodeWin.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CodeWin
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string tk = "admin", mk = "12345";

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == tk && txtMK.Text == mk) 
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                frmMenu d = new frmMenu();
                d.Show();
                this.Hide();
                                
            }
            else if (txtTK.Text == "")
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập.");
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu.");
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
        }
    }
}
