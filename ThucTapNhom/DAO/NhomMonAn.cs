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
    
    public partial class NhomMonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomMonAn()
        {
            this.MonAn = new HashSet<MonAn>();
        }
    
        public string MaNhomMon { get; set; }
        public string TenNhomMon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAn> MonAn { get; set; }
    }
}