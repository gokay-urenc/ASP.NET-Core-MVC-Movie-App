using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC_1_MovieApp.Data;
using CoreMVC_1_MovieApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreMVC_1_MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            MovieCategoryModel model = new MovieCategoryModel
            {
                Categories = CategoryRepository.Categories,
                Movies = MovieRepository.Movies
            };
            if (id != null)
            {
                model.Movies = model.Movies.Where(x => x.CategoryId == id).ToList();
                model.Categories = model.Categories.ToList();
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            return View(model);
        }
        
        public IActionResult Details(int id)
        {
            MovieCategoryModel model = new MovieCategoryModel
            {
                Categories = CategoryRepository.Categories,
                Movie = MovieRepository.GetById(id)
            };
            return View(model);
        }
    }
}