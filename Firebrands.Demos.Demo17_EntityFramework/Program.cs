using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrands.Demos.Demo17_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FourthCoffeeEntities();
            var employees = context.Employees;
            foreach (var employee in employees)
            {
                Console.WriteLine("{0} was born in {1}", employee.FullName, employee.DateOfBirth);
            }
            var Employee = context.Employees.First(x => x.FirstName == "Charlie");
            Console.WriteLine("We found {0}, {1}", Employee.LastName, Employee.FirstName);
            Employee.LastName = "Smith";
            context.SaveChanges();
            Console.ReadKey();
        }
    }
}
