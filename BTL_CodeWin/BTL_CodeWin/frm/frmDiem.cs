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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        public string trangthai = "";
        SqlConnection con = new SqlConnection(@"Data Source=LENOVOG400S\SQLEXPRESS;Initial Catalog=QLHScap1;Integrated Security=True");
        private void btnTinh_Click(object sender, EventArgs e)
        {
            decimal diemGK1 = Convert.ToDecimal(txtDiemGiuaKi1.Text);
            decimal diemCK1 = Convert.ToDecimal(txtDiemCuoiKi1.Text);
            decimal diemGK2 = Convert.ToDecimal(txtDiemGiuaKi2.Text);
            decimal diemCK2 = Convert.ToDecimal(txtDiemCuoiKi2.Text);
            decimal tk1 = (diemGK1 * 2 + diemCK1 * 3) / 5;
            decimal tk2 = (diemGK2 * 2 + diemCK2 * 3) / 5;
            decimal tk = (tk1 + tk2) / 2;
            txtDiemTongKetKi1.Text = tk1.ToString();
            txtDiemTongKetKi2.Text = tk2.ToString();
            txtDiemTongKet.Text = tk.ToString();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            con.Open();
            taidl();
            hienthicbbMaHS();
            txtDiemTongKet.Enabled = false;
            txtDiemTongKetKi1.Enabled = false;
            txtDiemTongKetKi2.Enabled = false;
            cbHanhKiem.Items.Add("Tốt");
            cbHanhKiem.Items.Add("Khá");
            cbXepLoai.Items.Add("Giỏi");
            cbXepLoai.Items.Add("Khá");
            cbXepLoai.Items.Add("Trung Bình");
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBD.ResetText();
            cbMaHS.ResetText();
            txtDiemGiuaKi1.ResetText();
            txtDiemGiuaKi2.ResetText();
            txtDiemCuoiKi1.ResetText();
            txtDiemCuoiKi2.ResetText();
            txtDiemTongKet.ResetText();
            txtDiemTongKetKi1.ResetText();
            txtDiemTongKetKi2.ResetText();
            txtTimKiem.ResetText();
        }
        private void hienthicbbMaHS()
        {
            String sql = "select * from HocSinh";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbMaHS.DataSource = dt;
            cbMaHS.DisplayMember = "MaHocSinh";
            cbMaHS.ValueMember = "MaHocSinh";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "luu";
                con.Open();
                string sql = "insert into BangDiem values (@MaBĐ,@DiemGiuaKi1, @DiemCuoiKi1, @DiemTongKetKi1," +
                    " @XepLoai,@HanhKiem,@MaHocSinh,@DiemGiuaKi2,@DiemCuoiKi2, @DiemTongKetKi2,@DiemTongKet)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaBĐ", txtMaBD.Text);
                cmd.Parameters.AddWithValue("DiemGiuaKi1", txtDiemGiuaKi1.Text);
                cmd.Parameters.AddWithValue("DiemCuoiKi1", txtDiemCuoiKi1.Text);
                cmd.Parameters.AddWithValue("DiemTongKetKi1", txtDiemTongKetKi1.Text);
                cmd.Parameters.AddWithValue("DiemGiuaKi2", txtDiemGiuaKi2.Text);
                cmd.Parameters.AddWithValue("DiemCuoiKi2", txtDiemCuoiKi2.Text);
                cmd.Parameters.AddWithValue("DiemTongKetKi2", txtDiemTongKetKi2.Text);
                cmd.Parameters.AddWithValue("DiemTongKet", txtDiemTongKet.Text);
                cmd.Parameters.AddWithValue("HanhKiem", cbHanhKiem.Text);
                cmd.Parameters.AddWithValue("XepLoai", cbXepLoai.Text);
                cmd.Parameters.AddWithValue("MaHocSinh", cbMaHS.SelectedValue);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Thêm Dữ Liệu Thành Công!");
                con.Close();
        }
            catch
            {
                MessageBox.Show("Thêm Dữ liệu không thành công >< Vui Lòng Kiểm Tra Lại");
            }
}
        private void taidl()
        {
            string sql = "select TenHocSinh'Tên Học Sinh',MaBĐ'Mã Bảng Điểm',DiemGiuaKi1'Điểm Giữa Kì 1'," +
                "DiemCuoiKi1'Điểm Cuối Kì 1',DiemTongKetKi1'Điểm Tổng Kết Kì 1',XepLoai'Xếp Loại',HanhKiem'Hạnh Kiểm'," +
                "MaHocSinh'Mã Học Sinh',DiemGiuaKi2'Điểm Giữa Kì 2',DiemCuoiKi2'Điểm Cuối Kì 2',DiemTongKetKi2'Điểm Tổng Kết Kì 2'," +
                "DiemTongKet'Điểm Tổng Kết'" +
                "from View_DSDiem";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgvHienThiDS.DataSource = dt;
          //  dgvHienThiDS.Columns["Điểm Tổng Kết"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "sua";
                con.Open();
                string sql = "update BangDiem set MaBĐ = @MaBĐ, DiemGiuaKi1=@DiemGiuaKi1,DiemCuoiKi1=@DiemCuoiKi1, DiemTongKetKi1=@DiemTongKetKi1,DiemGiuaKi2= @DiemGiuaKi2," +
                    "DiemCuoiKi2=@DiemCuoiKi2, DiemTongKetKi2=@DiemTongKetKi2 ,DiemTongKet=@DiemTongKet,MaHocSinh=@MaHocSinh,HanhKiem=@HanhKiem,XepLoai=@XepLoai where MaBĐ=@MaBĐ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaBĐ", txtMaBD.Text);
                cmd.Parameters.AddWithValue("DiemGiuaKi1", txtDiemGiuaKi1.Text);
                cmd.Parameters.AddWithValue("DiemCuoiKi1", txtDiemCuoiKi1.Text);
                cmd.Parameters.AddWithValue("DiemTongKetKi1", txtDiemTongKetKi1.Text);
                cmd.Parameters.AddWithValue("DiemGiuaKi2", txtDiemGiuaKi2.Text);
                cmd.Parameters.AddWithValue("DiemCuoiKi2", txtDiemCuoiKi2.Text);
                cmd.Parameters.AddWithValue("DiemTongKetKi2", txtDiemTongKetKi2.Text);
                cmd.Parameters.AddWithValue("DiemTongKet", txtDiemTongKet.Text);
                cmd.Parameters.AddWithValue("HanhKiem", cbHanhKiem.Text);
                cmd.Parameters.AddWithValue("XepLoai", cbXepLoai.Text);
                cmd.Parameters.AddWithValue("MaHocSinh", cbMaHS.SelectedValue);
                cmd.ExecuteNonQuery();
                taidl();
                MessageBox.Show("Sửa Dữ Liệu Thành Công!");
                con.Close();
            }
            catch
            {
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công >< Vui Lòng Xem Lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                trangthai = "xoa";
                con.Open();
                string sql = "delete from BangDiem where MaBĐ=@MaBĐ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MaBĐ", txtMaBD.Text.Trim());
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

        private void btnHienThiFull_Click(object sender, EventArgs e)
        {
            taidl();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                trangthai = "tim kiem";
                con.Open();
                string sqlTimKiem = " select * from  View_DSDiem where TenHocSinh=@TenHocSinh";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
                cmd.Parameters.AddWithValue("TenHocSinh", txtTimKiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dgvHienThiDS.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Tìm Kiếm Không Thành Công");
            }
        }

        private void dgvHienThiDS_SelectionChanged(object sender, EventArgs e)
        {

            txtMaBD.Text = dgvHienThiDS.CurrentRow.Cells[1].Value.ToString();
            txtDiemGiuaKi1.Text = dgvHienThiDS.CurrentRow.Cells[2].Value.ToString();
            txtDiemCuoiKi1.Text = dgvHienThiDS.CurrentRow.Cells[3].Value.ToString();
            txtDiemTongKetKi1.Text = dgvHienThiDS.CurrentRow.Cells[4].Value.ToString();
            cbXepLoai.Text = dgvHienThiDS.CurrentRow.Cells[5].Value.ToString();
            cbHanhKiem.Text = dgvHienThiDS.CurrentRow.Cells[6].Value.ToString();
            cbMaHS.SelectedValue = dgvHienThiDS.CurrentRow.Cells[7].Value.ToString();
            txtDiemGiuaKi2.Text = dgvHienThiDS.CurrentRow.Cells[8].Value.ToString();
            txtDiemCuoiKi2.Text = dgvHienThiDS.CurrentRow.Cells[9].Value.ToString();
            txtDiemTongKetKi2.Text = dgvHienThiDS.CurrentRow.Cells[10].Value.ToString();
            txtDiemTongKet.Text = dgvHienThiDS.CurrentRow.Cells[11].Value.ToString();

        }
    }
}
