using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectD01.Models
{
    public interface Ilogin
    {
        void save(User u);
        bool check(User u);
        bool check(Admin u);
        bool checkAvailability(User u);

        //they will interact with DB
    }
}
