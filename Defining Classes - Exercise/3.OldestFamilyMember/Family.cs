using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members = new List<Person>();
        public List<Person> Members { get { return members; } set { members = value; } }

        public void AddMember(Person person)
        {
            members.Add(person);
        }
        public Person GetOldestMember()
        {
            Person oldest = members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;

        }
    }
}
