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
    public partial class frmQLHS : Form
    {
        public frmQLHS()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        public string trangthai = "";
        SqlConnection con = new SqlConnection(@"Data Source=LENOVOG400S\SQLEXPRESS;Initial Catalog=QLHScap1;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHS.ResetText();
            txtTenHS.ResetText();
            cbGioiTinh.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            cbMaLop.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHS.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã Học Sinh!! Vui lòng nhập!!");
            }else if (txtTenHS.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên Học Sinh !! Vui lòng nhập!!");
            }
            else if(string.IsNullOrEmpty(cbGioiTinh.Text))
            {
                MessageBox.Show("Chưa nhập giới tính !! Vui lòng nhập !!");
            }
            else if (txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập địa chỉ !! Vui lòng Nhập");
            } else if (txtSDT.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập Số Điện Thoại !! Vui lòng Nhập");
            } else
                try
                {
                    trangthai = "luu";
                    con.Open();
                    string sql = "insert into HocSinh values (@MaHocSinh, @TenHocSinh,@GioiTinh, @NgaySinh, @DiaChi ,@SĐT, @MaLop)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("MaHocSinh", txtMaHS.Text);
                    cmd.Parameters.AddWithValue("TenHocSinh", txtTenHS.Text);
                    cmd.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("NgaySinh", dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("MaLop", cbMaLop.SelectedValue);
                    cmd.Parameters.AddWithValue("SĐT", txtSDT.Text);
                    cmd.ExecuteNonQuery();
                    taidl();
                    MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công >< Vui lòng xem lại dữ liệu nhập!!");
                }


        }
        private void taidl()
        {
            string sql = "select MaHocSinh'Mã Học Sinh',TenHocSinh'Tên Học Sinh',GioiTinh'Giới Tính'," +
                "NgaySinh'Ngày Sinh' ,DiaChi'Địa Chỉ',SĐT'Số Điện Thoại',MaLop'Mã Lớp'" +
                " from HocSinh ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgvDanhSachHS.DataSource = dt;
            dgvDanhSachHS.Columns["Mã Lớp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }
        private void hienthicbbMaLop()
        {
            String sql = "select * from Lop";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
        }
        public void hienthicbbGioiTinh()
        {
           
        }
        private void frmQLHS_Load(object sender, EventArgs e)
        {
            con.Open();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            taidl();
            hienthicbbMaLop();         
            con.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "sua";
                con.Open();
                string sql = "update HocSinh set TenHocSinh = @TenHocSinh, MaHocSinh=@MaHocSinh, NgaySinh=@NgaySinh, SĐT=@SĐT, GioiTinh=@GioiTinh, DiaChi=@DiaChi, MaLop=@MaLop where MaHocSinh=@MaHocSinh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaHocSinh", txtMaHS.Text);
                cmd.Parameters.AddWithValue("TenHocSinh", txtTenHS.Text);
                cmd.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtpNgaySinh.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("MaLop", cbMaLop.SelectedValue);
                cmd.Parameters.AddWithValue("SĐT", txtSDT.Text);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Sửa Dữ Liệu Thành Công!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "xoa";
                con.Open();
                string sql = "delete from HocSinh where MaHocSinh=@MaHocSinh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaHocSinh", txtMaHS.Text);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Xóa dữ liệu thành công");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Xóa Dữ Liệu Không Thành Công");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            trangthai = "tim kiem";
            con.Open();
            string sqlTimKiem = " select *from HocSinh where TenHocSinh=@TenHocSinh ";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("TenHocSinh", txtTimKiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDanhSachHS.DataSource = dt;
            con.Close();
        }

        private void dgvDanhSachHS_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHS.Text = dgvDanhSachHS.CurrentRow.Cells[0].Value.ToString();
            txtTenHS.Text = dgvDanhSachHS.CurrentRow.Cells[1].Value.ToString();
            cbGioiTinh.Text = dgvDanhSachHS.CurrentRow.Cells[2].Value.ToString();          
            txtDiaChi.Text = dgvDanhSachHS.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgvDanhSachHS.CurrentRow.Cells[5].Value.ToString();
            cbMaLop.Text = dgvDanhSachHS.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnHienThiFull_Click(object sender, EventArgs e)
        {
            taidl();
        }
    }
}
