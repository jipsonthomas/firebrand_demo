using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
             // One dimensional array
            int[] Numbers;
            Numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            
            for (int i = 0; i < Numbers.Length; i++) {
                Console.WriteLine(Numbers[i]);
                
            }
            Debug.WriteLine("Numbers Length: {0}",Numbers.Length);
            Trace.WriteLine("Numbers Lenght: "+Numbers.Length);
            // two dimensional array
            int[,] Grid = new int[3, 4];
            Grid[0, 0] = 20;
            Console.WriteLine("Value of Grid");
            Console.WriteLine(Grid[0,0]);
            Debug.WriteLine("Grid[0,0]: {0}",Grid[0,0]);
            Trace.WriteLine("Grid[0,0]: "+Grid[0,0]);
            // jagged array
            int[][] Jagged = new int[3][];
            Jagged[0] = new int[4];
            Jagged[1] = new int[3];
            Jagged[2] = new int[7];
           // Jagged[3] = new int[] { 1, 2, 3, 4, 5, 6 };
            Jagged[0][3] = 20;
            Jagged[2][6] = 10;
            
            Console.WriteLine("Value of Jagged");
            Console.WriteLine("{0} {1}",Jagged[0][3],Jagged[2][6]);

            Debug.WriteLine(" Jagged[0][3]: {0}", Jagged[0][3]);
            Trace.WriteLine(" Jagged[0][3]: "+ Jagged[0][3]);

            Console.WriteLine("Praise Enter to Quit");
            Console.ReadLine();
        }
    }
}
