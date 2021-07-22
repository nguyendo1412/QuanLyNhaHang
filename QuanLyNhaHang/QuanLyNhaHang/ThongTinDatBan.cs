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
    public partial class ThongTinDatBan : Form
    {
        XuLy dt = new XuLy();

        public ThongTinDatBan()
        {
            InitializeComponent();
        }
        
        private void ThongTinDatBan_Load(object sender, EventArgs e)
        {
            tree_Food.Nodes.AddRange(dt.loadTree());

            //grid_OrderMonAn.

        }

        private void tree_Food_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_MonDangChon.Text = tree_Food.SelectedNode.Text;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            //dt.ThemHD(manv, txt_TenKH.Text)
        }

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {

        }
    }
}
