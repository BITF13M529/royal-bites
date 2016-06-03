using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;
namespace FinalProjectD01.Controllers
{
    public class AdminBookingController : Controller
    {
        //
        // GET: /AdminBooking/
        IViewRooms d;

        public ViewRooms i = new ViewRooms();
        public AdminBookingController(IViewRooms d)
        {
            this.d = d;
        }
        public AdminBookingController()
        {
             
        }

        public ActionResult bookings()
        {
            return View();
        }
        public JsonResult Available()
        {
            //List<Room> r = new List<Room>();
            //r=i.record();
            return this.Json(true, JsonRequestBehavior.AllowGet);  
        }
        public JsonResult List()
        {
            List<Object> r1 = i.record(); 
            return this.Json(r1, JsonRequestBehavior.AllowGet);
        }
    }
}
