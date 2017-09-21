using System;
using System.Net;  
using System.IO;   


namespace Labweek06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int W, l, h;
            Console.Write("Enter wide , long and high: ");
            W = int.Parse(Console.ReadLine());           
            l = int.Parse(Console.ReadLine());            
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("The Area of Trapezoid is : " + ans(W, l, h));
            Console.ReadKey();
        }
        static double ans(int H, int L1, int L2)
        {
            return (0.5 * (L1 + L2) * H);
        }
    }
}