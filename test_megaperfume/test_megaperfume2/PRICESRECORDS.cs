//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test_megaperfume2
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRICESRECORDS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRICESRECORDS()
        {
            this.LINKS = new HashSet<LINKS>();
        }
    
        public int RECORDINDEX { get; set; }
        public System.Guid PRICEID { get; set; }
        public string NAME { get; set; }
        public byte STATE { get; set; }
        public bool USED { get; set; }
        public double PRICE { get; set; }
        public bool DELETED { get; set; }
        public string COMMENT { get; set; }
        public string SKU { get; set; }
        public int STOCK { get; set; }
        public int INSTOCK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINKS> LINKS { get; set; }
        public virtual PRICES PRICES { get; set; }
    }
}
