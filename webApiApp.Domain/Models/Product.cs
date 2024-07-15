﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApp.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }
        public int CategoryId { get; set; }

    }
}
