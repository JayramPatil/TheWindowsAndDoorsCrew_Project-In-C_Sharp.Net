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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Product_Material = new HashSet<Product_Material>();
        }
    
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Catagory { get; set; }
        public decimal Price { get; set; }
        public double Time_To_Build { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Material> Product_Material { get; set; }
    }
}
