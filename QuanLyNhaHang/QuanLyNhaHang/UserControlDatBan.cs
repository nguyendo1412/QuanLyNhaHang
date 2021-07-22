using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;

namespace QuanLyNhaHang
{
    public partial class UserControlDatBan : UserControl
    {
        Form frm;
        List<Button> lstbutton;
        XuLy dt = new XuLy();
        string manv = Program.login.manv;
        public string ban = null;


        public UserControlDatBan()
        {
            InitializeComponent();
            lstbutton = new List<Button>();
            txt_TenBan.Enabled = false;
            txt_NhanVien.Enabled = false;
            txt_SDT.Enabled = false;
            txt_TimeHD.Enabled = false;
            txt_NgayHD.Enabled = false;
            txt_SDT.Enabled = false;
        }
       


        private void btn_DoiBan_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstbutton)
            {
                if (btn.BackColor == Color.Orange)
                {
                    btn.Enabled = true;
                    //if (btn.BackColor == Color.Orange)
                    //{
                    //    btn.BackColor = Color.Lavender;

                    //}
                    //btn.Enabled = false;
                }
                else
                    MessageBox.Show("Chọn bàn cần đổi");
            }


            //int id1 = (lsvBill.Tag as Table).ID;

            //int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            //if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //{
            //    TableDAO.Instance.SwitchTable(id1, id2);

            //    LoadTable();
            //}
     
       

        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lstbutton)
            {
                if (btn.BackColor == Color.Aqua)
                {
                    btn.BackColor = Color.Orange;
                    btn.Enabled = false;
                }
            }
            //if (dt.ThemHD(Global.GlobalVar,txt_MaKH.Text, ban, null, DateTime.Now.Date.ToString()))
                if (dt.ThemHD(manv, txt_MaKH.Text, ban, null, DateTime.Now.Date.ToString()))
                MessageBox.Show("Đặt bàn thành công");
            else
                MessageBox.Show("Lỗi");
        }
        private void btn_ChonBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor != Color.Orange)
            {
                if (btn.BackColor == Color.Lavender)
                {
                    lstbutton.Remove(btn);
                    btn.BackColor = Color.Aqua;
                    lstbutton.Add(btn);
                }
                else if (btn.BackColor == Color.Aqua)
                {
                    lstbutton.Remove(btn);
                    btn.BackColor = Color.Lavender;
                    lstbutton.Add(btn);
                }

                ban = btn.Text;
            }

            //frm = new ThongTinDatBan();
            //frm.ShowDialog();
        }




    }
}
