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
            int x, y,result =0;
            string op;
            string quitop = " ";
            AdvanceCalculator calc = new AdvanceCalculator();
            while (quitop != "Quit") {
                Console.WriteLine("Enter X");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Y");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Operation");
                op = Console.ReadLine();
               switch (op)
                    {
                        case "Add":
                            result = calc.Add(x, y);
                            break;

                        case "Sub":
                            result = calc.Suv(x, y);
                            break;

                        case "Mul":
                            result = calc.Mul(x, y);
                            break;

                        case "Div":
                            result = calc.Div(x, y);
                            break;

                        case "Mod":
                            result = calc.Mod(x, y);
                            break;
                        default:
                            break;
                    }
                Console.WriteLine("Result : {0}", result);
                Console.WriteLine("Praise Enter \"Quit to \" Quit");
                quitop = Console.ReadLine();
                
            }
            
        }
    }
}
