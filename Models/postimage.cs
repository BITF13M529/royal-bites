using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectD01.Models;

namespace FinalProjectD01.Models
{
    public class postimage : Iimages
    {
        public void store(Image i)
        {

            using (Database1Entities db = new Database1Entities())
            {

                var q = from u in db.Images
                        where u.category == i.category
                        select u;

                foreach (Image obj in q)
                {
                    obj.category = i.category;
                    obj.path = i.path;
                }
                db.SaveChanges();

            }
        }
        public List<Object> record()
        {
            List<Object> r = new List<Object>();
            using (Database1Entities db = new Database1Entities())
            {

                var q = from u in db.Images
                        select new { u.category, u.path };
                foreach (Object newObj in q)
                {
                    r.Add(newObj);

                }

                return r;

            }
        }

    }
}