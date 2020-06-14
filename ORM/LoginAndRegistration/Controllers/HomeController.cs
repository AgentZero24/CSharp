using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginAndRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private LoginAndRegistrationContext db;
        public HomeController(LoginAndRegistrationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            Registration register = new Registration();
            return View("Index", register);
        }
        [HttpPost("user/register")]
        public IActionResult CreateRegistration(Registration register)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (db.Registrations.Any(r => r.Email == register.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index", register);// You may consider returning to the View at this point
                }
                PasswordHasher<Registration> Hasher = new PasswordHasher<Registration>();
                register.Password = Hasher.HashPassword(register, register.Password);
                db.Add(register);
                db.SaveChanges();
                HttpContext.Session.SetInt32("UserId", register.UserId);
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");// other code   
            }

        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost("user/login")]
        public IActionResult UserLogin(Login userSubmission)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = db.Registrations.FirstOrDefault(u => u.Email == userSubmission.Email);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<Login>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("Passwprd", "Invalid Email/Password");

                    return View("Login");// handle failure (this should be similar to how "existing email" is handled)
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");

            }
            return View("Login");

        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (db.Registrations.Any(r => r.UserId == userId))
            {
                return View("Success");
            }
            return RedirectToAction("Login");
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
