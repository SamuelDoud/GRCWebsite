using GRCWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRCWebsite.Controllers
{
    public class RosterController : Controller
    {
        // GET: Roster
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PerformanceList()
        {
            return View();
        }

        public ActionResult Records()
        {
            return View();
        }

        public ActionResult ProfilePage()
        {
            return View();
        }
        
        public PartialViewResult PersonalProfile(Person person)
        {
            return PartialView();
        }
    }
}