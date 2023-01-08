using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SimpleArraySum
    {
        public static int simpleArraySum(List<int> ar)
        {
            int total = 0;
            foreach (var item in ar)
            {
                total += item;
            }

            return total;
        }
    }
}
