using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;

namespace QuanLyNhaHang
{
    public partial class frm_Login : Form
    {
        Form frm;
        XuLy dt = new XuLy();
        public string manv;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_LoginReset_Click(object sender, EventArgs e)
        {
            txt_LoginUser.Clear();
            txt_LoginPass.Clear();
            txt_LoginUser.Focus();
        }

        private void btn_LoginCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
        private void frm_Login_Shown(object sender, EventArgs e)
        {
            txt_LoginUser.Focus();
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
                this.errorProvider1.SetError(ctr, "Vui lòng nhập dữ liệu");
            else
                this.errorProvider1.Clear();
        }
        private void txtInput_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length == 0)
                this.errorProvider1.SetError(ctr, "Vui lòng nhập dữ liệu");
            else
                this.errorProvider1.Clear();
        }

        private void btn_LoginLogin_Click(object sender, EventArgs e)
        {
            if (txt_LoginUser.Text != "" && txt_LoginPass.Text != "")
            {
                if (dt.dangnhap(txt_LoginUser.Text, txt_LoginPass.Text) != null)
                {
                    manv = dt.dangnhap(txt_LoginUser.Text, txt_LoginPass.Text);
                    //Global.GlobalVar = txt_LoginUser.Text;
                    frm = new frm_TrangChu();
                    frm.Visible = true;

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                if (txt_LoginUser.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_LoginPass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập nhập password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txt_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                btn_LoginLogin_Click(sender, e);
                //txt_LoginUser.Clear();
                //txt_LoginPass.Clear();
            }
            
        }

        private void link_LoginChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm = new frm_ChangePassword();

            frm.ShowDialog();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lb_LoginTime.Text = DateTime.Now.ToString();
            //manv = txt_LoginUser.Text;
        }
    }
}