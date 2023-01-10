using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class StringToList
    {
        public List<int> stringToList(string str) {

           
            string[] words = str.Split(' ');
            List<int> list = new List<int>();

            foreach (var word in words)
            {
                list.Add(Int32.Parse(word));
                
            }

            return list;
        }

    }
}
