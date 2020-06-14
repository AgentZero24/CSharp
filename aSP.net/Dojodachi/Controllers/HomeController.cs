using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Dojo dojodachi = new Dojo();
            HttpContext.Session.SetObjectAsJson("Dojo", dojodachi);

            return View("Index", dojodachi);
        }
        [HttpGet("play")]
        public IActionResult Play()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random happy = new Random();

            if (get.Energy <= 0)
            {
                get.Message = "Your dojodachi has no energy and needs a nap";
            }

            else if (like.Next(5) == 1)
            {
                get.Energy -= 1;
                get.Message = "Your dojodachi didn't like that game you nub";
                // get.Image =
            }

            else
            {
                get.Energy -= 1;
                get.Fullness += happy.Next(5, 10);
                get.Message = $"Your dojodachi loved game you played {happy.Next(5, 10)}";
                // get.Image =
            }

            if (get.Fullness >= 100 && get.Happiness >= 100 && get.Energy >= 100)
            {
                get.Message = "You're a pro dojodachi owner";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }

            else if (get.Happiness <= 0 || get.Energy <= 0)
            {
                get.Message = "You're a terrible owner, your dojodachi died";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Death");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);

        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random full = new Random();
            if (get.Meal <= 0)
            {
                get.Message = "No food sadface";
            }

            else if (like.Next(5) == 1)
            {
                get.Meal -= 1;
                get.Message = "Your dojodachi didn't like that";
                // get.Image =
            }

            else
            {
                get.Meal -= 1;
                get.Fullness += full.Next(5, 10);
                get.Message = $"Your dojodachi loved the food you gave it, Fullness {full.Next(5, 10)}";
                // get.Image =

            }

            if (get.Fullness >= 100 && get.Happiness >= 100 && get.Energy >= 100)
            {
                get.Message = "You're a pro dojodachi owner";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }

            else if (get.Happiness <= 0 || get.Energy <= 0)
            {
                get.Message = "You're a terrible owner, your dojodachi died";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Death");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);
        }
        [HttpGet("work")]
        public IActionResult Work()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random work = new Random();

            if (get.Energy <= 4)
            {
                get.Message = "You can't work";
            }

            else
            {
                get.Happiness -= 5;
                get.Meal += work.Next(1, 3);
                get.Message = $"Your dojodachi earned {work.Next(1, 3)} meals";
                // get.Image =
            }

            if (get.Fullness >= 100 && get.Happiness >= 100 && get.Energy >= 100)
            {
                get.Message = "You're a pro dojodachi owner, you win!";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }

            else if (get.Happiness <= 0 || get.Energy <= 0)
            {
                get.Message = "You're a terrible owner, your dojodachi died";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Death");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);

        }
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            {
                Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
                get.Energy += 15;
                get.Fullness -= 5;
                get.Happiness -= 5;
                get.Message = "Your DojoDachi has gained 15 Energy but has lost 5 Fullness and Happiness";
                // get.Image = 


                if (get.Happiness >= 100 && get.Fullness >= 100 && get.Energy >= 100)
                {
                    get.Message = "You're a good pet owner. Congrats!";
                    // get.Image =
                    HttpContext.Session.SetObjectAsJson("Dojo", get);
                    return RedirectToAction("Success");
                }
                else if (get.Happiness <= 0 || get.Fullness <= 0)
                {
                    get.Message = "You're a terrible owner, your dojodachi died";
                    // get.Image = 
                    HttpContext.Session.SetObjectAsJson("Dojo", get);
                    return RedirectToAction("Failure");
                }
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return View("Index", get);
            }

        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            return View("Success", get);
        }

        [HttpGet("death")]
        public IActionResult Failure()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            return View("Death", get);
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
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
