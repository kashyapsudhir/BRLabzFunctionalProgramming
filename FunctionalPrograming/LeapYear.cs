using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    public class LeapYear
    {
        
        public static void FindLeapYear(int year)
        {
            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Please enter a 4 digit year.");
                return;
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }

        }
    }
}
