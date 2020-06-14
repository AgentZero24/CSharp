using System;
using System.Collections.Generic;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]
        public ViewResult Index()
        {
            Survey survey = new Survey();
            ViewBag.locations = new List<string> { "Los Angeles", "Oakland", "Seattle", "OC" };
            ViewBag.language = new List<string> { "C#", "Python", "Java", "Javascript" };
            return View("Index", survey);
        }
        [HttpPost("surveyresults")]
        public ViewResult SurveyResults(Survey survey)
        {

            return View("SurveyResults", survey);
        }


    }
}

