//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBookshelf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class discounts
    {
        public string discounttype { get; set; }
        public string stor_id { get; set; }
        public Nullable<short> lowqty { get; set; }
        public Nullable<short> highqty { get; set; }
        public decimal discount { get; set; }
    
        public virtual stores stores { get; set; }
    }
}
