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
    
    public partial class OrderDetail
    {
        public int Rowid { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
        public decimal Finalprice { get; set; }
        public decimal Finaldiscount { get; set; }
    
        public virtual OrderMaster OrderMaster { get; set; }
        public virtual Product Product { get; set; }
    }
}
