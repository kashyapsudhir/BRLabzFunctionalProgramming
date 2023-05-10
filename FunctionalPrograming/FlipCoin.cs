using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    public class FlipCoin
    {
        const double VALIDATION_CHECK = 0.5;
        public static void FindFlipCoin(int numOfTimes)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for (int i = 0; i < numOfTimes; i++)
            {
                double value = random.NextDouble();
                if (value < VALIDATION_CHECK)
                    tail++;
                else
                    head++;
            }

            double headPercentage = ((double)head / numOfTimes) * 100;
            double tailPercentage = ((double)tail / numOfTimes) * 100;
            Console.WriteLine("Head Percentage---> " + headPercentage + "\nTail Percentage---> " + tailPercentage);


        }
    }
}
