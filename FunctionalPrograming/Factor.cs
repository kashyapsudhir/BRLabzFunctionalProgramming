using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    public class Factor
    {
        
        public static void FindFactor(int n)
        {
            Console.WriteLine("Prime factors of " + n + " are: ");

            
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 1)
            {
                Console.Write(n);
            }

            Console.WriteLine();
        }
    }
}
