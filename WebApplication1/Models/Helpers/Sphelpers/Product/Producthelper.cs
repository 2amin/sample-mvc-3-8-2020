using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Helper.SPhelper.Product
{
    public static class Producthelper
    {
        public static string Insertproduct = "exec Insertproduct";
        public static string Updateproduct = "exec Updateproduct";


        #region [-SetInsertParameters(List<Helper.SPhelper.Product.InsertProduct> listInsertProduct)-]
        public static object[] SetInsertParameters(List<Helper.SPhelper.Product.InsertProduct> listInsertProduct)
        {
            #region [- SqlParameter -]
            SqlParameter InsrtProductListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.Udt_InsertProduct",
                Value = listInsertProduct.ToDataTable()
            };
            #endregion
            #region [- parameters  -]
            object[] parameters =
               {
                InsrtProductListParameter
            };
            #endregion
            return parameters;
        }
        #endregion

        #region [-SetUpdateParameters(List<SPhelper.Product.Updateproduct> listupdateproduct)-]
        public static object[] SetUpdateParameters(List<SPhelper.Product.Updateproduct> listupdateproduct)
        {
            #region [-SqlParameter-]
            SqlParameter UpdateProductListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.Udt_ProductTypeForUpdate",
                Value = listupdateproduct.ToDataTable()
            };
            #endregion
            #region [-parameters-]
            object[] parameters =
                {
                UpdateProductListParameter
            };
            #endregion
            return parameters;
        } 
        #endregion
    }
    
}
