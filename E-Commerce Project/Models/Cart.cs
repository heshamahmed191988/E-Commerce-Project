﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }

        //cart details
        public virtual IQueryable<CartDetails>? CartDetails { get; set; }

    }
}
