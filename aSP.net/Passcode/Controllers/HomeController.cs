using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passcode.Models;
using Microsoft.AspNetCore.Http;


namespace Passcode.Controllers
{
    public class HomeController : Controller
    {
        private string GeneratedPasscode
        {
            get { return HttpContext.Session.GetString("passcode"); }
            set { HttpContext.Session.SetString("passcode", value); }
        }
        public string CreatePasscode()
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string passcode = "";
            Random rnd = new Random();
            for (var i = 0; i < 15; i++)
            {
                passcode += valid[rnd.Next(valid.Length)];
            }
            return passcode;
        }
        public IActionResult Index()
        {
            ViewBag.passcode = GeneratedPasscode;
            return View();
        }
        [HttpPost("")]
        public IActionResult RandomPasscode()
        {
            GeneratedPasscode = CreatePasscode();
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
