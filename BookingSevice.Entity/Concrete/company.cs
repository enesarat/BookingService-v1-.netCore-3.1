﻿using BookingService.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Entity.Concrete
{
    public class company:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public double salary { get; set; }
    }
}
