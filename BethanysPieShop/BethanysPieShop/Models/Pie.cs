﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Pie
    {
        public int PiedId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public int MyProperty { get; set; }

        public string AllergyInformation { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPieOfTheWeek { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
