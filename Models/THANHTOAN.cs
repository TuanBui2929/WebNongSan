//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNongSan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THANHTOAN()
        {
            this.DATHANGs = new HashSet<DATHANG>();
        }
    
        public int MATT { get; set; }
        public string TENKHTT { get; set; }
        public string EMAIL { get; set; }
        public string DIACHICUTHE { get; set; }
        public int SDT { get; set; }
        public string NOIDUNGGC { get; set; }
        public string NOIDUNGGH { get; set; }
        public string MAVOUCHER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
        public virtual VOUCHER VOUCHER { get; set; }
    }
}
