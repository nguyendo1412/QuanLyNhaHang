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
    
    public partial class NHOMMONAN
    {
        public NHOMMONAN()
        {
            this.MONANs = new HashSet<MONAN>();
        }
    
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
    
        public virtual ICollection<MONAN> MONANs { get; set; }
    }
}
