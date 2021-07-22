using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class XuLy
    {
        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-S5UE9VQ2\\SQLEXPRESS; Initial Catalog = QL_NhaHang;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter da_ThemXoaSuaNV;
        SqlDataAdapter da_ThemXoaSuaKH;
        SqlDataAdapter da_ThemXoaSuaHD;
        SqlDataAdapter da_HDTam;
        SqlDataAdapter da_ThemXoaSuaCTHD;

        public XuLy()
        {
            Load_ThemNV();
            Load_ThemKH();
            Load_ThemHD();

            string sql = "select account.UserName, pass, nhanvien.manv from account,nhanvien where account.MaNV=nhanvien.MaNV";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "LOGIN");

            sql = "select tenmon,soluong,dongia,thanhtien from chitiet_hd,monan where monan.mamon = chitiet_hd.mamon";
            da_HDTam = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "HoaDonTam");

            sql = "select * from chitiet_hd";
            da_ThemXoaSuaCTHD = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "CTHoaDon");
        }
        //KHÁCH HÀNG
        //
        //Load DSKH
        public DataTable Load_DSKH()
        {
            string sql = "select * from KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSKH");

            return ds.Tables["DSKH"];
        }
        public bool KiemTraTrung_SDTKH(string pDienThoai)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from KhachHang where DienThoai = '" + pDienThoai + "'";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaKH.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //KT trùng SĐT KH
        public bool KiemTraTrung_SDTNV(string pDienThoai)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from NhanVien where DienThoai = '" + pDienThoai + "'";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaKH.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Thêm KH
        public void Load_ThemKH()
        {
            string sql = "select * from KhachHang";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaKH.Fill(ds, "ThemXoaSuaKH");
        }
        public bool ThemKH(string pTenKH, string pGioiTinh, string pDiaChi, string pDienThoai, string pTheTV, int pDiemTL)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaKH"].NewRow();

                dr_Them["MaKH"] = System.DBNull.Value;
                dr_Them["TenKH"] = pTenKH;
                dr_Them["GioiTinh"] = pGioiTinh;
                dr_Them["DiaChi"] = pDiaChi;
                dr_Them["DienThoai"] = pDienThoai;
                dr_Them["TheTV"] = pTheTV;
                dr_Them["DiemTL"] = pDiemTL;

                ds.Tables["ThemXoaSuaKH"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");

                return true;
            }
            catch { return false; }
        }
        //Xóa KH
        public bool XoaKH(string pMaKH)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaKH"].Rows.Count; i++)
                {
                    DataRow dr_Xoa = ds.Tables["ThemXoaSuaKH"].Rows[i];

                    if (dr_Xoa["MaKH"].ToString().Equals(pMaKH))
                    {
                        dr_Xoa.Delete();

                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                        da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");
                    }
                }

                return true;
            }
            catch { return false; }
        }
        //Sửa KH
        public bool SuaKH(string pMaKH, string pTenKH, string pSDT, string pDiaChi, string pGioiTinh, string pTheTV, int pDiemTL)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaKH"].Rows.Count; i++)
                {
                    DataRow dr_Sua = ds.Tables["ThemXoaSuaKH"].Rows[i];

                    if (dr_Sua["MaKH"].ToString().Equals(pMaKH))
                    {
                        if (!pTenKH.Equals(""))
                        {
                            dr_Sua[1] = pTenKH;
                        }
                        if (!pSDT.Equals(""))
                        {
                            dr_Sua[4] = pSDT;
                        }
                        if (!pDiaChi.Equals(""))
                        {
                            dr_Sua[3] = pDiaChi;
                        }
                        if (!pGioiTinh.Equals(""))
                        {
                            dr_Sua[2] = pGioiTinh;
                        }
                        if (!pTheTV.Equals(""))
                        {
                            dr_Sua[5] = pTheTV;
                        }
                        if (!pDiemTL.Equals(""))
                        {
                            dr_Sua[6] = pDiemTL;
                        }


                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                        da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //*****************************************************************************

        //Thêm CTHD
        public DataTable Load_gridCTHD(string pMaHD)
        {
            SqlDataAdapter da_Temp;

            DataTable dt_CTHD = new DataTable();

            string sql = "select TenMon, DonGia, SoLuong, TongMon from ChiTiet_HD where mahd = '" + pMaHD + "' ";

            da_Temp = new SqlDataAdapter(sql, conn);

            da_Temp.Fill(dt_CTHD);

            return dt_CTHD;
        }

        public void Load_ThemCTHD()
        {
            string sql = "select * from ChiTiet_HD";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaKH.Fill(ds, "ThemXoaSuaCTHD");
        }
        public bool ThemCTHD(string pMaHD, string pMaMon, string pTenMon, string pDonGia, string pSoLuong, string pTongMon)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaCTHD"].NewRow();


                dr_Them["MaHD"] = System.DBNull.Value;
                dr_Them["MaMon"] = pMaMon;
                dr_Them["TenMon"] = pTenMon;
                dr_Them["DonGia"] = pDonGia;
                dr_Them["SoLuong"] = pSoLuong;
                dr_Them["TongMon"] = float.Parse(pDonGia) * float.Parse(pSoLuong);


                ds.Tables["ThemXoaSuaCTHD"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");

                return true;
            }
            catch { return false; }
        }
        //Xóa hd
        public bool XoaCTHD(string pMaHD)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaCTHD"].Rows.Count; i++)
                {
                    DataRow dr_Xoa = ds.Tables["ThemXoaSuaCTHD"].Rows[i];

                    if (dr_Xoa["MaHD"].ToString().Equals(pMaHD))
                    {
                        dr_Xoa.Delete();

                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                        da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaCTHD");
                    }
                }

                return true;
            }
            catch { return false; }
        }
        //Sửa CThd
        public bool SuaCTHD(string pMaHD, string pMaMon, string pSoLuong)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaCTHD"].Rows.Count; i++)
                {
                    DataRow dr_Sua = ds.Tables["ThemXoaSuaCTHD"].Rows[i];

                    if (dr_Sua["MaHD"].ToString().Equals(pMaHD))
                    {
                        if (dr_Sua["MaMon"].ToString().Equals(pMaMon))
                        {
                            if (!pSoLuong.Equals(""))
                            {
                                dr_Sua[4] = pSoLuong;
                            }
                        }


                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                        da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //**************************************************************************************************************//

        //NHÂN VIÊN
        //
        //Load DSNV
        public DataTable Load_DSNV()
        {
            string sql = "select MaNV, tennv, username, dienthoai,diachi,ngaysinh, gioitinh,tenchucvu, ngayvaolam,luongcb  from NHANVIEN, CHUCVU WHERE NHANVIEN.QUYEN = CHUCVU.QUYEN";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSNV");

            return ds.Tables["DSNV"];
        }
        //Load combobox Chức Vụ
        public DataTable Load_CboChucVu()
        {
            string sql = "select * from ChucVu";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "ChucVu");

            return ds.Tables["ChucVu"];
        }
        //Lọc Nhân Viên theo Chức Vụ
        public DataTable LayDS_TheoChucVu(string pChucVu)
        {
            string sql = "select * from NhanVien where ChucVu = N'" + pChucVu + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LocNVTheoChucVu");

            return ds.Tables["LocNVTheoChucVu"];
        }
        //Lọc Nhân Viên theo Tên
        public DataTable LayDS_TheoTen(string pHoTen)
        {
            string sql = "select * from NhanVien where TenNV like N'%" + pHoTen + "%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LocNVTheoTen");

            return ds.Tables["LocNVTheoTen"];
        }
        //KT trùng Mã NV
        public bool KiemTraTrung_MaNV(string pMaNV)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from NhanVien where manv = '" + pMaNV + "'";

            da_ThemXoaSuaNV = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaNV.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Thêm NV
        public void Load_ThemNV()
        {
            string sql = "select * from NhanVien";

            da_ThemXoaSuaNV = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaNV.Fill(ds, "ThemXoaSuaNV");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaNV"].Columns[0];

            ds.Tables["ThemXoaSuaNV"].PrimaryKey = col_KhoaChinh;
        }
        public bool ThemNV(string pMaNV, string pTenNV, string pUser, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaNV"].NewRow();

                dr_Them["MaNV"] = pMaNV;
                dr_Them["TenNV"] = pTenNV;
                dr_Them["UserName"] = pUser;
                dr_Them["DienThoai"] = pSDT;
                dr_Them["DiaChi"] = pDiaChi;
                dr_Them["NgaySinh"] = pNgaySinh;
                dr_Them["GioiTinh"] = pGioiTinh;
                dr_Them["quyen"] = int.Parse(pChucVu);
                dr_Them["NgayVaoLam"] = pNgayVL;

                ds.Tables["ThemXoaSuaNV"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");

                return true;
            }
            catch { return false; }
        }
        //Xóa NV
        public bool XoaNV(string pMaNV)
        {
            try
            {
                DataRow dr_Xoa = ds.Tables["ThemXoaSuaNV"].Rows.Find(pMaNV);

                dr_Xoa.Delete();

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");

                return true;
            }
            catch { return false; }

        }
        //Sửa NV
        public bool SuaNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        {
            try
            {
                DataRow dr_Sua = ds.Tables["ThemXoaSuaNV"].Rows.Find(pMaNV);

                if (!pTenNV.Equals(""))
                {
                    dr_Sua[1] = pTenNV;
                }
                if (!pSDT.Equals(""))
                {
                    dr_Sua[3] = pSDT;
                }
                if (!pDiaChi.Equals(""))
                {
                    dr_Sua[4] = pDiaChi;
                }
                if (!pNgaySinh.Equals(""))
                {
                    dr_Sua[5] = pNgaySinh;
                }
                if (!pGioiTinh.Equals(""))
                {
                    dr_Sua[6] = pGioiTinh;
                }
                if (!pChucVu.Equals(""))
                {
                    dr_Sua[7] = pChucVu;
                }
                if (!pNgayVL.Equals(""))
                {
                    dr_Sua[8] = pNgayVL;
                }

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");
                return true;
            }
            catch { return false; }
        }
        //HÓA ĐƠN
        //

        //THỰC ĐƠN
        //
        //Load mon an
        public TreeNode[] loadTree()
        {
            TreeNode[] tns;
            string select = "select * from MONAN";
            SqlDataAdapter da = new SqlDataAdapter(select, conn);
            da.Fill(ds, "MonAn");
            select = "select * from NHOMMONAN";
            da = new SqlDataAdapter(select, conn);
            da.Fill(ds, "NhomMonAn");
            tns = new TreeNode[ds.Tables["NhomMonAn"].Rows.Count];

            for (int j = 0; j < ds.Tables["NhomMonAn"].Rows.Count; j++)
            {
                TreeNode tn = new TreeNode();
                tn.Text = ds.Tables["NhomMonAn"].Rows[j]["TenNhom"].ToString();

                for (int i = 0; i < ds.Tables["MonAn"].Rows.Count; i++)
                {
                    if (ds.Tables["MonAn"].Rows[i]["MaNhom"].ToString() == ds.Tables["NhomMonAn"].Rows[j]["MaNhom"].ToString())
                    {
                        TreeNode tn1 = new TreeNode();
                        tn1.Text = ds.Tables["MonAn"].Rows[i]["TenMon"].ToString() + " - " + ds.Tables["MonAn"].Rows[i]["DonGia"].ToString();
                        tn.Nodes.Add(tn1);
                    }
                }
                tns[j] = tn;
            }
            return tns;  

        }
        //

        //Load DS Hóa đơn
        //public DataTable Load_ChiTietHD()
        //{
        //    string sql = "select * from ChiTiet_HD";

        //    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

        //    da.Fill(ds, "CTHD");

        //    return ds.Tables["CTHD"];
        //}

        //ĐĂNG NHẬP
        //
        //
        public string dangnhap(string user, string pass)
        {
            ds.Tables["LOGIN"].Clear();

            string sql = "select account.UserName, pass, nhanvien.manv from account,nhanvien where account.MaNV=nhanvien.MaNV and account.UserName = '" + user + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LOGIN");
            if (ds.Tables["LOGIN"].Rows[0]["Pass"].ToString().Equals(pass))
            {
                return ds.Tables["LOGIN"].Rows[0]["MaNV"].ToString();
            }
            return null;
        }
        //public string LayMaNVTheoUser(string pUser)
        //{
        //    string sql = "select manv from nhanvien where UserName = '" + pUser + "'";

        //    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

        //    da.Fill(ds, "MaNV");

        //    return ds;
        //}




        //ĐẶT BÀN
        //lấy món theo tên
        //public DataRow LayMonTheoTen(string TenMon)
        //{
        //    DataRow dr = new DataRow();
        //    for (int i = 0; i < ds.Tables["MonAn"].Rows.Count; i++)
        //    {
        //        if (ds.Tables["MonAn"].Rows[i]["TenMon"].ToString().Equals(TenMon))
        //        {
        //            dr = ds.Tables["MonAn"].Rows[i];
        //        }
        //    }

        //}


        //
        //public SqlDataReader LuuDatBan(int maban, string trangthai, string monan, int dongia)
        //{
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //    conn.Open();
        //    SqlDataReader dr;
        //    SqlCommand cm = new SqlCommand("LuuDatBan", conn);
        //    cm.CommandType = CommandType.StoredProcedure;
        //    cm.Parameters.AddWithValue("@maban", maban);
        //    cm.Parameters.AddWithValue("@trangthai", trangthai);
        //    cm.Parameters.AddWithValue("@monan", monan);
        //    cm.Parameters.AddWithValue("@dongia", dongia);
        //    dr = cm.ExecuteReader();
        //    return dr;

        //}
        //public SqlDataReader LayTrangThaiBan(int maban)
        //{
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //    conn.Open();
        //    SqlDataReader dr;
        //    SqlCommand cm = new SqlCommand("LayTrangThaiBan", conn);
        //    cm.CommandType = CommandType.StoredProcedure;
        //    cm.Parameters.AddWithValue("@maban", maban);
        //    dr = cm.ExecuteReader();
        //    return dr;

        //}

        //Tự động thêm hđ khi đặt bàn
        public void Load_ThemHD()
        {
            string sql = "select * from HoaDon";

            da_ThemXoaSuaHD = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaHD.Fill(ds, "ThemXoaSuaHD");

            //DataColumn[] col_KhoaChinh = new DataColumn[1];

            //col_KhoaChinh[0] = ds.Tables["ThemXoaSuaNV"].Columns[0];

            //ds.Tables["ThemXoaSuaNV"].PrimaryKey = col_KhoaChinh;
        }

        public bool ThemHD(string pMaNV, string pMaKH, string pMaBan, string pTongTien, string pNgayLap)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaHD"].NewRow();

                dr_Them["MaNV"] = pMaNV;
                dr_Them["MaKH"] = pMaKH;
                dr_Them["MaBan"] = pMaBan;
                dr_Them["TongTien"] = System.DBNull.Value;
                dr_Them["NgayLap"] = pNgayLap;

                ds.Tables["ThemXoaSuaHD"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaHD);

                da_ThemXoaSuaHD.Update(ds, "ThemXoaSuaHD");

                return true;
            }
            catch { return false; }
        }
        //thống kê
        //    public DataTable ThongKe(int thang)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        SqlCommand cm = new SqlCommand("ThongKe", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        cm.Parameters.AddWithValue("@thang", thang);
        //        SqlDataAdapter da = new SqlDataAdapter(cm);
        //        da.Fill(ds, "ThongKe");
        //        return ds.Tables["ThongKe"];

        //    }
        //    public DataTable ThongKeTheoNgay(int ngaydau, int thangdau, int thangcuoi)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        SqlCommand cm = new SqlCommand("ThongKeTheoNgay", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        cm.Parameters.AddWithValue("@ngaydau", ngaydau);
        //        cm.Parameters.AddWithValue("@thangdau", thangdau);
        //        cm.Parameters.AddWithValue("@thangcuoi", thangcuoi);
        //        SqlDataAdapter da = new SqlDataAdapter(cm);
        //        da.Fill(ds, "ThongKeTheoNgay");
        //        return ds.Tables["ThongKeTheoNgay"];

        //    }
        //    public SqlDataReader XoaThongKe(int ma)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        SqlDataReader dr;
        //        SqlCommand cm = new SqlCommand("XoaThongKe", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        cm.Parameters.AddWithValue("@ma", ma);
        //        dr = cm.ExecuteReader();
        //        return dr;

        //    }
        //    public SqlDataReader LayThoiGian(int ma)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        SqlDataReader dr;
        //        SqlCommand cm = new SqlCommand("LayThoiGian", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        cm.Parameters.AddWithValue("@ma", ma);
        //        dr = cm.ExecuteReader();
        //        return dr;
        //    }
        //    public SqlDataReader LayQuyenNhanVien(string nv)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        SqlDataReader dr;
        //        SqlCommand cm = new SqlCommand("LayQuyenNhanVien", conn);
        //        cm.CommandType = CommandType.StoredProcedure;
        //        cm.Parameters.AddWithValue("@nhanvien", nv);
        //        dr = cm.ExecuteReader();
        //        return dr;
        //    }
        //}
    }
}