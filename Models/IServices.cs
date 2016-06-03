using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectD01.Models
{
    public interface IServices
    {
        void Add(Room r);
        void Update(Room r);
        void delete(int id);
    }
}
