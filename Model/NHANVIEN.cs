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
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.DATHANGs = new HashSet<DATHANG>();
        }
    
        public int MANV { get; set; }
        public string TENNV { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string GIOITINH { get; set; }
        public string CHUCVU { get; set; }
        public string DIACHICUTHE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> SDT { get; set; }
        public string IMAGES { get; set; }
        public Nullable<int> MA_SP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
