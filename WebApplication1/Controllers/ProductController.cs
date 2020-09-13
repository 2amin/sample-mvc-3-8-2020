using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Product")]
    public class ProductController : Controller
    {
        #region [-Ctor-]
        public ProductController()
        {
            Ref_Productviewmodel = new Models.Viewmodel.Productviewmodel();
        }
        #endregion
        #region [-props-]
        public Models.Viewmodel.Productviewmodel Ref_Productviewmodel { get; set; }
        #endregion
        // GET: Product
        #region [-Index()-]
        public ActionResult Index()
        {
            return View();
        }
        #endregion
        #region [-Save()-]
        [HttpGet]
        [Route("save")]
        public ActionResult Save()
        {
            
            
            return View(Ref_Productviewmodel);
        }
        #endregion
        #region [-Save([Bind(Include = "Productid,Productname,Unitprice,discount,Categoryid ")]Models.Viewmodel.Productviewmodel Ref_Insertproduct)-]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save([Bind(Include = "Categoryid,Productid,Productname,Unitprice,discount,picture ")]Models.Viewmodel.Productviewmodel Ref_Insertproduct/*,HttpPostedFile filebase*/)
        {
            
            if (ModelState.IsValid)
            {
                //Ref_Productviewmodel.picture = new byte[filebase.ContentLength];
                //filebase.InputStream.Read(Ref_Productviewmodel.picture, 0, filebase.ContentLength);
                Ref_Productviewmodel.Insert(Ref_Insertproduct);
               
                return Redirect("save");
            }
          
            return Redirect("Save");
        } 
        #endregion
    }
}