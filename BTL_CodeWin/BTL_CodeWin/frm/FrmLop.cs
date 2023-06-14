using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL_CodeWin.frm
{
    public partial class FrmLop : Form
    {
        public FrmLop()
        {
            InitializeComponent();
        }
        public string trangthai = "";
        SqlConnection con= new SqlConnection(@"Data Source=LENOVOG400S\SQLEXPRESS;Initial Catalog=QLHScap1;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "sua";
                con.Open();
                string sql = "update Lop set MaLop=@MaLop,TenLop = @TenLop , TenGV=@TenGV where MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLop", txtMaLop.Text);
                cmd.Parameters.AddWithValue("TenLop", txtTenLop.Text);
                cmd.Parameters.AddWithValue("TenGV", txtTenGV.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Dữ Liệu Thành Công !");
                taiDuLieu();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công!");
            }
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            con.Open();
            taiDuLieu();
            con.Close();
            txtMaLop.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.ResetText();
            txtTenLop.ResetText();
            txtTenGV.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "xoa";
                con.Open();
                string sql = " delete from Lop where MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLop", txtMaLop.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Dữ Liệu Thành Công !");
                taiDuLieu();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Xoá Dữ Liệu Không Thành Công!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaLop.TextLength == 0)
            {
                MessageBox.Show("chưa nhập Mã Lớp");
            }else if(txtTenLop.TextLength == 0)
            {
                MessageBox.Show("chưa nhập Tên Lớp");
            }
            else if(txtTenGV.TextLength == 0)
            {
                MessageBox.Show("chưa nhập tên Giáo Viên");
            }else
            try
            {
                trangthai = "luu";
                con.Open();
                string sql = "insert into Lop values (@MaLop, @TenLop, @TenGV)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLop", txtMaLop.Text);
                cmd.Parameters.AddWithValue("TenLop", txtTenLop.Text);             
                cmd.Parameters.AddWithValue("TenGV", txtTenGV.Text);             
                cmd.ExecuteNonQuery();
                taiDuLieu();
                MessageBox.Show("Thêm Dữ Liệu Thành Công!!!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Nhập Dữ Liệu Không Thành Công >< Xin Vui Lòng Kiểm Tra Lại !");
            }
        }

        private void taiDuLieu()
        {
            string sql = "select MaLop 'Mã Lớp',TenLop 'Tên Lớp',TenGV 'Tên Giáo Viên'from Lop";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDSLop.DataSource = dt;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenu d = new frmMenu();
            d.Show();
            this.Hide();

        }

        private void dgvDSLop_SelectionChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = dgvDSLop.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dgvDSLop.CurrentRow.Cells[1].Value.ToString();
            txtTenGV.Text = dgvDSLop.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            trangthai = "tim kiem";
            con.Open();
            string sqlTimKiem = " select *from Lop where TenGV=@TenGV ";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("TenGV", txtTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDSLop.DataSource = dt;
            con.Close();
        }

        private void btnHienThiFull_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }
    }
}
