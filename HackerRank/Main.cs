using HackerRank;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

public class main
{
    public static void Main()
    {
        //string con = "0 9 3 10 2 20";
        //List<int> ints = new List<int>();
        ////String To list
        //StringToList conver = new StringToList();
        //ints=conver.stringToList(con);

        int Out;
        string pasword = "#**#*";

        List<int> apples = new List<int>() { -2 ,2 ,1 };
        List<int> oranges = new List<int>() { 5 ,-6 };

        Out= minimumNumber(pasword.Length, pasword);
        Console.WriteLine(Out);
    }

    public static int minimumNumber(int n, string password)
    {
        
            int numCharsToAdd = 0;
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasSpecial = false;

            // Check if password meets each criteria
            

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if ("!@#$%^&*()-+".Contains(c))
                {
                    hasSpecial = true;
                }
            }

            // Add one to the count if the criteria is not met
            if (!hasDigit)
            {
                numCharsToAdd += 1;
            }
            if (!hasLower)
            {
                numCharsToAdd += 1;
            }
            if (!hasUpper)
            {
                numCharsToAdd += 1;
            }
            if (!hasSpecial)
            {
                numCharsToAdd += 1;
            }
        if (password.Length < 6)
        {
            numCharsToAdd += 6 - password.Length- numCharsToAdd;
        }
        return numCharsToAdd;
        
    }

      

}