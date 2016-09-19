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

            List<Pupil> listPupil = new List<Pupil>()
            {
                new Pupil("Elie", 5, 2),
                new Pupil("Eise", 8, 3),
                new Pupil("Ese", 4, 2),
                new Pupil("Eise", 9, 4),
                new Pupil("Ee", 11, 7),
                new Pupil("Eser", 6, 1),
            };

            var primaire = from pupil in listPupil
                           where pupil.Age > 6 && pupil.Grade >= 1 && pupil.Grade <= 6
                           select pupil;
            if(primaire!=null)
                foreach(var pupil in primaire)
                {
                    Console.WriteLine(pupil.ToString());
                }
            Console.ReadKey();


        }
    }
}
