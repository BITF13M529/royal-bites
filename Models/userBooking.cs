using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectD01.Models;

namespace FinalProjectD01.Models
{
    public class userBooking : IBooking
    {
        public void reserve(Room r)
        {
            using (Database1Entities db = new Database1Entities())
            {
                Database1Entities db1 = new Database1Entities();
                var q = from u in db1.Rooms
                        where u.Category.Equals(r.Category) && (u.startingDate > r.endingDate || u.endingDate < r.startingDate)
                        select u;


                if (q.Count() > 0)
                {
                    Room obj = q.First();

                    Room newObj = new Room();
                    newObj.startingDate = r.startingDate;
                    newObj.endingDate = r.endingDate;
                    newObj.noOfPeople = r.noOfPeople;
                    newObj.userId = r.userId;
                    newObj.Category = r.Category;

                    newObj.room_no = obj.room_no;
                    newObj.price = obj.price;
                    newObj.floor = obj.floor;
                    newObj.status = "reserved";

                    db.Rooms.Add(newObj);
                    db.SaveChanges();
                }

            }


        }

        public int check(Room r)
        {
            int c = 0;
            using (Database1Entities db = new Database1Entities())
            {
                Database1Entities db1 = new Database1Entities();
                var q = from u in db1.Rooms
                        where u.Category.Equals(r.Category) && (u.startingDate > r.endingDate || u.endingDate < r.startingDate)
                        select u;
                foreach (Room newObj in q)
                {
                    c++;

                }

                return c;

            }
        }
        public void cancel(Room r)
        {
            using (Database1Entities db = new Database1Entities())
            {

                var q = from u in db.Rooms
                        where u.Category == r.Category && u.startingDate == r.startingDate && r.endingDate == u.endingDate && u.userId == r.userId
                        select u;


                foreach (Room obj in q)
                {

                    db.Rooms.Remove(obj);
                }


                db.SaveChanges();



            }
        }
    }
}
