using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyNhaHang
{
    public partial class UserControlThucDon : UserControl
    {
        //Form frm;
        XuLy dt = new XuLy();

        public UserControlThucDon()
        {
            InitializeComponent();
        }
        private void UserControlThucDon_Load(object sender, EventArgs e)
        {
            tree_Food.Nodes.AddRange(dt.loadTree());
        }
        private void tree_Food_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txt_MonDangChon.Text = tree_Food.SelectedNode.Text;
        }
       
    }
}
