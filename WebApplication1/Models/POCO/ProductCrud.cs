using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.POCO
{
    public class ProductCrud
    {
        #region [-Ctor-]
        public ProductCrud()
        {

        }
        #endregion
        #region [-Insert(List<Helper.SPhelper.Product.InsertProduct> Ref_Inserproduct)-]
        public void Insert(Models.DomainModel.EF.Product Ref_Inserproduct)
        {
            using (var contaxt = new Models.DomainModel.EF.sample01Entities1())
            {
                try
                {
                    contaxt.Products.Add(Ref_Inserproduct);
                    contaxt.SaveChanges();

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
        #region [-Update(List<Helper.SPhelper.Product.Updateproduct> Ref_Updateproduct)-]
        public void Update(List<Helper.SPhelper.Product.Updateproduct> Ref_Updateproduct)
        {
            using (var context = new Models.DomainModel.EF.sample01Entities1())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(Helper.SPhelper.Product.Producthelper.Updateproduct,
                        Helper.SPhelper.Product.Producthelper.SetUpdateParameters(Ref_Updateproduct));
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }
        }
        #endregion
        #region [-SelectCategoryFields()-]
        public dynamic SelectCategoryFields()
        {

            using (var context = new Models.DomainModel.EF.sample01Entities1())
            {
                try
                {
                    //var categories= new SelectList(context.Category, "Id", "Title");
                    var c = context.ctegories.Select(p => new { p.categoryid, p.categorytype }).ToList();
                    return c.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                   }
                }
            }
        }
        #endregion
        public List<Models.DomainModel.EF.Product> SelectProductFields()
        {

            using (var context = new Models.DomainModel.EF.sample01Entities1())
            {
                try
                {
                    //var categories= new SelectList(context.Category, "Id", "Title");
                    var c = context.Products.ToList() ;  
                    return c.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
    }
}