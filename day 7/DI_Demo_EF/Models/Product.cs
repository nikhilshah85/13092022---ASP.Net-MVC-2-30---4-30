﻿using System;
using System.Collections.Generic;

namespace DI_Demo_EF.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PCategoty { get; set; }
        public int? PPrice { get; set; }
        public bool? PIsInStock { get; set; }
    }
}
