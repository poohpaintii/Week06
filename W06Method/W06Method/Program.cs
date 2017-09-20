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
            double d = 5e9d;
            Console.WriteLine(d);
            
            try
            {
                int i = checked((int)d);
                Console.WriteLine(i);
            }
            catch (OverflowException e)
            {
                
                Console.WriteLine(e.Message);
            }
                
        }
    }
}
