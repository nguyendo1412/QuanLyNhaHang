//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTHANHTOAN
    {
        public string SoPhieu { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<double> TongTien { get; set; }
        public string MaNV { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string MaBan { get; set; }
    
        public virtual BANAN BANAN { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
