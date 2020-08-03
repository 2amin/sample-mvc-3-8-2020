using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Helper.SPhelper.Product
{
    public class InsertProduct
    {
        
        public string Productname { get; set; }
        public decimal Unitprice { get; set; }
        public decimal discount { get; set; }
        public byte[] productimage { get; set; }
    }
}