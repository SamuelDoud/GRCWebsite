using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRCWebsite.Models
{
    public class TeamModel
    {
        public TeamModel()
        {
            TeamMembers = new List<ProfileModel>();
        }
        public TeamModel(List<Person> people, List<PersonalRecord> personalRecords)
        {
            this.TeamMembers = new List<ProfileModel>();
            foreach (Person person in people)
            {
                this.TeamMembers.Add(
                    new ProfileModel()
                    {
                        Person = person,
                        PersonalRecords = personalRecords.Where(p => p.PersonId == person.Id).ToList()
                    }
                );
            }
            RemoveMembers();
        }

        private void RemoveMembers()
        {
            this.TeamMembers = this.TeamMembers.Where(p => p.Person.Name != "Jerry Alexander").ToList();
        }

        public List<ProfileModel> TeamMembers { get; set; }

        public List<ProfileModel> MaleTeamMembers
        {
            get
            {
                return TeamMembers.Where(t => t.Person.Gender == "M" && t.Person.IsActive).ToList();
            }
        }

        public List<ProfileModel> FemaleTeamMembers
        {
            get
            {
                return TeamMembers.Where(t => t.Person.Gender == "F" && t.Person.IsActive).ToList();
            }
        }

        public List<ProfileModel> Expats
        {
            get
            {
                return TeamMembers.Where(t => !t.Person.IsActive).ToList();
            }
        }
    }
}