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
    
    public partial class LINKS
    {
        public System.Guid ID { get; set; }
        public System.Guid CATALOGPRODUCTID { get; set; }
        public int PRICERECORDINDEX { get; set; }
    
        public virtual PRODUCTS PRODUCTS { get; set; }
        public virtual PRICESRECORDS PRICESRECORDS { get; set; }
    }
}
