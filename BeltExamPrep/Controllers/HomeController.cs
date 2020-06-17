using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExamPrep.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltExamPrep.Controllers
{
    public class HomeController : Controller
    {
        private BeltExamPrepContext db;
        public HomeController(BeltExamPrepContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            if (db.Users.Any(user => user.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "is taken");
                return RedirectToAction("Index");
            }
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("Fullname", newUser.FullName());
            return RedirectToAction("All", "FoodTruck");
        }
        // [HttpPost("/login")]
        // public IActionResult Login(LoginUser loginUser)
        // {
        //     if (ModelState.IsValid == false)
        //     {
        //         return View("Index");
        //     }
        //     User dbUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);
        //     if (dbUser == null)
        //     {
        //         ModelState.AddModelError("LoginEmail", "invalid");
        //         return View("Index");
        //     }
        //     PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
        //     PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
        //     if (pwCompareResult = 0)
        //     {
        //         ModelState.AddModelError("LoginEmail")
        //     }



        private IActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
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
