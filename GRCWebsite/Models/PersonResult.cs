using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class PersonResult
    {
        public Person Racer { get; set; }
        public Event EventType { get; set; }
        public DateTime RaceTime { get; set; }
        public bool IsPR { get; set; }
    }
}