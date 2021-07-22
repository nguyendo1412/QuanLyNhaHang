using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class NhanVien_DTO
    {
        private string _MaNV;
        private string _HoTen;
        private string _ChucVu;
        private string _NgaySinh;
        private string _SDT;
        private string _DiaChi;
        private string _GioiTinh;
        private string _NgayVL;

        //Phương thức khởi tạo mặc định
        public NhanVien_DTO()
        {
            _MaNV = "";
            _HoTen = "";
            _ChucVu = "";
            _SDT = "";
            _DiaChi = "";
            _GioiTinh = "";
            _NgaySinh = "";
            _NgayVL = "";
        }

        //Phương thức khởi tạo có tham số
        public NhanVien_DTO(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        {
            _MaNV = pMaNV;
            _HoTen = pTenNV;
            _SDT = pSDT;
            _DiaChi = pDiaChi;
            _NgaySinh = pNgaySinh;
            _ChucVu = pChucVu;
            _GioiTinh = pGioiTinh;
            _NgayVL = pNgayVL;
        }

        //Phương thức khởi tạo sao chép.
        public NhanVien_DTO(NhanVien_DTO nv)
        {
            _MaNV = nv._MaNV;
            _HoTen = nv._HoTen;
            _NgaySinh = nv._NgaySinh;
            _SDT = nv._SDT;
            _DiaChi = nv._DiaChi;
            _ChucVu = nv._ChucVu;
            _GioiTinh = nv._GioiTinh;
            _NgayVL = nv._NgayVL;
        }

        //Properties
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public string NgayVL
        {
            get { return _NgayVL; }
            set { _NgayVL = value; }
        }

       
    }
}
