using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class Connection
    {
        //Chuỗi Kết Nối
        private static String _connectionString = @"Data Source = DESKTOP-H8H6LR7; Initial Catalog = QL_NhaHang; User = sa; Password = sa2012";

        //ExecuteQuery : Select
        public static DataTable ExecuteQuery(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(_connectionString);

            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(dt);

            connect.Close();

            return dt;
        }
        //ExecuteNonQuery: Insert, Update, Delete
        public static bool ExecuteNonQuery(String sql)
        {
            bool kq;

            SqlConnection connect = new SqlConnection(_connectionString);

            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;

            int n = command.ExecuteNonQuery();

            if (n > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }

            connect.Close();

            return kq;
        }

        //View Stored Procedure
        public static DataTable ViewStoredProc(string procName, int SoHD)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(_connectionString);
            SqlCommand command = connect.CreateCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHD", SoHD);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }



        //public bool KT_KetNoi()
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        return true;
        //    }
        //    catch { return false; }
        //}

        List<string> ds_ChucVu = new List<string>();

        //Load combobox
        public object[] ListComboBox()
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                if (connect.State == System.Data.ConnectionState.Closed)
                {
                    connect.Open();
                }

                string sql = "select TenChucVu from ChucVu";

                SqlCommand cmd = new SqlCommand(sql, connect);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string giatri = rd["TenChucVu"].ToString();
                    ds_ChucVu.Add(giatri);
                }

                rd.Close();

                if (connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }

                object[] kq = new object[ds_ChucVu.Count];

                for (int i = 0; i < ds_ChucVu.Count; i++)
                {
                    kq[i] = ds_ChucVu[i];
                }
                return kq;
            }
            catch { return null; }
        }


        //List<nvDTO> dsnv = new List<nvDTO>();
        ////Thêm Khách Hàng
        //public bool ThemKH(string pTenKH, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh)
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }

        //        string sql = "insert into KHACHHANG(TenKH, DienThoai, DiaChi, NgaySinh, GioiTinh) values(N'" + pTenKH + "','" + pSDT + "',N'" + pDiaChi + "','" + pNgaySinh + "',N'" + pGioiTinh + "')";

        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        cmd.ExecuteNonQuery();

        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public DataTable getNhanVien()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien",conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        ////Thêm Nhân Viên
        //public bool ThemNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }


        //        string sql = "insert into NhanVien(MaNV,TenNV, DienThoai, DiaChi, NgaySinh, GioiTinh,ChucVu, NgayVaoLam) values('" + pMaNV + "',N'" + pTenNV + "','" + pSDT + "', N'" + pDiaChi + "','" + pNgaySinh + "',N'" + pGioiTinh + "',N'" + pChucVu + "','" + pNgayVL + "')";

        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        cmd.ExecuteNonQuery();

        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        ////Sửa Nhân Viên
        //public bool SuaNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }

        //        string sql = "update NhanVien set TenNV = N'" + pTenNV + "',DienThoai = '" + pSDT + "', DiaChi = N'" + pDiaChi + "',NgaySinh = '" + pNgaySinh + "', GioiTinh = N'" + pGioiTinh + "', ChucVu = N'" + pChucVu + "',NgayVaoLam = '" + pNgayVL + "' where MaNV = '" + pMaNV + "' ";

        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        cmd.ExecuteNonQuery();

        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

    }
}
