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
    public partial class frm_ChangePassword : Form
    {
        Form frm;

        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_Change_Reset_Click(object sender, EventArgs e)
        {
            txt_Change_User.Clear();
            txt_Change_OldPass.Clear();
            txt_Change_NewPass.Clear();
            txt_Change_ConfirmPass.Clear();

            txt_Change_User.Focus();
        }

        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {
            txt_Change_OldPass.PasswordChar = '*';
            txt_Change_NewPass.PasswordChar = '*';
            txt_Change_ConfirmPass.PasswordChar = '*';
        }

        private void btn_Change_ChangePass_Click(object sender, EventArgs e)
        {
            frm = new frm_Login();
            frm.Visible = true;
            this.Visible = false;
        }

        private void frm_ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm = new frm_TrangChu();
            frm.Show();
        }
    }
}

