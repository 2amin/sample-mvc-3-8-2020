using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.POCO
{
    public class ProductCrud
    {
        public void Insert(Helper.SPhelper.Product.InsertProduct Ref_Inserproduct)
        {
            using (var contaxt=new Models.DomainModel.EF.sample01Entities())
            {
                try
                {
                    contaxt.Database.ExecuteSqlCommand(Helper.SPhelper.Product.Producthelper.Insertproduct,)

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}