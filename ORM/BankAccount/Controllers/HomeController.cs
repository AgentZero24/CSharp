using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private BankAccountContext db;
        public HomeController(BankAccountContext context)
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
            User register = new User();
            return View("Index", register);
        }
        [HttpPost("user/register")]
        public IActionResult CreateRegistration(User user)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (db.Users.Any(r => r.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index", user);// You may consider returning to the View at this point
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                db.Add(user);
                db.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("Login");
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
                var userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
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
                    ModelState.AddModelError("Password", "Invalid Email/Password");

                    return View("Login");// handle failure (this should be similar to how "existing email" is handled)
                }
                HttpContext.Session.SetInt32("User", userInDb.UserId);
                return RedirectToAction("BankAccount", new { userId = userInDb.UserId });
            }
            return View("Login");
        }
        [HttpGet("account/{userId}")]
        public IActionResult BankAccount(int userId)
        {
            int? currentUserId = HttpContext.Session.GetInt32("User");
            var currentUser = db.Users.FirstOrDefault(u => u.UserId == currentUserId);
            if (db.Users.Any(u => u.UserId == currentUserId))
            {
                if (currentUserId != userId)
                {
                    return RedirectToAction("BankAccount", new { userId = currentUserId });
                }
                BankAccountWrapper WMod = new BankAccountWrapper();
                WMod.CurrentUser = db.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == currentUserId);
                WMod.AllUserTransactions = db.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == currentUserId).Transactions.OrderByDescending(t => t.CreatedAt).ToList();
                return View("BankAccount", WMod);
            }

            return RedirectToAction("Login");
        }

        [HttpPost("process")]
        public IActionResult ProcessChange(BankAccountWrapper changeAccount)
        {
            int? currentUserId = HttpContext.Session.GetInt32("User");

            User currentUser = db.Users.FirstOrDefault(u => u.UserId == currentUserId);

            if (ModelState.IsValid)
            {
                if (changeAccount.Transaction.Amount > 0 && currentUser.Balance < changeAccount.Transaction.Amount)
                {
                    ModelState.AddModelError("Amount", "Your balance must be greater than what you are withdrawing!");
                }
                changeAccount.Transaction.UserId = (int)currentUserId;
                currentUser.Balance += changeAccount.Transaction.Amount;
                db.Transactions.Update(changeAccount.Transaction);
                db.Users.Update(currentUser);
                db.SaveChanges();
                return RedirectToAction("BankAccount", new { userId = currentUserId });
            }
            return View("BankAccount", changeAccount);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
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
