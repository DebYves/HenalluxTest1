using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person y = new Person("Yves", 23);
            Activity a = new Activity("refef", true);
            Activity a2 = new Activity("rreefef", true);
            Activity a3 = new Activity("rerefef", false);
            Pupil x = new Pupil("Elise", 7, 2);
            
            x.AddActivity(a);
            x.AddActivity(a3);
            x.AddActivity(a2);

            x.AddEvaluation("refef");
            x.AddEvaluation(evaluation: 'T', title: "rerefef");

            Console.WriteLine(x.ToString());
            Console.WriteLine(x.TabEval[0]);
            Console.WriteLine(x.TabEval[1]);

            //part 2

            List<Pupil> listPupil = new List<Pupil>()
            {
                new Pupil("Elie", 5, 2),
                new Pupil("Eise", 8, 3),
                new Pupil("Ese", 4, 2),
                new Pupil("Eise", 9, 4),
                new Pupil("Ee", 11, 7),
                new Pupil("Eser", 6, 1),
            };

            //enfants en primaire de + de 6ans
            /*var primaire = from pupil in listPupil
                           where pupil.Age > 6 && pupil.Grade >= 1 && pupil.Grade <= 6
                           select pupil;
            */
            var primaire = listPupil.Where(pupil => pupil.Age > 6 && pupil.Grade >= 1 && pupil.Grade <= 6);
            if (primaire!=null)
                foreach(var pupil in primaire)
                {
                    Console.WriteLine(pupil.ToString());
                }

            //part 3 (covariance)
            List<Person> listPerson = new List<Person>()
            {
                new Pupil("Jo", 5),
                new Pupil("Joe", 8),
                new Pupil("Jose", 4),
                new Pupil("Jese", 9),
                new Pupil("Joes", 11),
                new Pupil("Eset", 6),
            };

            var listFusion = listPerson.Union(listPupil);
            foreach (Person p in listFusion)
            {
                Console.WriteLine(p.Name);
            }

            List<Pupil> listPupilDup = new List<Pupil>()
            {
                new Pupil("Elie", 5, 2),
                new Pupil("Eise", 8, 3),
                new Pupil("Ese", 4, 2),
                new Pupil("Eise", 9, 4),
                new Pupil("Ee", 11, 7),
                new Pupil("Eser", 6, 1),
                new Pupil("Elie", 5, 2),
                new Pupil("Eise", 8, 3),
                new Pupil("Ese", 4, 2),
                new Pupil("Eise", 9, 4),
                new Pupil("Ee", 11, 7),
                new Pupil("Eser", 6, 1)
            };

            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilDup.Distinct<Pupil>(new PersonComparer());
            Console.WriteLine(listPupilsNoDuplicated.Count());

            Console.ReadKey();
        }
    }
}
