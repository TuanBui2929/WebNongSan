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
    
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            this.DATHANGs = new HashSet<DATHANG>();
            this.KHACHHANGs = new HashSet<KHACHHANG>();
        }
    
        public int MAKH { get; set; }
        public string TENKH { get; set; }
        public string EMAIL { get; set; }
        public int SDT { get; set; }
        public string MK { get; set; }
        public string XACNHANMATKHAU { get; set; }
        public string MAXACTHUC { get; set; }

        public string DangNhapThatBai;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
