using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectD01.Models;

namespace FinalProjectD01.Models
{
    public class ViewRooms : IViewRooms
    {
        public List<Object> record()
        {
            List<Object> r = new List<Object>();
            using (Database1Entities db = new Database1Entities())
            {
                Database1Entities db1 = new Database1Entities();
                var q = from u in db1.Rooms
                        select new { u.Category, u.floor, u.price, u.room_no, u.status };
                foreach (Object newObj in q)
                {
                    r.Add(newObj);

                }

                return r;

            }
        }
    }
}