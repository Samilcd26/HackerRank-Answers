using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CountApplesAndOranges
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleLog = 0;
            int orangeLog = 0;

            foreach (int i in apples)
            {
                if (s <= (a + i) && (a + i) <= t)
                {
                    appleLog += 1;
                }
            }

            foreach (int o in oranges)
            {
                if (s <= (b + o) && (b + o) <= t)
                {
                    orangeLog += 1;
                }
            }

            Console.WriteLine(appleLog);
            Console.WriteLine(orangeLog);

        }
    }
}
