using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingPlannerController : Controller
    {
        private WeddingPlannerContext db;

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        public WeddingPlannerController(WeddingPlannerContext context)
        {
            db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            User userInDb = db.Users.FirstOrDefault(user => user.UserId == uid);

            List<Wedding> allWeddings = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(wedding => wedding.RSVP)
                .ThenInclude(wedding => wedding.User)
                .ToList();

            return View("Dashboard", allWeddings);
        }

        [HttpGet("wedding")]
        public IActionResult NewWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("NewWedding");
        }

        [HttpPost("wedding/create")]
        public IActionResult CreateNewWedding(Wedding newWedding)
        {
            User userinsession = db.Users.FirstOrDefault(user => user.UserId == HttpContext.Session.GetInt32("UserId"));
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                newWedding.Creator = userinsession;
                db.Add(newWedding);
                db.SaveChanges();
                return RedirectToAction("Dashboard", newWedding);
            }
            return View("NewWedding");
        }
        [HttpGet("wedding/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding selectedWedding = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(wedding => wedding.RSVP)
                .ThenInclude(wedding => wedding.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding == null)
            {
                return RedirectToAction("Dashboard");
            }

            return View("OneWedding", selectedWedding);
        }

        [HttpGet("wedding/{weddingId}/rsvp")]
        public IActionResult RSVP(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            RSVP rsvp = db.RSVPs.FirstOrDefault(vp => vp.WeddingId == weddingId && vp.UserId == uid);

            if (rsvp != null)
            {
                db.RSVPs.Remove(rsvp);
            }
            else
            {
                RSVP newRsvp = new RSVP()
                {
                    UserId = (int)uid,
                    WeddingId = weddingId
                };

                db.RSVPs.Add(newRsvp);
            }

            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/{weddingId}/delete")]
        public IActionResult Delete(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding selectedWedding = db.Weddings.FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding == null || selectedWedding.UserId != uid)
            {
                return RedirectToAction("Dashboard");
            }

            db.Weddings.Remove(selectedWedding);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}