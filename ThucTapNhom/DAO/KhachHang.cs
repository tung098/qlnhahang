//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThucTapNhom.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.PhieuYeuCau = new HashSet<PhieuYeuCau>();
        }
    
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuYeuCau> PhieuYeuCau { get; set; }

        public void SetData(string TenKH, string GioiTinh, string DiaChi, string SDT)
        {
            this.TenKH = TenKH;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.DienThoai = SDT;
        }
    }
}
