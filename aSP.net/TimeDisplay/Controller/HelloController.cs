using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.Time = DateTime.Now.ToString("h:mm:ss tt");
            ViewBag.Date = DateTime.Today.ToString("dd/MM/yyyy");
            return View("Index");
        }
    }
}

