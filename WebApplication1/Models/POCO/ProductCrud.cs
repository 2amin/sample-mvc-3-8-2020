using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.POCO
{
    public class ProductCrud
    {
        #region [-Insert(List<Helper.SPhelper.Product.InsertProduct> Ref_Inserproduct)-]
        public void Insert(List<Helper.SPhelper.Product.InsertProduct> Ref_Inserproduct)
        {
            using (var contaxt = new Models.DomainModel.EF.sample01Entities())
            {
                try
                {
                    contaxt.Database.ExecuteSqlCommand(Helper.SPhelper.Product.Producthelper.Insertproduct,
                        Helper.SPhelper.Product.Producthelper.SetInsertParameters(Ref_Inserproduct));

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (contaxt != null)
                    {
                        contaxt.Dispose();
                    }
                }

            }
        } 
        #endregion
    }
}