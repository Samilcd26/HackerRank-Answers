using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            BigInteger min = 0, max = 0;
            arr.Sort();
            for (int i = 0; i < arr.Count - 1; i++)
            {

                min += arr[i];
            }
            arr.Reverse();
            for (int j = 0; j < arr.Count - 1; j++)
            {
                max += arr[j];
            }

            Console.WriteLine(min + " " + max);
        }
    }
}
