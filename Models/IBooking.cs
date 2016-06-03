﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectD01.Models
{
    public interface IBooking
    {
        void reserve(Room r);
        void cancel(Room r);
        int check(Room r);
    }
}
