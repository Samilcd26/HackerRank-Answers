using HackerRank;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

public class main
{
    public static void Main()
    {
        string con = "0 9 3 10 2 20";
        List<int> ints = new List<int>();
        //String To list
        StringToList conver = new StringToList();
        ints=conver.stringToList(con);
        //foreach(int i in ints)
        //{
        //    Console.WriteLine(i);
        //}
        /////////////////////////

        List<int> Outt= breakingRecords(ints);

        
    }

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> respon = new List<int>();
        int minScor=0, maxScor=-1;
        int Min = scores[0];
        int Max = 0;

        foreach (int x in scores)
        {
            if (x < Min)
            {
                Min =x;
                minScor += 1;

            }else if (x> Max)
            {
                Max = x;
                maxScor += 1;
            }
        };
        respon.Add(maxScor);
        respon.Add(minScor);

        
        return respon;
    }

}