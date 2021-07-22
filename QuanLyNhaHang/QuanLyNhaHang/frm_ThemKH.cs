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
    public partial class frm_ThemKH : Form
    {
        UserControlKhachHang userKH = new UserControlKhachHang();
        XuLy dt = new XuLy();

        public frm_ThemKH()
        {
            InitializeComponent();
        }

        private void lbl_XacNhan_Click(object sender, EventArgs e)
        {
            //Duyệt radio, lấy text
            string rdo_Checked;

            if (rdo_Nam.Checked)
                rdo_Checked = "Nam";
            else
                rdo_Checked = "Nữ";
            //Kết nối thêm nhân viên

            //if (txt_MaNV.Text != "" && txt_HoTen.Text != "" && txt_SDT.Text != "" && txt_DiaChi.Text != "" && cbo_ChucVu.SelectedText.ToString() != "Chức vụ" && txt_NgaySinh.MaskCompleted == true && txt_NgayVL.MaskCompleted == true)
            //{
            if (dt.KiemTraTrung_SDTKH(txt_SDT.Text))
            {
                if (dt.ThemKH(txt_HoTen.Text, rdo_Checked, txt_DiaChi.Text, txt_SDT.Text, txt_TheTV.Text,int.Parse(txt_DiemTL.Text)))
                {
                    MessageBox.Show("Thêm khách hàng thành công !");
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Thêm khách hàng thất bại !");
            }
            else
                MessageBox.Show("SĐT đã được sử dụng !!");


        }
        private void lbl_Huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        //XỬ LÝ TEXTBOX

        //Địa chỉ
        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '/') && (e.KeyChar != ','))
                e.Handled = true;
        }

        //Nhập số
        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        //Nhập chữ
        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void frm_ThemKH_Leave(object sender, EventArgs e)
        {
            //this.Close();
        }



    }
}
