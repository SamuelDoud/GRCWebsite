﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class ProfileModel
    {
        public Person Person { get; set; }
        public List<PersonalRecord> PersonalRecords { get; set; }
    }
}