using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingPlannerController : Controller
    {
        private WeddingPlannerContext db;

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        public WeddingPlannerController(WeddingPlannerContext context)
        {
            db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Dashboard");
        }

        [HttpGet("wedding")]
        public IActionResult NewWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("NewWedding");
        }

        [HttpPost("wedding/create")]
        public IActionResult CreateNewWedding(Wedding newWedding)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                db.Add(newWedding);
                db.SaveChanges();
                return RedirectToAction("Dashboard", newWedding);
            }
            return View("NewWedding");
        }
    }
}