using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class RacesModel
    {
        public DateTime RaceDate { get; set; }
        public string ResultsLink { get; set; }
        public string RaceLink { get; set; }
        public string RaceLocation { get; set; }
        public List<PersonResult> PersonResults { get; set; }
        public string Notes { get; set; }
    }
}