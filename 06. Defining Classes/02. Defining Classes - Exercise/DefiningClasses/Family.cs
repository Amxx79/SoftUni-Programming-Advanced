using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> people;

        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People
        {
            get
            { 
                return this.people; 
            }
            set
            {
                this.people = value;
            }
        }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.People.MaxBy(p => p.Age);
        }
    }
}
