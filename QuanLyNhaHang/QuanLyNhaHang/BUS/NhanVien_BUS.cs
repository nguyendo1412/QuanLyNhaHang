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
    class NhanVien_BUS
    {
        public static bool ThemNhanVien(NhanVien_DTO nd)
        {
            return NhanVien_DAO.ThemNhanVien(nd);
        }
        public static bool KiemTraTrung_MaNV(string pMaNV)
        {
            return NhanVien_DAO.KiemTraTrung_MaNV(pMaNV);
        }

        public static DataTable Load_DSNhanVien()
        {
            return NhanVien_DAO.Load_DSNhanVien();
        }
    }
}
