using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class main
{
    public static void Main()
    {
        List<int> a = new List<int> { 11, 2 ,4 ,9,5,-6};
        List<int> b = new List<int> { 4 ,5 ,6, 8,6,0 };
        List<int> c = new List<int> { 10 ,8, - 12,3,6,1 };
        List<int> d = new List<int> { 11, 2, 4, 9, 5, -6 };
        List<int> e = new List<int> { 4, 5, 6, 8, 6, 0 };
        List<int> k = new List<int> { 10, 8, -12, 3, 6, 1 };

        List<List<int>> arr = new List<List<int>> { };

        arr.Add(a);
        arr.Add(b);
        arr.Add(c);
        arr.Add(d);
        arr.Add(e);
        arr.Add(k);


        var rs = diagonalDifference(arr);
        Console.WriteLine(rs);
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int totalOne = 0;
        int totalTwo = 0;
        List<int> line =new List<int>() { };
     
      
        int pointOne = 0;
        int pointTwo = 0;
        int Out=0;
        int mod = 6;

        foreach (var item in arr)
        {
            foreach (var item2 in item)
            {
                line.Add(item2);
            }
        }


        mod = (int)Math.Sqrt(line.Count);

        for (int i = 1; i <= mod; i++)
        {
            totalOne += line[0 + pointOne];
            totalTwo += line[(mod-1) + pointTwo];
            //3+1 =4
            //Console.WriteLine(line[0 + pointOne] + "-----" + line[(mod - 1) + pointTwo]);

            pointOne += (mod+1);
            
            pointTwo += (mod - 1);
            
        }
        
        Out = totalOne > totalTwo ? (totalOne - totalTwo): (totalTwo - totalOne);
        return Out;
    }

}