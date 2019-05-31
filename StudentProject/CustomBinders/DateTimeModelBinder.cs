using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProject.CustomBinders
{
    public class DateTimeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            string gun = request["gun"];
            string ay = request["ay"];
            string yil = request["yil"];
            string saat = request["saat"];
            string dakika = request["dakika"];
            string saniye = request["saniye"];


            return new DateTime(int.Parse(yil), int.Parse(ay), int.Parse(gun), int.Parse(saat), int.Parse(dakika), int.Parse(saniye));
        }
    }
}