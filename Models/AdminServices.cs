using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectD01.Models;

namespace FinalProjectD01.Models
{
    public class AdminServices :IServices
    {
        public void Add(Room r)
        {

            using (Database1Entities db = new Database1Entities())
            {
                db.Rooms.Add(r);
                db.SaveChanges();
                db.Dispose();
            }
        }
       public void Update(Room r)
        {

            using (Database1Entities db = new Database1Entities())
            {
               var q = from u in db.Rooms
                        where u.room_no == r.room_no
                        select u;

               foreach (Room obj in q)
               {// = db.Rooms.First(x => x.room_no == r.room_no);
                   obj.room_no = r.room_no;
                   obj.price = r.price;
                   obj.status = r.status;
                   obj.floor = r.floor;
                   obj.Category = r.Category;
               }
                db.SaveChanges();
               
            }
        }
        public void delete(int id)
        {

            using (Database1Entities db = new Database1Entities())
            {
                var q = from u in db.Rooms
                               where u.room_no == id
                               select u;
                db.Rooms.Remove(q.First());
                db.SaveChanges();
                db.Dispose();
            }
        }
    }
}