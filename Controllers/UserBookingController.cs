using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;
namespace FinalProjectD01.Controllers
{
    public class UserBookingController : Controller
    {
        //
        // GET: /UserBooking/

        IBooking h;
        userBooking i = new userBooking();
        public UserBookingController(IBooking i)
        {
            this.h = i;
        }

        public UserBookingController( )
        {
            
        }


        public ActionResult Booking()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Reserve()
        {
            Room r = new Room();
            string d1 = Request["CancelDate1"];
            string d2 = Request["CancelDate2"];
            r.startingDate = System.DateTime.Parse(d1);
            r.endingDate = System.DateTime.Parse(d2);
            r.noOfPeople = int.Parse(Request["noOfPeople"]);
            r.userId = int.Parse(Request["userId"]);
            r.Category = Request["Category"];
            i.reserve(r);

            return View("booking");
        }

        [HttpPost]
        public ActionResult Cancel()
        {
            Room r = new Room();
            string d1 = Request["CancelDate1"];
            string d2 = Request["CancelDate2"];
            r.startingDate = System.DateTime.Parse(d1);
            r.endingDate = System.DateTime.Parse(d2);
            r.noOfPeople = int.Parse(Request["noOfPeople"]);
            r.userId = int.Parse(Request["userId"]);
            r.Category = Request["Category"];
            i.cancel(r);
            return View("booking");
        }

        public JsonResult Available()
        {
            Room r = new Room();

            string d1 = Request["CancelDate1"];
            string d2 = Request["CancelDate2"];
            r.startingDate = System.DateTime.Parse(d1);
            r.endingDate = System.DateTime.Parse(d2);
            r.Category = Request["Category"];
            int result = i.check(r);
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }


        //[HttpPost]
        //public ActionResult Available()
        //{
        //    Room r = new Room();
        //    string d1 = Request["CancelDate1"];
        //    string d2 = Request["CancelDate2"];
        //    r.startingDate = System.DateTime.Parse(d1);
        //    r.endingDate = System.DateTime.Parse(d2);
        //    r.noOfPeople = int.Parse(Request["Persons"]);
        //    r.userId = int.Parse(Request["User Id"]);
        //    r.Category = Request["Category"];
        //    i.check(r);
        //    return View("booking");
        //}
        //[HttpPost]
        //public ActionResult Change()
        //{
        //    Room r = new Room();
        //    string d1 = Request["CancelDate1"];
        //    string d2 = Request["CancelDate2"];
        //    r.startingDate = System.DateTime.Parse(d1);
        //    r.endingDate = System.DateTime.Parse(d2);
        //    r.noOfPeople = int.Parse(Request["Persons"]);
        //    r.userId = int.Parse(Request["User Id"]);
        //    r.Category = Request["Category"];
        //   // i.change(r);
        //    return View("booking");
        //}

    }
}
