//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models.DomainModel.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderMaster()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Orderid { get; set; }
        public string Sellernationalid { get; set; }
        public string Buyernationalid { get; set; }
        public decimal Totalprice { get; set; }
        public decimal Totaldiscount { get; set; }
        public System.DateTime Purchasedate { get; set; }
        public System.TimeSpan Purchasetime { get; set; }
    
        public virtual Buyer Buyer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
