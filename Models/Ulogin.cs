using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectD01.Models;

namespace FinalProjectD01.Models
{
    //dependency injection
    public class Ulogin : Ilogin             //inherited
    {
        public bool check(User u1)         //database work is here
        {
            using (Database1Entities db2 = new Database1Entities())
            {
                bool res = false;
                Database1Entities db = new Database1Entities();
                var q = from u in db.Users
                        where u.Name == u1.Name
                        select u;
                foreach (User us in q)
                {
                    if (us.Password.Equals(u1.Password))
                    {
                        res = true;
                    }
                }
                return res;


            }
        }
        public bool check(Admin u1)
        {
            using (Database1Entities db1 = new Database1Entities())
            {
                bool res = false;
                Database1Entities db = new Database1Entities();
                var q = from u in db.Admins
                        where u.Name == u1.Name
                        select u;
                foreach (Admin us in q)
                {
                    if (us.Password.Equals(u1.Password))
                    {
                        res = true;
                    }
                }
                return res;

            }
        }
        public void save(User u)
        {
            using (Database1Entities db = new Database1Entities())
            {
                db.Users.Add(u);
                db.SaveChanges();
                db.Dispose();      
            }
        }
        public bool checkAvailability(User u1)
        {
            int count = 0;
            using (Database1Entities db1 = new Database1Entities())
            {
                Database1Entities db = new Database1Entities();
                var q = from u in db.Users
                        where u.Name == u1.Name
                        select u;
                foreach (User us in q)
                {
                    count++;
                }
                if (count > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
        }

    }
}