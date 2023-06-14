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
    public partial class frmLiLich : Form
    {
        public frmLiLich()
        {
            InitializeComponent();
        }
        public string trangthai = "";
        SqlConnection con = new SqlConnection(@"Data Source=LENOVOG400S\SQLEXPRESS;Initial Catalog=QLHScap1;Integrated Security=True");
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLL.ResetText();
            txtTenMe.ResetText();
            txtSDTMe.ResetText();
            txtNamSinhMe.ResetText();
            txtNgheNghiepMe.ResetText();
            txtTenBo.ResetText();
            txtSDTBo.ResetText();
            txtNamSinhBo.ResetText();
            txtNgheNghiepBo.ResetText();
            txtDiaChiGD.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLL.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Hồ Sơ!!");
            }else if (txtTenMe.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Họ & Tên Mẹ");
            }else if (txtNgheNghiepMe.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Nghề Nghiệp Mẹ");
            } else if (txtNamSinhMe.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Năm Sinh Mẹ");
            }else if (txtSDTMe.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập SĐT Mẹ");
            } else if (txtTenBo.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Họ & Tên Bố ");
            }else if(txtNgheNghiepBo.TextLength ==0)
            {
                MessageBox.Show("Vui Lòng Nhập Nghề Nghiệp Bố");
            }else if (txtSDTBo.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập SĐT Bố");
            }else if(txtNamSinhBo.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Năm Sinh Bố ");
            } else if (txtDiaChiGD.TextLength == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Gia Đình");
            }else
            try
            {
                trangthai = "luu";
                con.Open();
                string sql = "insert into LiLichHS values (@MaLL, @HoTenBo,@HoTenMe, @DiaChi, @SĐTBo ,@SĐTMe, @NgheNghiepBo,@NgheNghiepMe,@MaHocSinh,@NamSinhBo,@NamSinhMe)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLL", txtMaLL.Text);
                cmd.Parameters.AddWithValue("HoTenBo", txtTenBo.Text);
                cmd.Parameters.AddWithValue("HoTenMe", txtTenMe.Text);
                cmd.Parameters.AddWithValue("DiaChi", txtDiaChiGD.Text);
                cmd.Parameters.AddWithValue("SĐTBo", txtSDTBo.Text);
                cmd.Parameters.AddWithValue("SĐTMe", txtSDTMe.Text);
                cmd.Parameters.AddWithValue("NgheNghiepBo", txtNgheNghiepBo.Text);
                cmd.Parameters.AddWithValue("NgheNghiepMe", txtNgheNghiepMe.Text);
                cmd.Parameters.AddWithValue("MaHocSinh", cbMaHocSinh.SelectedValue);
                cmd.Parameters.AddWithValue("NamSinhBo", txtNamSinhBo.Text);
                cmd.Parameters.AddWithValue("NamSinhMe", txtNamSinhMe.Text);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Thêm Dữ Liệu Không Thành Công");
            }
        }
        private void taidl()
        {
            string sql = "select TenHocSinh'Tên Học Sinh', HoTenBo'Họ & Tên Bố', MaLL'Mã Hồ Sơ',"+
                " HoTenMe'Họ & Tên Mẹ', DiaChi'Địa Chỉ',SĐTBo'SĐT Bố', SĐTMe'SĐT Mẹ',NgheNghiepBo'Nghề Nghiệp Bố',"+
                " NgheNghiepMe'Nghề Nghiệp Mẹ',NamSinhBo'Năm Sinh Bố', NamSinhMe'Năm Sinh Mẹ',MaHocSinh'Mã Học Sinh' "+
                " from QLHoSo_view ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgvDSHoSo.DataSource = dt;

        }     

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenu d = new frmMenu();
            d.Show();
            this.Hide();
        }
        private void hienthicbbMaHS()
        {
            String sql = "select * from HocSinh";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbMaHocSinh.DataSource = dt;
            cbMaHocSinh.DisplayMember = "MaHocSinh";
            cbMaHocSinh.ValueMember = "MaHocSinh";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLiLich_Load(object sender, EventArgs e)
        {
            con.Open();
            taidl();
            hienthicbbMaHS();
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "sua";
                con.Open();
                string sql = "update LiLichHS set MaLL = @MaLL, HoTenBo=@HoTenBo,HoTenMe=@HoTenMe, DiaChi=@DiaChi,SĐTBo= @SĐTBo,SĐTMe=@SĐTMe, NgheNghiepBo=@NgheNghiepBo ,NgheNghiepMe=@NgheNghiepMe,MaHocSinh=@MaHocSinh,NamSinhBo=@NamSinhBo,NamSinhMe=@NamSinhMe where MaLL=@MaLL";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLL", txtMaLL.Text);
                cmd.Parameters.AddWithValue("HoTenBo", txtTenBo.Text);
                cmd.Parameters.AddWithValue("HoTenMe", txtTenMe.Text);
                cmd.Parameters.AddWithValue("DiaChi", txtDiaChiGD.Text);
                cmd.Parameters.AddWithValue("SĐTBo", txtSDTBo.Text);
                cmd.Parameters.AddWithValue("SĐTMe", txtSDTMe.Text);
                cmd.Parameters.AddWithValue("NgheNghiepBo", txtNgheNghiepBo.Text);
                cmd.Parameters.AddWithValue("NgheNghiepMe", txtNgheNghiepMe.Text);
                cmd.Parameters.AddWithValue("MaHocSinh", cbMaHocSinh.SelectedValue);
                cmd.Parameters.AddWithValue("NamSinhBo", txtNamSinhBo.Text);
                cmd.Parameters.AddWithValue("NamSinhMe", txtNamSinhMe.Text);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Sửa Dữ Liệu Thành Công!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "xoa";
                con.Open();
                string sql = "delete from LiLichHS where MaLL=@MaLL";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaLL", txtMaLL.Text.Trim());
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

        private void dgvDSHoSo_SelectionChanged(object sender, EventArgs e)
        {
            
            txtTenBo.Text = dgvDSHoSo.CurrentRow.Cells[1].Value.ToString();
            txtMaLL.Text = dgvDSHoSo.CurrentRow.Cells[2].Value.ToString();
            txtTenMe.Text = dgvDSHoSo.CurrentRow.Cells[3].Value.ToString();
            txtDiaChiGD.Text = dgvDSHoSo.CurrentRow.Cells[4].Value.ToString();
            txtSDTBo.Text = dgvDSHoSo.CurrentRow.Cells[5].Value.ToString();
            txtSDTMe.Text = dgvDSHoSo.CurrentRow.Cells[6].Value.ToString();
            txtNgheNghiepBo.Text = dgvDSHoSo.CurrentRow.Cells[7].Value.ToString();
            txtNgheNghiepMe.Text = dgvDSHoSo.CurrentRow.Cells[8].Value.ToString();
            txtNamSinhBo.Text = dgvDSHoSo.CurrentRow.Cells[9].Value.ToString();
            txtNamSinhMe.Text = dgvDSHoSo.CurrentRow.Cells[10].Value.ToString();
            cbMaHocSinh.Text = dgvDSHoSo.CurrentRow.Cells[11].Value.ToString();
        }

      
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            trangthai = "tim kiem";
            con.Open();
            string sqlTimKiem = " select * from  QLHoSo_view  where TenHocSinh=@TenHocSinh";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("TenHocSinh", txtTimKiem.Text);                    
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDSHoSo.DataSource = dt;
            con.Close();
        }

        private void btnHienThiFull_Click_1(object sender, EventArgs e)
        {
            taidl();
        }
    }
}
