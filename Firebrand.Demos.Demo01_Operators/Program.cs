using System;
using System.Text;

namespace Firebrand.Demos.Demo01_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int UnitCost = 5;
            long Quantity;
            short DayofYear = 365;
            Int16 DaysofWeek = 7;
            string Message = "Total" + "Amount ";
            Quantity = 345600000000000000;
            //casting
            var TotalCost = Quantity * UnitCost;
            Console.WriteLine("Total Cost: {0}",TotalCost);
            Console.WriteLine("Praise Enter to Quit");
            Console.ReadLine();
        }
    }
}
