//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doan_QLMBST_PHH
{
    using System;
    using System.Collections.Generic;
    
    public partial class The
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public The()
        {
            this.MuaBanThes = new HashSet<MuaBanThe>();
        }
    
        public string MaThe { get; set; }
        public string TenNhaMang { get; set; }
        public Nullable<decimal> MenhGia { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public Nullable<decimal> GiaNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuaBanThe> MuaBanThes { get; set; }
        public virtual NhaMang_KM NhaMang_KM { get; set; }
    }
}
