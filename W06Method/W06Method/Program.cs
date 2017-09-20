using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06Assignment
{
    class Program
    {
        static void Main()
        {
            int x;
            Console.WriteLine("Enter Your Number : ");
            x = int.Parse(Console.ReadLine());
            if (OddEven(x) > 0) Console.WriteLine("Odd");
            else Console.WriteLine("Even");
            Console.ReadKey();
        }

        static int OddEven(int c)
        {
            c = c % 2;
            return c;
        }

    }
}
