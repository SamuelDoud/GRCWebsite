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
            using (var context = new GRCDBEntities())
            {
                List<Person> people = context.Persons.ToList();
                List<PersonalRecord> prs = context.PersonalRecords.ToList();
                return View(new TeamModel(people, prs));
            }
        }

        public ActionResult PerformanceList()
        {
            return View();
        }

        public ActionResult Records()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProfilePage(int id)
        {
            using (var context = new GRCDBEntities())
            {
                ProfileModel profile = new ProfileModel()
                {
                    Person = context.Persons.Single(p => p.Id == id),
                    PersonalRecords = context.PersonalRecords.Where(p => p.PersonId == id).ToList()
                };
                ViewBag.CanEdit = Profile.UserName != null && Profile.UserName == profile.Person.Email;
                return View(profile);
            }
        }

        [HttpPost]
        public PartialViewResult _PersonalProfile(ProfileModel profile)
        {
            return PartialView(profile);
        }

        [HttpPost]
        public PartialViewResult _EditProfile(ProfileModel profile)
        {
            return PartialView(new EditProfileModel(profile));
        }

        [HttpPost]
        private ActionResult EditProfileOnDatabase(EditProfileModel profile)
        {
            if (Profile.UserName == profile.Person.Email)
            {
                bool changesMade = false;
                List<PersonalRecord> prs;
                Person person;

                using (var db = new GRCDBEntities())
                {
                    prs = db.PersonalRecords.Where(pr => pr.PersonId == profile.Person.Id).ToList();
                    person = db.Persons.Single(p => p.Id == profile.Person.Id);
                    if (person != null && person != profile.Person)
                    {
                        person = profile.Person;
                        changesMade = true;
                    }
                    if (prs != null && prs != profile.PersonalRecords)
                    {
                        prs = profile.PersonalRecords;
                        changesMade = true;
                    }
                    if (changesMade)
                    {
                        db.SaveChanges();
                    }
                }
                return ProfilePage(person.Id);
            }
            throw new Exception("You are not authorized to edit this page");
        }
    }
}