using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectD01.Models;

namespace FinalProjectD01.Controllers
{
    public class AdminGalleryController : Controller
    {

        Iimages h;
        postimage i = new postimage();
        //
        // GET: /AdminGallery/
        public AdminGalleryController(Iimages h)
        {
            this.h = h;
        }

        public AdminGalleryController()
        {
             
        }


        public ActionResult AdminGallery()
        {
            return View();
        }
        public ActionResult Upload()
        {
            Image img = new Image();

            img.category = Request["Category"];
            HttpPostedFileBase file = Request.Files[0];
            file.SaveAs(Server.MapPath(@"~\Images\" + file.FileName)); //file uploading 
            img.path = "../Images/" + file.FileName;
            i.store(img);
            return View("AdminGallery");
        }
    }
}
