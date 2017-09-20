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
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((9 > 7) ^ (a == b));
            Console.WriteLine((b != a) || (a == b));
            Console.WriteLine((b != a) && (a == b));
            Console.WriteLine((!a) && (!b));
            Console.WriteLine((!a) || (!b));

        }
    }
}
