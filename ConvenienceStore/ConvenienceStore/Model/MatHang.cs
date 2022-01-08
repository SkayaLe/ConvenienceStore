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
    
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            this.HoaDonSanPhams = new HashSet<HoaDonSanPham>();
            this.MatHangChiNhanhs = new HashSet<MatHangChiNhanh>();
            this.NhanVienThuKhoMatHangs = new HashSet<NhanVienThuKhoMatHang>();
        }
    
        public string maMH { get; set; }
        public string maLoai { get; set; }
        public string maNCC { get; set; }
        public string tenMH { get; set; }
        public string donViTinh { get; set; }
        public Nullable<double> donGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonSanPham> HoaDonSanPhams { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHangChiNhanh> MatHangChiNhanhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVienThuKhoMatHang> NhanVienThuKhoMatHangs { get; set; }
    }
}
