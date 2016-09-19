using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        private List<Activity> listActivities;

        public List<Activity> ListActivities
        {
            get { return listActivities; }
            set { listActivities = value; }
        }
        private Char[] tabEval;

        public Char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new Char[10];
        }
        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity activity)
        {
            if(ListActivities.Count()<=Parameter.MAX)
                ListActivities.Add(activity);
        }
        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = ListActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n’a pas encore choisi d’activité";
            }
            else
            {
                ch += "a choisi les activités suivantes : ";
                foreach (Activity activity in ListActivities)
                {
                    ch += "\n" + activity.ToString();
                }
            }
            return ch;
        }
        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            for(int i = 0; i < ListActivities.Count(); i++)
            {
                if (ListActivities.ElementAt(i).Title == title)
                {
                    TabEval[i] = evaluation;
                    break;
                }
            }
        }

    }
}
