using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("http://google.com");
        }
        public ActionResult FirstAction()
        {
            return View();
        }
        public ActionResult GotoProduct()
        {
            //return RedirectToAction("Product/AddProduct");
            return RedirectToAction("AddProduct", "Product");
            //return RedirectToAction("Index");
        }
        public ActionResult GoToUpdateProduct()
        {
            return RedirectToAction("UpdateProduct", "Product", new { ID = 20 , name = "Charl"});
        }
    }
}