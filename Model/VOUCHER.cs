//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNongSan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VOUCHER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VOUCHER()
        {
            this.THANHTOANs = new HashSet<THANHTOAN>();
            this.DATHANGs = new HashSet<DATHANG>();
        }
    
        public string MAVOUCHER { get; set; }
        public string TENVOUCHER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN> THANHTOANs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
    }
}
