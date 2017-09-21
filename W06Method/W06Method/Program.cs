﻿using System;
using System.Net;  
using System.IO;   


namespace Labweek06
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = 0d;
            ask(ref w);
            calculate(ref w);
            Console.WriteLine("Weight on Moon is : {0}", w);
            Console.ReadKey();
        }
        static double ask(ref double w)
        {
            Console.Write("Enter weight on Earth : ");
            w = double.Parse(Console.ReadLine());
            return w;

        }
        static double calculate(ref double w)
        {
            w *= 1.6;
            return w;
        }
    }
}
