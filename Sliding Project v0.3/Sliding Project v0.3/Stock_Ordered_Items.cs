//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sliding_Project_v0._3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Ordered_Items
    {
        public int Order_ID { get; set; }
        public string Material_Name { get; set; }
        public string Type { get; set; }
        public string Colour { get; set; }
        public Nullable<int> Track { get; set; }
        public Nullable<int> Size { get; set; }
        public int Quantity { get; set; }
        public decimal Purchase_Price { get; set; }
    
        public virtual Stock_Order Stock_Order { get; set; }
    }
}