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
    
    public partial class Stock_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock_Order()
        {
            this.Distributor_Transaction = new HashSet<Distributor_Transaction>();
            this.Stock_Ordered_Items = new HashSet<Stock_Ordered_Items>();
        }
    
        public int Order_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Distributor_Name { get; set; }
        public decimal Total { get; set; }
        public decimal Paid_Amount { get; set; }
        public decimal Remaining_Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Distributor_Transaction> Distributor_Transaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Ordered_Items> Stock_Ordered_Items { get; set; }
    }
}