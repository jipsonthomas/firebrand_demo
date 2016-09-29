using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp.FullName = "Ad";
            emp.Name = "JT";
            emp.Salary = 200000;

           

            Console.WriteLine("{0} Make {1} pounds in an year!!!", emp.Name, emp.Salary);
            // Use reflection
            Console.WriteLine("enter Namespace.Type");
            string assembly = Console.ReadLine();
            Type type = Type.GetType(assembly);
            foreach (var item in type.GetMembers())
            {
                Console.WriteLine("{0} is {1}", item.Name, item.MemberType);
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

        }
    }
    [DeveloperInfo("jipson.thomas@gmail.com",1)]
    class Employee
    {
        public string Name { get; set; }
        // Attributes
        [Obsolete("This property will be removed. Use Name instead.")]
        public string FullName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [DebuggerDisplay(" ")]
        public decimal Salary { get; set; }
    }

    // Custom Attribute

    [AttributeUsage(AttributeTargets.All)] // targetr of attribute
    public class DeveloperInfo : Attribute
    {
        public DeveloperInfo(string email, int version)
        {
            Email = email;
            Version = version;
        }
        public string Email { get; set; }
        public int Version { get; set; }
    }
}
