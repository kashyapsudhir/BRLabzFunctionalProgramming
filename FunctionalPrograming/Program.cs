﻿using System;

namespace FunctionalPrograming
{
    public class program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to functional Program Practice Problems");
            int YEAR = Convert.ToInt32(Console.ReadLine());
            LeapYear.FindLeapYear(YEAR);
            

        }
    }
}