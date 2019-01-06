using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRCWebsite.Controllers
{
    public class MemoriamController : Controller
    {
        // GET: Memoriam
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nina()
        {
            return View();
        }

        public ActionResult Lauren()
        {
            return View();
        }
    }
}