using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frm_TrangChu : Form
    {
        UserControl us;
        Form frm;
        
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        private void click()
        {
            btn_BanAn.BackColor = Color.Bisque;
            btn_HoaDon.BackColor = Color.Bisque;
            btn_ThongKe.BackColor = Color.Bisque;
            btn_MonAn.BackColor = Color.Bisque;
            btn_NhanVien.BackColor = Color.Bisque;

        }
        //Add UserControl 
        private void showUserControls(UserControl user)
        {
            panel_Center.Controls.Add(user);
            user.BringToFront();
        }
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            lbl_TrangChu.BackColor = Color.AliceBlue;
        }

        //Hiển thị Ảnh động
        int time = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 2)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home1.jpg");
            else if (time == 4)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home2.jpg");
            else if (time == 6)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home3.jpg");
            else if (time == 8)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home4.jpg");
            else if (time == 10)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home5.jpg");
            else if (time == 12)
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home6.png");
            else if (time == 14)
            {
                pictureBox1.Image = Image.FromFile("..\\..\\img\\Home7.jpg");
                time = 0;
                timer1.Stop();
                timer1.Start();
            }
        }
        //Khi Hover vào button
        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.AliceBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Bisque;
        }

        //Hover vào label
        private void lbl_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.AliceBlue;
        }
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Bisque;
        }
        //Xử lý Button
        public void btn_NhanVien_Click(object sender, EventArgs e)
        {
            us = new UserControlNhanVien();
            showUserControls(us);
            click();
            btn_NhanVien.BackColor = Color.AliceBlue;
        }

        private void btn_BanAn_Click(object sender, EventArgs e)
        {
            us = new UserControlDatBan();
            showUserControls(us);
            click();
            btn_BanAn.BackColor = Color.AliceBlue;
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            frm = new frm_TrangChu();
            frm.Visible = true;
            this.Visible = false;
            click();
        }
        private void btn_MonAn_Click(object sender, EventArgs e)
        {
            us = new UserControlThucDon();
            showUserControls(us);
            click();
            btn_MonAn.BackColor = Color.AliceBlue;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            us = new UserControlHoaDon();
            showUserControls(us);
            click();
            btn_HoaDon.BackColor = Color.AliceBlue;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            us = new UserControlThongKe();
            showUserControls(us);
            click();
            btn_ThongKe.BackColor = Color.AliceBlue;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm = new frm_Login();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm = new frm_ChangePassword();
            frm.ShowDialog();
            this.Visible = false;
        }

        public void btn_KhachHang_Click(object sender, EventArgs e)
        {
            us = new UserControlKhachHang();
            showUserControls(us);
            click();
            btn_KhachHang.BackColor = Color.AliceBlue;
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {

        }


        
    }
}
