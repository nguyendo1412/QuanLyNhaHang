using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class KhachHang_DTO
    {
        private string _MaKH;
        private string _HoTen;
        private string _NgaySinh;
        private string _SDT;
        private string _DiaChi;
        private string _GioiTinh;
        private string _TheTV;
        private string _DiemTL;

        //Phương thức khởi tạo mặc định
        public KhachHang_DTO()
        {
            _MaKH = "";
            _HoTen = "";
            _SDT = "";
            _DiaChi = "";
            _GioiTinh = "";
            _NgaySinh = "";
            _TheTV = "";
            _DiemTL = "";
        }

        //Phương thức khởi tạo có tham số
        public KhachHang_DTO(string pMaKH, string pHoTen, string pNgaySinh, string pGioiTinh, string pDiaChi, string pSDT, string pTheTV, string pDiemTL)
        {
            _MaKH = pMaKH;
            _HoTen = pHoTen;
            _SDT = pSDT;
            _DiaChi = pDiaChi;
            _NgaySinh = pNgaySinh;
            _TheTV = pTheTV;
            _GioiTinh = pGioiTinh;
            _DiemTL = pDiemTL;
        }

        //Phương thức khởi tạo sao chép.
        public KhachHang_DTO(KhachHang_DTO kh)
        {
            _MaKH = kh._MaKH;
            _HoTen = kh._HoTen;
            _NgaySinh = kh._NgaySinh;
            _SDT = kh._SDT;
            _DiaChi = kh._DiaChi;
            _TheTV = kh._TheTV;
            _GioiTinh = kh._GioiTinh;
            _DiemTL = kh._DiemTL;
        }

        //Properties
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string ChucVu
        {
            get { return _DiemTL; }
            set { _DiemTL = value; }
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
            get { return _TheTV; }
            set { _TheTV = value; }
        }


    }
}
