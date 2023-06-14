
namespace BTL_CodeWin.frm
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíLíLịchHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất ";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíLớpHọcToolStripMenuItem,
            this.quảnLíHọcSinhToolStripMenuItem,
            this.quảnLíĐiểmToolStripMenuItem,
            this.quảnLíLíLịchHSToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnLíLớpHọcToolStripMenuItem
            // 
            this.quảnLíLớpHọcToolStripMenuItem.Name = "quảnLíLớpHọcToolStripMenuItem";
            this.quảnLíLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíLớpHọcToolStripMenuItem.Text = "Quản Lí Lớp Học";
            this.quảnLíLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíLớpHọcToolStripMenuItem_Click);
            // 
            // quảnLíHọcSinhToolStripMenuItem
            // 
            this.quảnLíHọcSinhToolStripMenuItem.Name = "quảnLíHọcSinhToolStripMenuItem";
            this.quảnLíHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíHọcSinhToolStripMenuItem.Text = "Quản Lí Học Sinh";
            this.quảnLíHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.quảnLíHọcSinhToolStripMenuItem_Click);
            // 
            // quảnLíĐiểmToolStripMenuItem
            // 
            this.quảnLíĐiểmToolStripMenuItem.Name = "quảnLíĐiểmToolStripMenuItem";
            this.quảnLíĐiểmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíĐiểmToolStripMenuItem.Text = "Quản Lí Điểm";
            this.quảnLíĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLíĐiểmToolStripMenuItem_Click);
            // 
            // quảnLíLíLịchHSToolStripMenuItem
            // 
            this.quảnLíLíLịchHSToolStripMenuItem.Name = "quảnLíLíLịchHSToolStripMenuItem";
            this.quảnLíLíLịchHSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíLíLịchHSToolStripMenuItem.Text = "Quản Lí Lí Lịch HS";
            this.quảnLíLíLịchHSToolStripMenuItem.Click += new System.EventHandler(this.quảnLíLíLịchHSToolStripMenuItem_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackgroundImage = global::BTL_CodeWin.Properties.Resources.anh_panel;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 24);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(822, 441);
            this.panel_body.TabIndex = 5;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíLíLịchHSToolStripMenuItem;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}