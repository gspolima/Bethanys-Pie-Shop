using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies => new List<Pie>()
        {
            new Pie() { PieId = 1, Name = "Strawberry Pie", Price = (double)15.47, ShortDescription = "Made with fresh strawberries", CategoryId = 2 },
            new Pie() { PieId = 2, Name = "Rhubarb Pie", Price = (double)5.50, ShortDescription = "Delicious organic rhubarb", CategoryId = 2},
            new Pie() { PieId = 3, Name = "Pumpkin Pie", Price = (double)12.00, ShortDescription = "Sweet pieces of pumpkin", CategoryId = 2},
            new Pie() { PieId = 4, Name = "Cheese Cake", Price = (double)20.00, ShortDescription = "The latest and the greatest", CategoryId = 1}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> GetPiesInStock()
        {
            return AllPies.Where(p => p.InStock == true);
        }
    }
}
