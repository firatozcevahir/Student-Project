using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProject.CustomBinders
{
    public class ProductInfoModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            var gun = request["gun"];
            var ay = request["ay"];
            var yil = request["yil"];
            var model = request["ProductName"];

            return new ProductInfoViewModel()
            {
                ProductName = model,
                OrderDate = new DateTime(int.Parse(yil),int.Parse(ay),int.Parse(gun))
            };
        }
    }
}