using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class UserControlKhachHang : UserControl
    {
        XuLy dt = new XuLy();
        Form frm;

        public UserControlKhachHang()
        {
            InitializeComponent();
        }
        public void DisplayControl()
        {
            txt_DiaChi.Enabled = true;
            txt_HoTen.Enabled = true;
            txt_SDT.Enabled = true;
            txt_TheTV.Enabled = false;
        }
        public void HiddenControl()
        {
            txt_DiaChi.Enabled = false;
            txt_HoTen.Enabled = false;
            txt_SDT.Enabled = false;
            txt_TheTV.Enabled = false;
            group_SuaKH.Enabled = false;
            lbl_XacNhan.Enabled = false;
            lbl_Huy.Enabled = false;
            txt_MaKH.Enabled = false;
        }
        //Xử lý Button
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm = new frm_ThemKH();
            frm.ShowDialog();

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Sua.Visible = true;
            btn_Them.Visible = true;
            btn_Xoa.Visible = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DisplayControl();

            group_SuaKH.Enabled = true;
            lbl_XacNhan.Enabled = true;
            lbl_Huy.Enabled = true;

            grid_DSKH.ReadOnly = false;

            if (grid_DSKH.RowCount > 0)
            {
                grid_DSKH.CurrentRow.Cells[0].ReadOnly = true;
                grid_DSKH.CurrentRow.Cells[5].ReadOnly = true;
            }
        }

        public void UserControlKhachHang_Load(object sender, EventArgs e)
        {
            HiddenControl();

            grid_DSKH.DataSource = dt.Load_DSKH();
            grid_DSKH.ReadOnly = true;
        }

        private void btn_LoadDSKH_Click(object sender, EventArgs e)
        {
            ((DataTable)grid_DSKH.DataSource).Rows.Clear();
            grid_DSKH.DataSource = dt.Load_DSKH();

            grid_DSKH.ReadOnly = true;
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (grid_DSKH.RowCount > 0)
            {
                if (dt.XoaKH(grid_DSKH.CurrentRow.Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này? Điều này sẽ làm mất dữ liệu về khách hàng bạn vừa xóa.", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        MessageBox.Show("Xóa khách hàng thành công !");
                        ((DataTable)grid_DSKH.DataSource).Rows.Clear();
                        grid_DSKH.DataSource = dt.Load_DSKH();
                    }
                }
                else
                    MessageBox.Show("Xóa khách hàng thất bại !");
            }
            else
                MessageBox.Show("Không có khách hàng để xóa !");
        }

        private void lbl_XacNhan_Click(object sender, EventArgs e)
        {
            string rdo_Checked;

            if (rdo_Nam.Checked)
            {
                rdo_Checked = "Nam";
            }
            else
            {
                rdo_Checked = "Nữ";
            }
            //Kết nối sửa khách hàng
            if (dt.SuaKH(txt_MaKH.Text, txt_HoTen.Text, txt_SDT.Text, txt_DiaChi.Text, rdo_Checked, txt_TheTV.Text, int.Parse(txt_DiemTL.Text)) == true)
            {
                MessageBox.Show("Sửa khách hàng thành công !");
                ((DataTable)grid_DSKH.DataSource).Rows.Clear();
                grid_DSKH.DataSource = dt.Load_DSKH();
                HiddenControl();
            }
            else
                MessageBox.Show("Sửa khách hàng thất bại !");


        }

        private void lbl_Huy_Click(object sender, EventArgs e)
        {
            HiddenControl();
        }

        private void grid_DSKH_SelectionChanged(object sender, EventArgs e)
        {
            HiddenControl();

            if (grid_DSKH.CurrentRow != null)
            {
                txt_HoTen.Text = grid_DSKH.CurrentRow.Cells[1].Value.ToString();
                txt_SDT.Text = grid_DSKH.CurrentRow.Cells[4].Value.ToString();
                txt_DiaChi.Text = grid_DSKH.CurrentRow.Cells[3].Value.ToString();
                txt_TheTV.Text = grid_DSKH.CurrentRow.Cells[5].Value.ToString();
                txt_MaKH.Text = grid_DSKH.CurrentRow.Cells[0].Value.ToString();

                if (grid_DSKH.CurrentRow.Cells[2].Value.ToString() == "Nam")
                    rdo_Nam.Checked = true;
                else if (grid_DSKH.CurrentRow.Cells[2].Value.ToString() == "Nữ")
                    rdo_Nu.Checked = true;
            }
        }

        private void grid_DSKH_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            txt_HoTen.Text = grid_DSKH.CurrentRow.Cells[1].Value.ToString();
            txt_SDT.Text = grid_DSKH.CurrentRow.Cells[4].Value.ToString();
            txt_DiaChi.Text = grid_DSKH.CurrentRow.Cells[3].Value.ToString();
            txt_TheTV.Text = grid_DSKH.CurrentRow.Cells[5].Value.ToString();

            if (grid_DSKH.CurrentRow.Cells[2].Value.ToString() == "Nam")
                rdo_Nam.Checked = true;
            else
                rdo_Nu.Checked = false;


            grid_DSKH.ReadOnly = true;
        }



    }
}

