using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;

//seperated controller from database  
namespace FinalProjectD01.Controllers
{
    public class HomeController : Controller
    {
        public Ilogin i;
        public Ulogin uc = new Ulogin();
        public HomeController(Ilogin i)
        {
            this.i = i;
        }
        public HomeController()
        {
          
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult login()
        {
            string n = Request["Name"];
            string p = Request["Password"];
            string option = Request["category"];
            if (option == "1")
            {
                option = "Admin";
            }
            else
            {
                option = "User";
            }
            if (option == "Admin")
            {
                Admin a = new Admin();
                a.Name = n;
                a.Password = p;
                if (uc.check(a))
                {
                    return View("../AdminHome/AdminHome");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                User u = new User();
                u.Name = n;
                u.Password = p;
                if (uc.check(u))
                {
                   //RedirectToAction("HomePage","UserHome");
                    return View("../userhome/homepage");
                }
                else
                {
                    return View("Index");
                }
            }
        }
        [HttpPost]
        public ActionResult Signup(User u)  //actionresult : returns view
        {
            //string n = Request["Name"];   //request : "Name" same name as you have kept their ( input field/drop down)
            //string p = Request["Password"];
            //string add = Request["address"];
            //string option = Request["Email"];
            //string cnic = Request["Cnic"];
            //string dob = Request["Dob"];
            //User u = new User();
            //u.address = add;
            //u.Cnic = cnic;
            //u.Email = option;
            //u.Password = p;
            //u.Name = n;
            //u.Dob = dob;
            uc.save(u);
            return View("../UserHome/HomePage");
        }

        public JsonResult CheckUserName()   //jsonResult : json object return krwata hai // ajex or json me small part refesh hota hai instead of full page
        {
            string userName = Request["Name"];
            User u = new User();
            u.Name = userName;
            if (uc.checkAvailability(u))
            {
                return this.Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return this.Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
