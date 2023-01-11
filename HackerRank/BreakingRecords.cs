using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BreakingRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> respon = new List<int>();
            int minScor = 0, maxScor = 0;
            int Min = scores[0];
            int Max = scores[0];

            foreach (int x in scores)
            {
                if (x < Min && x > Max)
                {
                    Min = x;
                    Max = x;
                    minScor += 1;
                    maxScor += 1;

                }
                else if (x > Max)
                {

                    Max = x;
                    maxScor += 1;
                }
                else if (x < Min)
                {

                    Min = x;
                    minScor += 1;
                }
            };
            respon.Add(maxScor);
            respon.Add(minScor);


            return respon;
        }
    }
}
