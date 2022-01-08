//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvenienceStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.HoaDonSanPhams = new HashSet<HoaDonSanPham>();
        }
    
        public string maHD { get; set; }
        public string maNVBH { get; set; }
        public string maCa { get; set; }
        public string maCN { get; set; }
        public Nullable<System.DateTime> ngayLap { get; set; }
        public Nullable<double> tongTien { get; set; }
    
        public virtual CaLam CaLam { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual NhanVienBanHang NhanVienBanHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonSanPham> HoaDonSanPhams { get; set; }
    }
}
