using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crudelicious.Models;

namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private CrudeliciousContext db;
        public HomeController(CrudeliciousContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> dishes = db.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .Take(5)
                .ToList();
            return View("Index", dishes);
        }
        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View("CreateDish");
        }

        [HttpPost("create")]
        public IActionResult CreateDish(Dish newDish)
        {
            db.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("{dishId}")]
        public IActionResult Dish(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View("Dish", getDish);
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View("Edit", getDish);
        }
        [HttpPost("update/{dishId}")]
        public IActionResult UpdateDish(Dish updateDish, int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            getDish.DishName = updateDish.DishName;
            getDish.ChefName = updateDish.ChefName;
            getDish.Calories = updateDish.Calories;
            getDish.Tastiness = updateDish.Tastiness;
            getDish.Message = updateDish.Message;
            getDish.UpdatedAt = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            db.Dishes.Remove(getDish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
