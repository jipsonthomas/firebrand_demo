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
            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Console.WriteLine("Is {0} a valid email address ? {1}", email, email.IsNormalized());
            Console.ReadKey();
        }
    }

    static class MyFunctions
    {
        public static bool IsValidEmail(this string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public static bool IsNormalized(this string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        
    }
}
