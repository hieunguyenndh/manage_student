using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CodeWin.frm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
         
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap d = new frmDangNhap();
            d.Show();
            this.Hide();
        }
      

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLop());
        }

        private void quảnLíHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHS());
        }

        private void quảnLíĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDiem());

        }

        private void quảnLíLíLịchHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLiLich());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        private Form currentformchild;
        private void OpenChildForm(Form childForm)
        {
            if(currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
        }
    }
}
