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
    
    public partial class MANUFACTURERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MANUFACTURERS()
        {
            this.PRODUCTS = new HashSet<PRODUCTS>();
        }
    
        public System.Guid ID { get; set; }
        public string NAME { get; set; }
        public bool EXTRAUSED { get; set; }
        public int EXTRA { get; set; }
        public string DESCRIPTION { get; set; }
        public bool PUBLISHED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTS> PRODUCTS { get; set; }
    }
}
