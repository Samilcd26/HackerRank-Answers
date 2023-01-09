using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class main
{
    public static void Main()
    {
       string res= timeConversion("12:45:54PM");

        Console.WriteLine(res);
    }

    public static string timeConversion(string s)
    {
        string Out= s.Substring(2, 6);
        string check =s.Substring(8, 2);
        string timezon = s.Substring(0, 2);
        if (check == "PM")
        {
            timezon = (Int16.Parse(timezon) + 12).ToString();
        }
        timezon = timezon == "12" ? "00" : timezon;
        timezon = timezon == "24" ? "12" : timezon;
        Out = timezon + Out;
        return Out;
    }

}