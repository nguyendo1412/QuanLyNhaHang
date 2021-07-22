//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QuanLyNhaHang
//{
//    public class NhanVien
//    {
//        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-H8H6LR7; Initial Catalog = QL_NhaHang;Integrated Security=True");
//        DataSet ds = new DataSet();

//        //Load DS Nhân viên
//        public static DataTable Load_DSNhanVien()
//        {
//            string sql = "select MaNV as 'Mã NV', TenNV as 'Họ Tên', DienThoai as 'Điện Thoại',DiaChi as 'Địa Chỉ',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính', ChucVu as 'Chức Vụ', NgayVaoLam as 'Ngày VL' from NhanVien";
            
//            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

//            da.Fill(ds, "DSKH");

//            return ds.Tables["DSKH"];
//        }

//        //public DataTable Load_cboChucVu()
//        //{ 
//        //    string 
//        //}

//        public static bool KiemTraTrung_MaNV(string pMaNV)
//        {
//            bool kq;
//            string sql = "select * from NhanVien where MaNV = '" + pMaNV + "'";
//            DataTable dt = Connection.ExecuteQuery(sql);

//            if (dt.Rows.Count > 0)
//                kq = false;
//            else
//                kq = true;
//            return kq;
//        }

//        //Thêm NV
//        //public static bool ThemNhanVien(NhanVien_DTO nv)
//        //{
//        //    bool kq;
//        //    string sql = "insert into NhanVien(MaNV,TenNV, DienThoai, DiaChi, NgaySinh, GioiTinh,ChucVu, NgayVaoLam) values('" + nv.MaNV + "',N'" + nv.HoTen + "','" + nv.SDT + "', N'" + nv.DiaChi + "','" + nv.NgaySinh + "',N'" + nv.GioiTinh + "',N'" + nv.ChucVu + "','" + nv.NgayVL + "')";
//        //    kq = Connection.ExecuteNonQuery(sql);
//        //    return kq;
//        //}

//        //Thêm Nhân Viên
//        //public bool ThemNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
//        //{
//        //    try
//        //    {
//        //        if (conn.State == System.Data.ConnectionState.Closed)
//        //        {
//        //            conn.Open();
//        //        }


//        //        string sql = "insert into NhanVien(MaNV,TenNV, DienThoai, DiaChi, NgaySinh, GioiTinh,ChucVu, NgayVaoLam) values('" + pMaNV + "',N'" + pTenNV + "','" + pSDT + "', N'" + pDiaChi + "','" + pNgaySinh + "',N'" + pGioiTinh + "',N'" + pChucVu + "','" + pNgayVL + "')";

//        //        SqlCommand cmd = new SqlCommand(sql, conn);

//        //        cmd.ExecuteNonQuery();

//        //        if (conn.State == System.Data.ConnectionState.Open)
//        //        {
//        //            conn.Close();
//        //        }

//        //        return true;
//        //    }
//        //    catch
//        //    {
//        //        return false;
//        //    }
//        //}

//        //Sửa Nhân Viên
//        //public bool SuaNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
//        //{
//        //    try
//        //    {
//        //        if (conn.State == System.Data.ConnectionState.Closed)
//        //        {
//        //            conn.Open();
//        //        }

//        //        string sql = "update NhanVien set TenNV = N'" + pTenNV + "',DienThoai = '" + pSDT + "', DiaChi = N'" + pDiaChi + "',NgaySinh = '" + pNgaySinh + "', GioiTinh = N'" + pGioiTinh + "', ChucVu = N'" + pChucVu + "',NgayVaoLam = '" + pNgayVL + "' where MaNV = '" + pMaNV + "' ";

//        //        SqlCommand cmd = new SqlCommand(sql, conn);

//        //        cmd.ExecuteNonQuery();

//        //        if (conn.State == System.Data.ConnectionState.Open)
//        //        {
//        //            conn.Close();
//        //        }

//        //        return true;
//        //    }
//        //    catch
//        //    {
//        //        return false;
//        //    }
//        //}

//    }
//}
