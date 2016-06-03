using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;

namespace FinalProjectD01.Controllers
{
    public class AdminServicesController : Controller
    {
        //
        // GET: /AdminServices/

        public IServices h;
        public AdminServices i = new AdminServices();

        public AdminServicesController(IServices h)
        {
            this.h = h;
        }

        public AdminServicesController()
        {
           
        }

        public ActionResult AdminServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update()
        {
            Room r = new Room();
            int id = int.Parse(Request["room_no"]);
            string cat = Request["Category"];
            int price = int.Parse(Request["price"]);
            string status = Request["status"];
            int floor = int.Parse(Request["floor"]);
            r.Category = cat;
            r.room_no = id;
            r.price = price;
            r.floor = floor;
            r.status = status;
            i.Update(r);
            return View("AdminServices");
        }
        //public ActionResult Category()
        //{
        //    List<SelectListItem> items = new List<SelectListItem>();

        //    //items.Add("Business Class");
        //    //items.Add("Discounted Room");
        //    //items.Add("Premium Room");


        //    ViewBag.Cat = items;

        //    return View();

        //}
        [HttpPost]
        public ActionResult Add()
        {
            Room r = new Room();
            int id = int.Parse(Request["room_no"]);

            string cat = Request["Category"];
            if (cat == "1")
            {
                cat = "Business Class";
            }
            else if (cat == "2")
            {
                cat = "Premium Room";
            }
            else if (cat == "3")
            {
                cat = "Discounted Class";
            }
            int price = int.Parse(Request["price"]);
            string status = Request["status"];
            int floor = int.Parse(Request["floor"]);
            r.room_no = id;
            r.Category = cat;
            r.price = price;
            r.floor = floor;
            r.status = status;
            i.Add(r);
            return View("AdminServices");
        }
        [HttpPost]
        public ActionResult Delete()
        {
            int id = int.Parse(Request["room_no"]);
            i.delete(id);
            return View("AdminServices");
        }

    }
}
