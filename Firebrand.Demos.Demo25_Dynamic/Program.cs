using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo25_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = "Hello";
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d = new System.Dynamic.ExpandoObject();
            d.Firstname = "Jipson";
            d.Age = 33;
            Console.WriteLine("{0} is {1} years old",d.Firstname,d.Age);
            var pythonRuntime = Python.CreateRuntime();
            dynamic pythonFile = pythonRuntime.UseFile("HelloPython.py");
            pythonFile.SayHelloFromPython();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
