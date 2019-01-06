using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRCWebsite.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }

        public ActionResult Upcoming()
        {
            return View();
        }
    }
}