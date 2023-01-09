using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class ExtraLongFactorials
    {
        public static void extraLongFactorials(int n)
        {
            if (n == 0) Console.WriteLine(0);
            
            BigInteger total = new BigInteger(1);
            for (int i = n; 0 < i; i--)
            {
                total *= i;
            }

            Console.WriteLine(total.ToString());
        }
    }
}
