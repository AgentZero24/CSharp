using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("user")]
        public IActionResult User()
        {
            User someUser = new User()
            {
                FirstName = "Paul",
                LastName = "Kramer"
            };
            // Here we pass this instance to our View
            return View("User", someUser);
        }

        [HttpGet("")]
        public IActionResult Message()
        {
            Message someMessage = new Message()
            {
                FirstMessage = "A message is a discrete unit of communication intended by the source for consumption by some recipient or group of recipients. A message may be delivered by various means, including courier, telegraphy, carrier pigeon and electronic bus. A message can be the content of a broadcast.",

            };
            // Here we pass this instance to our View
            return View("Message", someMessage);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {

            int[] ListOfNumbers = new int[]
            {
                1,2,3,4,5,6,7
            };


            // Here we pass this instance to our View
            return View("Numbers", ListOfNumbers);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            // to a View that has defined a model as @model string[]
            string[] users = new string[]
            {
        "Sally Druthers", "Billy Bob", "Joey Alvarez", "Moose Blaylock"
            };
            return View("Users", users);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
