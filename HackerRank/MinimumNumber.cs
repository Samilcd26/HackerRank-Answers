using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class MinimumNumber
    {
        int GetNumCharsToAdd(string password)
        {
            int numCharsToAdd = 0;
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasSpecial = false;

            // Check if password meets each criteria
            if (password.Length < 8)
            {
                numCharsToAdd += 8 - password.Length;
            }

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

            return numCharsToAdd;
        }
    }
}
