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

        public ActionResult ProfilePage(int id)
        {
            return View();
        }

        public ActionResult ProfilePage(string name)
        {
            return View();
        }

        public PartialViewResult PersonalProfile(int id)
        {
            GRCDBEntities context = new GRCDBEntities();
            Person person = context.Persons.Where(ppl => ppl.Id == id).First();
            PersonalRecord prs = context.PersonalRecords.Where(allPrs => allPrs.PersonId == id).First();

            if (person != null && prs != null)
            {
                ProfileModel profile = new ProfileModel()
                {
                    Person = person,
                    PersonalRecords = prs
                };
                return PartialView(profile);
            }

            return null;
        }

        public PartialViewResult PersonalProfile(string name)
        {
            GRCDBEntities context = new GRCDBEntities();
            Person person = context.Persons.Where(ppl => ppl.Name.ToLower().Contains(name)).First();
            return this.PersonalProfile(person.Id);
        }


    }
}