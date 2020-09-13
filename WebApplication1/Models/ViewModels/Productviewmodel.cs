using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Viewmodel
{
    public class Productviewmodel
    {
        #region [-Ctor-]
        public Productviewmodel()
        {
            Ref_Product = new DomainModel.EF.Product();
            Ref_ProductCrud = new POCO.ProductCrud();
        }
        #endregion
        #region[-Props For class-]
        public DomainModel.EF.Product Ref_Product { get; set; }
        public POCO.ProductCrud Ref_ProductCrud { get; set; }
    
        #endregion
        #region [-props for Model-]


        public int Productid
        {
            get;
            set;
        }



        public string Productname
        {
            get;
            set;
        }




        public decimal unitprice
        {
            get;
            set;
        }



        public decimal discount
        {
            get;
            set;
        }



        public byte[] picture
        {
            get;
            set;
        }


        public int? Categoryid
        {
            get;
            set;
        }
        public Models.DomainModel.EF.ctegory Ref_Category { get; set; }


        #endregion
        #region [-Methods-]
        #region [-Insert(List<Helper.SPhelper.Product.InsertProduct> Ref_Insertproduct)-]
        public void Insert(Productviewmodel Ref_Productviewmodel)
        {
            Models.DomainModel.EF.Product Ref_Product = new DomainModel.EF.Product();
            Ref_Product.Categoryid = Ref_Productviewmodel.Categoryid;
            Ref_Product.Productname = Ref_Productviewmodel.Productname;
            Ref_Product.Unitprice = Ref_Productviewmodel.unitprice;
            Ref_Product.discount = Ref_Productviewmodel.discount;

            Ref_Product.image = Ref_Productviewmodel.picture;

            Ref_ProductCrud.Insert(Ref_Product);
        }
        #endregion

        #region [-Update(List<Helper.SPhelper.Product.Updateproduct> Ref_Updateproduct)-]
        public void Update(List<Helper.SPhelper.Product.Updateproduct> Ref_Updateproduct)
        {
            Ref_ProductCrud.Update(Ref_Updateproduct);
        }
        #endregion
        #region [-Findcategories()-]
        public dynamic Findcategories()
        {
            return Ref_ProductCrud.SelectCategoryFields();
        }
        #endregion
        public List<Models.DomainModel.EF.Product> FindProducts()
        {
            return Ref_ProductCrud.SelectProductFields();
        }
        #endregion

    }
}