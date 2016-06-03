using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectD01.Controllers
{
    public class AdminHomeController : Controller
    {
        //
        // GET: /AdminHome/

        public ActionResult AdminHome()
        {
            return View();
        }
        public ActionResult AdminRestaurant()
        {
            return View();
        }
        public ActionResult AdminTestimonial()
        {
            return View();
        }

    }
}
