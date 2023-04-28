using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    public class FindEvenOdd
    {
        public static void FindEvenOddNumber()
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(a + " " + "is a even number");
            }
            else
            {
                Console.WriteLine(a + " " + "is a odd number");
            }

        }
    }
}
