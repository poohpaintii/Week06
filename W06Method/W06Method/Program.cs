using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06OPERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 9.9d;
            Console.WriteLine(myDouble);
            long myLong = (long)myDouble;
            Console.WriteLine(myLong);
            myDouble = 9e9d;
            Console.WriteLine(myDouble);
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine(int.MinValue);

        }
    }
}
