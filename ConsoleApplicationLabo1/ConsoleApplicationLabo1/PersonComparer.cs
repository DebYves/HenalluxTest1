using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person p1, Person p2)
        {
            return p1.Name==p2.Name && p1.Age==p2.Age;
        }
        public int GetHashCode(Person p1)
        {
            return p1.GetHashCode();
        }
    }
}
