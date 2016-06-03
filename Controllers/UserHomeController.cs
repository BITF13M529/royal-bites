using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectD01.Controllers
{
    public class UserHomeController : Controller
    {
        //
        // GET: /UserHome/

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
        public ActionResult Restaurant()
        {
            return View();
        }
    }
}
