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
    public partial class UserControlHoaDon : UserControl
    {
        frm_PhieuThanhToan frm;

        public UserControlHoaDon()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            frm = new frm_PhieuThanhToan();

            frm.Visible = true;
        }
    }
}
