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
    
    public partial class ChiNhanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiNhanh()
        {
            this.HoaDon = new HashSet<HoaDon>();
            this.MatHangChiNhanh = new HashSet<MatHangChiNhanh>();
            this.NhanVienBanHang = new HashSet<NhanVienBanHang>();
        }
    
        public string maCN { get; set; }
        public string maQL { get; set; }
        public string tenCN { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
    
        public virtual QuanLy QuanLy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHangChiNhanh> MatHangChiNhanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVienBanHang> NhanVienBanHang { get; set; }
    }
}
