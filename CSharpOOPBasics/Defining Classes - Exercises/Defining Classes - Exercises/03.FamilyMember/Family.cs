using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FamilyMember
{
    public class Family
    {
        public List<Person> ListOFMembers;

        public Family()
        {
            this.ListOFMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            ListOFMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.ListOFMembers
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
        }
    }
}