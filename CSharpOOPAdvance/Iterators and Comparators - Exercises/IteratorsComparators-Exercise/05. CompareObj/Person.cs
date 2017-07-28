using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareObj
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string Town
        {
            get { return this.town; }
            private set { this.town = value; }
        }


        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }
            var nameComparison = string.Compare(this.name, other.name, StringComparison.Ordinal);
            if (nameComparison != 0)
            {
                return nameComparison;
            }
            var ageComparison = this.age.CompareTo(other.age);
            if (ageComparison != 0)
            {
                return ageComparison;
            }
            return string.Compare(this.town, other.town, StringComparison.Ordinal);
        }
    }
}
