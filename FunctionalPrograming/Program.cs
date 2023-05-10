using System;

namespace FunctionalPrograming
{
    public class program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to functional Program Practice Problems");
            Console.WriteLine("enter your number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Factor.FindFactor(Number);
            

        }
    }
}