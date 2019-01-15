using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class PerEventRecordsModel
    {
        public int TakeN { get; private set; }
        public Event Event { get; private set; }
        public List<PersonalRecord> TopResultsMales { get; private set; }
        public List<PersonalRecord> TopResultsFemales { get; private set; }
        public int? Year { get; private set; }

        public PerEventRecordsModel(Event @event, int takeN, int? year=null)
        {
            this.Event = @event;
            this.TakeN = takeN;
            this.ComputeTopResults();
            this.Year = year;
        }

        private void ComputeTopResults()
        {
            using (var context = new GRCDBEntities())
            {
                // Maybe should have the OrderBy after the Where. Saing a cast by doing it this way.
                var personalRecords = context.PersonalRecords.OrderBy(pr => pr.Time).Where(pr => pr.Event == this.Event && pr.GRC);
                if (Year.HasValue)
                {
                    personalRecords = context.PersonalRecords.Where(pr => (pr.Date.HasValue == true ? pr.Date.Value.Year : -1) == this.Year);
                }
                TopResultsMales = personalRecords.Where(pr => pr.Person.Gender == "M").Take(this.TakeN).ToList();
                TopResultsFemales = personalRecords.Where(pr => pr.Person.Gender == "F").Take(this.TakeN).ToList();
            }
        }
    }
}