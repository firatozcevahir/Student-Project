using StudentProject.CustomBinders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProject.Controllers
{
    public class CustomModelBindingController : Controller
    {
        // GET: CustomModelBinding
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetTime([ModelBinder(typeof(DateTimeModelBinder))] DateTime? arg)
        {
            return PartialView("Index", arg);
        }
    }
}