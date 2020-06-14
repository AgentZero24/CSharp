using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidations.Models;

namespace DojoSurveyValidations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {

            Survey survey = new Survey();
            ViewBag.locations = new List<string> { "Los Angeles", "Oakland", "Seattle", "OC" };
            ViewBag.language = new List<string> { "C#", "Python", "Java", "Javascript" };
            return View("Index", survey);
        }


        [HttpPost("surveyresults")]
        public IActionResult SurveyResults(Survey survey)
        {
            if (ModelState.IsValid)
            {
                // var newUser = user;
                return View("SurveyResults", survey);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                ViewBag.locations = new List<string> { "Los Angeles", "Oakland", "Seattle", "OC" };
                ViewBag.language = new List<string> { "C#", "Python", "Java", "Javascript" };
                return View("Index", survey);
            }
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

