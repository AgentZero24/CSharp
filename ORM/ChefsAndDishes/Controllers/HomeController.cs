using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private ChefsAndDishesContext db;
        public HomeController(ChefsAndDishesContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            Wrapper allChefs = new Wrapper();
            allChefs.AllChefs = db.Chefs.Include(c => c.CreatedDishes).ToList();
            return View("Index", allChefs);
        }
        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("AddChef");
        }

        [HttpPost("add/chef")]
        public IActionResult AddChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                db.Add(newChef);
                db.SaveChanges();
                return RedirectToAction("Index", newChef);
            }
            return RedirectToAction("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> dishes = db.Dishes.Include(d => d.Creator).ToList();
            return View("Dishes", dishes);
        }
        [HttpGet("new/dish")]
        public IActionResult NewDish()
        {
            Wrapper wrapper = new Wrapper();
            wrapper.AllChefs = db.Chefs.ToList();
            return View("AddDish", wrapper);
        }

        [HttpPost("add/dish")]
        public IActionResult AddDish(Wrapper wrapper)
        {
            if (ModelState.IsValid)
            {
                db.Add(wrapper.Dish);
                db.SaveChanges();
                return RedirectToAction("Dishes", wrapper);
            }
            wrapper.AllChefs = db.Chefs.ToList();
            return View("AddDish", wrapper);
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
