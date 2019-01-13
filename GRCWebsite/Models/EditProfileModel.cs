using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class EditProfileModel
    {
        public Person Person { get; set; }
        public List<PersonalRecord> PersonalRecords { get; set; }

        public EditProfileModel()
        {

        }

        public EditProfileModel(ProfileModel profile)
        {
            this.Person = profile.Person;
            this.PersonalRecords = profile.PersonalRecords;
        }
    }
}