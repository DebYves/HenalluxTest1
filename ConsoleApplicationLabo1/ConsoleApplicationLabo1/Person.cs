using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    
    class Person
    {
        //private String name;
        private int age;

        /*public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }*/
        public String Name { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = (value>0)?value:1;
            }
        }
        public Person(String name,int age)
        {
            Name = name;
            Age = age;
        }
        public override String ToString()
        {
            return Name+" âgé(e) de "+Age+" ans ";
        }
    }
}
