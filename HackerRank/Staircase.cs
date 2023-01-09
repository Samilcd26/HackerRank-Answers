using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            string Out = "";
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(Out.PadLeft((i), '#').PadLeft((n), ' '));
            }
        }
    }
}
