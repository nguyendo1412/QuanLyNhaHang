namespace QuanLyNhaHang
{
    partial class frm_TrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TrangChu));
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Center = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BanAn = new System.Windows.Forms.Button();
            this.btn_MonAn = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.lbl_TrangChu = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DoiMatKhau = new System.Windows.Forms.Label();
            this.lbl_ThongTin = new System.Windows.Forms.Label();
            this.panel_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Bisque;
            this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKe.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(12, 490);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(233, 65);
            this.btn_ThongKe.TabIndex = 22;
            this.btn_ThongKe.Text = "   THỐNG KÊ";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            this.btn_ThongKe.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_ThongKe.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.Bisque;
            this.btn_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhanVien.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(12, 64);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(233, 65);
            this.btn_NhanVien.TabIndex = 21;
            this.btn_NhanVien.Text = "   NHÂN VIÊN";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            this.btn_NhanVien.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_NhanVien.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Bisque;
            this.btn_HoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HoaDon.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(12, 348);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(233, 65);
            this.btn_HoaDon.TabIndex = 26;
            this.btn_HoaDon.Text = "   HÓA ĐƠN";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            this.btn_HoaDon.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_HoaDon.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_Center
            // 
            this.panel_Center.Controls.Add(this.pictureBox1);
            this.panel_Center.Location = new System.Drawing.Point(265, 64);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(973, 575);
            this.panel_Center.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BanAn
            // 
            this.btn_BanAn.BackColor = System.Drawing.Color.Bisque;
            this.btn_BanAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BanAn.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_BanAn.Image")));
            this.btn_BanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanAn.Location = new System.Drawing.Point(12, 206);
            this.btn_BanAn.Name = "btn_BanAn";
            this.btn_BanAn.Size = new System.Drawing.Size(233, 65);
            this.btn_BanAn.TabIndex = 30;
            this.btn_BanAn.Text = "   BÀN ĂN";
            this.btn_BanAn.UseVisualStyleBackColor = false;
            this.btn_BanAn.Click += new System.EventHandler(this.btn_BanAn_Click);
            this.btn_BanAn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_BanAn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_MonAn
            // 
            this.btn_MonAn.BackColor = System.Drawing.Color.Bisque;
            this.btn_MonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MonAn.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MonAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_MonAn.Image")));
            this.btn_MonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MonAn.Location = new System.Drawing.Point(12, 277);
            this.btn_MonAn.Name = "btn_MonAn";
            this.btn_MonAn.Size = new System.Drawing.Size(233, 65);
            this.btn_MonAn.TabIndex = 25;
            this.btn_MonAn.Text = "   MÓN ĂN";
            this.btn_MonAn.UseVisualStyleBackColor = false;
            this.btn_MonAn.Click += new System.EventHandler(this.btn_MonAn_Click);
            this.btn_MonAn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_MonAn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.Bisque;
            this.btn_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhachHang.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
            this.btn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.Location = new System.Drawing.Point(12, 135);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(233, 65);
            this.btn_KhachHang.TabIndex = 33;
            this.btn_KhachHang.Text = "KHÁCH HÀNG";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            this.btn_KhachHang.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_KhachHang.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.Bisque;
            this.btn_NhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhapHang.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapHang.Image")));
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(12, 419);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(233, 65);
            this.btn_NhapHang.TabIndex = 34;
            this.btn_NhapHang.Text = "    NHẬP HÀNG";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            this.btn_NhapHang.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_NhapHang.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // lbl_TrangChu
            // 
            this.lbl_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("lbl_TrangChu.Image")));
            this.lbl_TrangChu.Location = new System.Drawing.Point(3, 7);
            this.lbl_TrangChu.Name = "lbl_TrangChu";
            this.lbl_TrangChu.Size = new System.Drawing.Size(32, 32);
            this.lbl_TrangChu.TabIndex = 35;
            this.lbl_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            this.lbl_TrangChu.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_TrangChu.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Bisque;
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(12, 561);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(233, 65);
            this.btn_DangXuat.TabIndex = 36;
            this.btn_DangXuat.Text = "   ĐĂNG XUẤT";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            this.btn_DangXuat.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_DangXuat.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbl_DoiMatKhau);
            this.panel1.Controls.Add(this.lbl_ThongTin);
            this.panel1.Controls.Add(this.lbl_TrangChu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 46);
            this.panel1.TabIndex = 37;
            // 
            // lbl_DoiMatKhau
            // 
            this.lbl_DoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("lbl_DoiMatKhau.Image")));
            this.lbl_DoiMatKhau.Location = new System.Drawing.Point(131, 7);
            this.lbl_DoiMatKhau.Name = "lbl_DoiMatKhau";
            this.lbl_DoiMatKhau.Size = new System.Drawing.Size(32, 32);
            this.lbl_DoiMatKhau.TabIndex = 37;
            this.lbl_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            this.lbl_DoiMatKhau.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_DoiMatKhau.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_ThongTin
            // 
            this.lbl_ThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ThongTin.Image")));
            this.lbl_ThongTin.Location = new System.Drawing.Point(65, 7);
            this.lbl_ThongTin.Name = "lbl_ThongTin";
            this.lbl_ThongTin.Size = new System.Drawing.Size(32, 32);
            this.lbl_ThongTin.TabIndex = 36;
            this.lbl_ThongTin.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_ThongTin.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1250, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.btn_KhachHang);
            this.Controls.Add(this.btn_BanAn);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.btn_MonAn);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TrangChu";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.panel_Center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_BanAn;
        private System.Windows.Forms.Button btn_MonAn;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Label lbl_TrangChu;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ThongTin;
        private System.Windows.Forms.Label lbl_DoiMatKhau;
    }
}