﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
