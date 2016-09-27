using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Run1());
            Console.WriteLine(Run2());
            Console.WriteLine(Run3());
            Console.WriteLine(Run4());
            Console.WriteLine(Run5());
            Console.WriteLine("Praise Enter to Quit");
            Console.ReadLine();
        }

        static long Run1() {return Run(10000);}
        static long Run2() { return Run(30000); }
        static long Run3() { return Run(40000); }
        static long Run4() { return Run(25000); }
        static long Run5() { return Run(35000); }
        static long Run(int max)
        {
            long x = 0;

            for (int y = 0; y < max; y++)
            {
                for (int z = 0; z < max; z++)
                {
                    x += z;
                }
            }
            return x;
        }
    }
}
