//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _8_2_form
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryFK { get; set; }
        public Nullable<int> Stock { get; set; }
        public string image { get; set; }
        public string Dersecription { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
