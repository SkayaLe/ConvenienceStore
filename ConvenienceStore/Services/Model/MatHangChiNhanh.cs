//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatHangChiNhanh
    {
        public string maMH { get; set; }
        public string maCN { get; set; }
        public Nullable<int> soLuong { get; set; }
    
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}
