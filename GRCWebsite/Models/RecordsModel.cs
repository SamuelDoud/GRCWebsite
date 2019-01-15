using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class RecordsModel
    {
        public List<PerEventRecordsModel> PersonResults { get; set; }
        public int Year { get; set; }

        private int? _TakeN { get; set; }
        public int TakeN
        {
            get
            {
                if (_TakeN.HasValue)
                {
                    return TakeN;
                }
                return 5;
            }
            set
            {
                this._TakeN = value;
            }
        }

        public void GetPersonResults()
        {
            List<PerEventRecordsModel> personResults = new List<PerEventRecordsModel>();
            using (var context = new GRCDBEntities())
            {
                foreach (Event e in context.Events)
                {
                    personResults.Add(new PerEventRecordsModel(e, this.TakeN, this.Year));
                }
            }
            this.PersonResults = personResults;
        }
    }
}