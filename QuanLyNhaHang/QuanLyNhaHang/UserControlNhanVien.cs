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
    public partial class UserControlNhanVien : UserControl
    {
        XuLy dt = new XuLy();

        public UserControlNhanVien()
        {
            InitializeComponent();
        }
        private void HiddenControl()
        {
            txt_MaNV.Enabled = false;
            txt_User.Enabled = false;
            cbo_ChucVu.Enabled = false;
            txt_HoTen.Enabled = false;
            txt_SDT.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_NgaySinh.Enabled = false;
            txt_NgayVL.Enabled = false;
            rdo_Nam.Enabled = false;
            rdo_Nu.Enabled = false;
        }
        private void DisplayControl()
        {
            txt_MaNV.Enabled = true;
            cbo_ChucVu.Enabled = true;
            txt_HoTen.Enabled = true;
            txt_SDT.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_NgaySinh.Enabled = true;
            txt_NgayVL.Enabled = true;
            rdo_Nam.Enabled = true;
            rdo_Nu.Enabled = true;
        }
        private void DisplayButton()
        {
            btn_XoaNV.Visible = true;
            btn_ThemNV.Visible = true;
            btn_SuaNV.Visible = true;
            btn_LuuThemNV.Visible = false;
            btn_LuuSuaNV.Visible = false;
            btn_Huy.Visible = false;

        }
        private void ClearTextBox()
        {
            txt_MaNV.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_User.Clear();
            txt_NgayVL.Clear();
            txt_NgaySinh.Clear();
        }


        private void UserControlNhanVien_Load(object sender, EventArgs e)
        {
            txt_MaNV.Text = "Nhập mã nhân viên";
            txt_MaNV.ForeColor = Color.Gray;
            txt_User.Text = "User";
            txt_User.ForeColor = Color.Gray;

            HiddenControl();

            cbo_ChucVu.DataSource = dt.Load_CboChucVu();
            cbo_ChucVu.DisplayMember = "TenChucVu";
            cbo_ChucVu.ValueMember = "quyen";

            grid_DSNV.DataSource = dt.Load_DSNV();
            
        }

        //Mã Nhân Viên
        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                txt_User.Text = "User";
            }
        }
        private void txt_MaNV_Enter(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_MaNV.ForeColor = Color.Black;
        }
        private void txt_MaNV_Leave(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                txt_MaNV.Text = "Nhập mã nhân viên";
                txt_MaNV.ForeColor = Color.Gray;
                txt_User.Text = "User";
            }
            else
                txt_User.Text = txt_MaNV.Text;
        }

        //Địa chỉ
        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '/') && (e.KeyChar != ','))
                e.Handled = true;
        }

        //Xử lý Button
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            DisplayControl();
            ClearTextBox();

            btn_ThemNV.Visible = false;
            btn_LuuThemNV.Visible = true;
            btn_SuaNV.Visible = false;
            btn_Huy.Visible = true;

        }
        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            DisplayControl();

            grid_DSNV.ReadOnly = false;
            grid_DSNV.CurrentRow.Cells[0].ReadOnly = true;

            txt_MaNV.Enabled = false;

            btn_LuuSuaNV.Visible = true;
            btn_LuuThemNV.Visible = true;
            btn_SuaNV.Visible = false;
            btn_ThemNV.Visible = false;
            btn_XoaNV.Visible = false;
            btn_Huy.Visible = true;
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            grid_DSNV.ReadOnly = false;

            txt_MaNV.Text = "Nhập mã nhân viên";
            txt_MaNV.ForeColor = Color.Gray;
            txt_User.Text = "User";
            txt_User.ForeColor = Color.Gray;

            HiddenControl();

            btn_LuuThemNV.Visible = false;
            btn_SuaNV.Visible = true;
            btn_ThemNV.Visible = true;
            btn_XoaNV.Visible = true;
            btn_Huy.Visible = false;
        }
        private void btn_LuuThemNV_Click(object sender, EventArgs e)
        {
            //Duyệt radio, lấy text
            string rdo_Checked;

            if (rdo_Nam.Checked)
            {
                rdo_Checked = "Nam";
            }
            else
            {
                rdo_Checked = "Nữ";
            }
            //Kết nối thêm nhân viên

            if (dt.KiemTraTrung_MaNV(txt_MaNV.Text) && dt.KiemTraTrung_SDTNV(txt_SDT.Text))
            {
                if (dt.ThemNV(txt_MaNV.Text, txt_HoTen.Text, txt_User.Text, txt_SDT.Text, txt_DiaChi.Text, txt_NgaySinh.Text, rdo_Checked, cbo_ChucVu.SelectedValue.ToString(), txt_NgayVL.Text))
                {
                    MessageBox.Show("Thêm nhân viên thành công !");
                    ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                    grid_DSNV.DataSource = dt.Load_DSNV();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên hoặc sdt đã tồn tại !!");
            }

        }
        //Clear khi click textbox
        private void txt_Input_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Clear();
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

        private void btn_LuuSuaNV_Click(object sender, EventArgs e)
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
            //Kết nối sửa nhân viên
            if (dt.SuaNV(txt_MaNV.Text, txt_HoTen.Text, txt_SDT.Text, txt_DiaChi.Text, txt_NgaySinh.Text, rdo_Checked, cbo_ChucVu.SelectedValue.ToString(), txt_NgayVL.Text) == true)
            {
                MessageBox.Show("Sửa nhân viên thành công !");
                ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                grid_DSNV.DataSource = dt.Load_DSNV();
            }
            else
                MessageBox.Show("Sửa nhân viên thất bại !");
        }

        private void cbo_SearchChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_SearchChucVu.Text == "Tất cả")
                {
                    ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                    grid_DSNV.DataSource = dt.Load_DSNV();
                }
                else
                {
                    ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                    grid_DSNV.DataSource = dt.LayDS_TheoChucVu(cbo_SearchChucVu.Text);
                }
            }
            catch
            {
            }

        }

        private void btn_SearchNV_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                grid_DSNV.DataSource = dt.LayDS_TheoTen(txt_SearchTenNV.Text);
            }
            catch
            {
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (grid_DSNV.RowCount > 0)
            {
                if (dt.XoaNV(grid_DSNV.CurrentRow.Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này? Điều này sẽ làm mất dữ liệu về nhân viên bạn vừa xóa.", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                            MessageBox.Show("Xóa nhân viên thành công !");
                            ((DataTable)grid_DSNV.DataSource).Rows.Clear();
                            grid_DSNV.DataSource = dt.Load_DSNV();
                    }
                }
                else
                    MessageBox.Show("Xóa nhân viên thất bại !");
            }
            else
                MessageBox.Show("Không có nhân viên để xóa");
        }

        private void grid_DSNV_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            txt_HoTen.Text = grid_DSNV.CurrentRow.Cells[1].Value.ToString();
            txt_User.Text = grid_DSNV.CurrentRow.Cells[2].Value.ToString();
            txt_SDT.Text = grid_DSNV.CurrentRow.Cells[3].Value.ToString();
            txt_DiaChi.Text = grid_DSNV.CurrentRow.Cells[4].Value.ToString();
            cbo_ChucVu.Text = grid_DSNV.CurrentRow.Cells[7].Value.ToString();
            txt_NgaySinh.Text = grid_DSNV.CurrentRow.Cells[5].Value.ToString();
            txt_NgayVL.Text = grid_DSNV.CurrentRow.Cells[8].Value.ToString();

            grid_DSNV.ReadOnly = true;
        }

        private void grid_DSNV_SelectionChanged(object sender, EventArgs e)
        {

        }

        




    }
}
