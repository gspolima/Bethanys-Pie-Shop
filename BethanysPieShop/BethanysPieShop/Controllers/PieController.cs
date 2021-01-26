using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this._pieRepository = pieRepository;
            this._categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese Cakes";
            
            return View(piesListViewModel);
        }

        public ViewResult GetPie(int id)
        {
            var getPieViewModel = new GetPieViewModel();
            getPieViewModel.Pie = _pieRepository.GetPieById(id);
            getPieViewModel.Pie.Category = new Category() { CategoryId = 1, Name = "Fruit Pies" };

            return View(getPieViewModel);
        }

        public ViewResult GetPiesByCategory(int categoryId)
        {
            var getPiesByCategory = new GetPiesByCategoryViewModel();
            getPiesByCategory.Pies =
                _pieRepository
                .AllPies
                .Where(p =>
                p.Category.CategoryId == categoryId);

            return View(getPiesByCategory);
        }
    }
}
