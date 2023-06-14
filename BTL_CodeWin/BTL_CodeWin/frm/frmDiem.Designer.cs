
namespace BTL_CodeWin.frm
{
    partial class frmDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHienThiDS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiemTongKet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMaHS = new System.Windows.Forms.ComboBox();
            this.cbXepLoai = new System.Windows.Forms.ComboBox();
            this.cbHanhKiem = new System.Windows.Forms.ComboBox();
            this.txtDiemGiuaKi2 = new System.Windows.Forms.TextBox();
            this.txtDiemTongKetKi1 = new System.Windows.Forms.TextBox();
            this.txtDiemCuoiKi1 = new System.Windows.Forms.TextBox();
            this.txtDiemTongKetKi2 = new System.Windows.Forms.TextBox();
            this.txtDiemGiuaKi1 = new System.Windows.Forms.TextBox();
            this.txtDiemCuoiKi2 = new System.Windows.Forms.TextBox();
            this.txtMaBD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHienThiFull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐIỂM HỌC SINH";
            // 
            // dgvHienThiDS
            // 
            this.dgvHienThiDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiDS.Location = new System.Drawing.Point(32, 359);
            this.dgvHienThiDS.Name = "dgvHienThiDS";
            this.dgvHienThiDS.Size = new System.Drawing.Size(756, 205);
            this.dgvHienThiDS.TabIndex = 3;
            this.dgvHienThiDS.SelectionChanged += new System.EventHandler(this.dgvHienThiDS_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDiemTongKet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbMaHS);
            this.groupBox1.Controls.Add(this.cbXepLoai);
            this.groupBox1.Controls.Add(this.cbHanhKiem);
            this.groupBox1.Controls.Add(this.txtDiemGiuaKi2);
            this.groupBox1.Controls.Add(this.txtDiemTongKetKi1);
            this.groupBox1.Controls.Add(this.txtDiemCuoiKi1);
            this.groupBox1.Controls.Add(this.txtDiemTongKetKi2);
            this.groupBox1.Controls.Add(this.txtDiemGiuaKi1);
            this.groupBox1.Controls.Add(this.txtDiemCuoiKi2);
            this.groupBox1.Controls.Add(this.txtMaBD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtDiemTongKet
            // 
            this.txtDiemTongKet.Location = new System.Drawing.Point(219, 218);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTongKet.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Điểm Tổng Kết";
            // 
            // cbMaHS
            // 
            this.cbMaHS.FormattingEnabled = true;
            this.cbMaHS.Location = new System.Drawing.Point(117, 68);
            this.cbMaHS.Name = "cbMaHS";
            this.cbMaHS.Size = new System.Drawing.Size(100, 21);
            this.cbMaHS.TabIndex = 13;
            // 
            // cbXepLoai
            // 
            this.cbXepLoai.FormattingEnabled = true;
            this.cbXepLoai.Location = new System.Drawing.Point(416, 141);
            this.cbXepLoai.Name = "cbXepLoai";
            this.cbXepLoai.Size = new System.Drawing.Size(100, 21);
            this.cbXepLoai.TabIndex = 12;
            // 
            // cbHanhKiem
            // 
            this.cbHanhKiem.FormattingEnabled = true;
            this.cbHanhKiem.Location = new System.Drawing.Point(417, 106);
            this.cbHanhKiem.Name = "cbHanhKiem";
            this.cbHanhKiem.Size = new System.Drawing.Size(101, 21);
            this.cbHanhKiem.TabIndex = 11;
            // 
            // txtDiemGiuaKi2
            // 
            this.txtDiemGiuaKi2.Location = new System.Drawing.Point(417, 28);
            this.txtDiemGiuaKi2.Name = "txtDiemGiuaKi2";
            this.txtDiemGiuaKi2.Size = new System.Drawing.Size(100, 20);
            this.txtDiemGiuaKi2.TabIndex = 10;
            // 
            // txtDiemTongKetKi1
            // 
            this.txtDiemTongKetKi1.Location = new System.Drawing.Point(117, 186);
            this.txtDiemTongKetKi1.Name = "txtDiemTongKetKi1";
            this.txtDiemTongKetKi1.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTongKetKi1.TabIndex = 9;
            // 
            // txtDiemCuoiKi1
            // 
            this.txtDiemCuoiKi1.Location = new System.Drawing.Point(117, 149);
            this.txtDiemCuoiKi1.Name = "txtDiemCuoiKi1";
            this.txtDiemCuoiKi1.Size = new System.Drawing.Size(100, 20);
            this.txtDiemCuoiKi1.TabIndex = 8;
            // 
            // txtDiemTongKetKi2
            // 
            this.txtDiemTongKetKi2.Location = new System.Drawing.Point(417, 182);
            this.txtDiemTongKetKi2.Name = "txtDiemTongKetKi2";
            this.txtDiemTongKetKi2.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTongKetKi2.TabIndex = 7;
            // 
            // txtDiemGiuaKi1
            // 
            this.txtDiemGiuaKi1.Location = new System.Drawing.Point(117, 109);
            this.txtDiemGiuaKi1.Name = "txtDiemGiuaKi1";
            this.txtDiemGiuaKi1.Size = new System.Drawing.Size(100, 20);
            this.txtDiemGiuaKi1.TabIndex = 7;
            // 
            // txtDiemCuoiKi2
            // 
            this.txtDiemCuoiKi2.Location = new System.Drawing.Point(417, 68);
            this.txtDiemCuoiKi2.Name = "txtDiemCuoiKi2";
            this.txtDiemCuoiKi2.Size = new System.Drawing.Size(100, 20);
            this.txtDiemCuoiKi2.TabIndex = 6;
            // 
            // txtMaBD
            // 
            this.txtMaBD.Location = new System.Drawing.Point(117, 28);
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.Size = new System.Drawing.Size(100, 20);
            this.txtMaBD.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Xếp Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điểm Tổng Kết Kì 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Hạnh Kiểm ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm Cuối Kì 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Điểm Tổng Kết Kì 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm Giữa Kì 1 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Điểm Cuối Kì 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm Giữa Kì 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã HS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BĐ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTinh);
            this.groupBox2.Location = new System.Drawing.Point(599, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(99, 103);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 24);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(99, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(99, 60);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(18, 43);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 98);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính Điểm";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(29, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tìm Kiếm Tên HS";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(124, 323);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(230, 322);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHienThiFull
            // 
            this.btnHienThiFull.Location = new System.Drawing.Point(326, 323);
            this.btnHienThiFull.Name = "btnHienThiFull";
            this.btnHienThiFull.Size = new System.Drawing.Size(95, 23);
            this.btnHienThiFull.TabIndex = 9;
            this.btnHienThiFull.Text = "Hiển thị DS Full";
            this.btnHienThiFull.UseVisualStyleBackColor = true;
            this.btnHienThiFull.Click += new System.EventHandler(this.btnHienThiFull_Click);
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_CodeWin.Properties.Resources.anh_qlhs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btnHienThiFull);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHienThiDS);
            this.Controls.Add(this.label1);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHienThiDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaHS;
        private System.Windows.Forms.ComboBox cbXepLoai;
        private System.Windows.Forms.ComboBox cbHanhKiem;
        private System.Windows.Forms.TextBox txtDiemGiuaKi2;
        private System.Windows.Forms.TextBox txtDiemTongKetKi1;
        private System.Windows.Forms.TextBox txtDiemCuoiKi1;
        private System.Windows.Forms.TextBox txtDiemTongKetKi2;
        private System.Windows.Forms.TextBox txtDiemGiuaKi1;
        private System.Windows.Forms.TextBox txtDiemCuoiKi2;
        private System.Windows.Forms.TextBox txtMaBD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHienThiFull;
        private System.Windows.Forms.TextBox txtDiemTongKet;
        private System.Windows.Forms.Label label13;
    }
}