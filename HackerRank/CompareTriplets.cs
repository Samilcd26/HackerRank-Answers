using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> total = new List<int>();

            int firstPlayer = 0;
            int scondryPlayer = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    firstPlayer += 1;
                }
                else if (a[i] < b[i])
                {
                    scondryPlayer += 1;
                }
            }

            total.Add(firstPlayer);
            total.Add(scondryPlayer);

            return total;
        }
    }
}
