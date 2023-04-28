using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    public class LargestNumber
    {
        public static void FindTheLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Largest of three Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 1st Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the Greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the greatest three");
                }

            }
            else if (num2 > num3)
            {
                Console.WriteLine("the 2nd Number is the Greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is greatest among three");

            }
        }
    }
}
