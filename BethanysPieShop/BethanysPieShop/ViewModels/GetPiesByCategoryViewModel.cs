using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.ViewModels
{
    public class GetPiesByCategoryViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

        public string Category { get; set; }
    }
}
