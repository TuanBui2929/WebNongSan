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
    
    public partial class DOUONG_NUOCEP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOUONG_NUOCEP()
        {
            this.GIOHANGs = new HashSet<GIOHANG>();
        }
    
        public int MA_DOUONG { get; set; }
        public string TEN_DOUONG { get; set; }
        public decimal GIABAN { get; set; }
        public Nullable<decimal> GIAGOC { get; set; }
        public string VANCHUYEN { get; set; }
        public string THONGTINSP { get; set; }
        public string THUONGHIEU { get; set; }
        public Nullable<int> GIAMGIA { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public string IMAGES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
    }
}