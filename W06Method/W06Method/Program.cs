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
            byte a = 3;
            byte b = 5;
            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a & b);
            Console.WriteLine("{0}", Convert.ToString(a << 1, 2).PadLeft(8, '0'));
            Console.WriteLine("{0}", Convert.ToString(a >> 1).PadLeft(8, '0'));

        }
    }
}
