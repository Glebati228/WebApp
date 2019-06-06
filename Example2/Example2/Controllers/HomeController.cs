using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Example2.Models;


namespace Example2.Controllers
{
    public class HomeController : Controller
    {
        FootballContext db = new FootballContext();
        public ActionResult Index()
        {
            ViewBag.players = db.Players.Include(p => p.Team).ToList();
            return View(ViewBag);
        }

    }
}