using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public static class Parameter
    {
        private const int mAX = 10;

        public static int MAX
        {
            get
            {
                return mAX;
            }
        }

        enum Notes
        {
            R='R',S='S',T='T'
        };

    }
}
