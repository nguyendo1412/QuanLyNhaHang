using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.DAO;
using System.Data;

namespace QuanLyNhaHang.BUS
{
    public class KhachHang_BUS
    {
        public static bool ThemKH(KhachHang_DTO kh)
        {
            bool kq = KhachHang_DAO.ThemKhachHang(kh);
            return kq;
        }
        public static DataTable Load_DSKH()
        {
            DataTable kq = KhachHang_DAO.Load_DSKH();
            return kq;
        }
    }
}
