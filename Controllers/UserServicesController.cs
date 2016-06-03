using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;
namespace FinalProjectD01.Controllers
{
    public class UserServicesController : Controller
    {
        //
        // GET: /UserServices/
        Iimages g;
        postimage i = new postimage();
        public UserServicesController(Iimages i)
        {
            this.g = i;
        }
        public UserServicesController()
        {
           
        }
        public ActionResult Services()
        {
            return View();
        }
        public JsonResult List()
        {
            List<Object> r1 = i.record();
            return this.Json(r1, JsonRequestBehavior.AllowGet);
        }

    }
}
