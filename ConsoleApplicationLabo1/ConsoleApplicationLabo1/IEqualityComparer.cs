using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    interface IEqualityComparer<Person>
    {
        Boolean Equals(Person p1, Person p2);
        int GetHashCode(Person p1);
    }
}
