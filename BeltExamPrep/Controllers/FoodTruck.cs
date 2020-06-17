using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExamPrep.Models;

namespace BeltExamPrep.Controllers
{
    public class FoodTruckController : Controller
    {
        private BeltExamPrepContext db;
        public FoodTruckController(BeltExamPrepContext context)
        {
            db = context;
        }
        [HttpGet("/trucks")]
        public IActionResult All()
        {
            return View("All");
        }
    }
}
