using StudentProject.CustomBinders;
using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProject.Controllers
{
    public class ProductInfoBinderController : Controller
    {
        // GET: ProductInfoBinder
        public ActionResult Index()
        {
            return View(new ProductViewModel() { ProductName = "Laptop" });
        }

        [HttpPost]
        public ActionResult PostProductInfo([ModelBinder(typeof(ProductInfoModelBinder))] ProductInfoViewModel product)
        {
            return View(product);
        }
    }
}