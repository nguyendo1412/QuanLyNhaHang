using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.DAO
{
    public class KhachHang_DAO
    {
        DataSet ds = new DataSet();
        //SqlDataAdapter da_Lop;

        //Load DSKH
        public static DataTable Load_DSKH()
        {
            string sql = "select * from KhachHang";
            DataTable dt = Connection.ExecuteQuery(sql);
            return dt;
        }

        //Thêm KH
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            bool kq;
            string sql = "insert into Khachhang(TenKH, NgaySinh, GioiTinh, DiaChi, DienThoai) values(N'" + kh.HoTen + "','" + kh.NgaySinh + "', N'" + kh.GioiTinh + "',N'" + kh.DiaChi + "','" + kh.SDT + "')";
            kq = Connection.ExecuteNonQuery(sql);
            return kq;
        }
    }
}
