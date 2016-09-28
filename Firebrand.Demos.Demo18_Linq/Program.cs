using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo18_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 20);
            var method = data.Where(x => x % 2 == 0)
                .Select(x => x.ToString());
            Console.WriteLine("Extension Method");
            foreach (var item in method)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Linq Method");
            var query = from d in data
                        where d % 2 == 0
                        orderby d descending
                        select d.ToString();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            var query2 = from d in data
                         select new
                             {
                                 Even = (d % 2 == 0),
                                 Odd = (d % 2 != 0),
                                 Value = d
                             };
            foreach (var item in query2)
            {
                Console.WriteLine("{0} - {1} - {2}", item.Value,item.Even,item.Odd);
            }

            var values = new[] { "A", "A", "B", "A", "C", "D", "B" };
            var distinct = values.Distinct();
            var first = values.First();
            var last = values.Last();
            var page = values.Skip(2).Take(2);
            var dictionary1 = new Dictionary<string, string>()
            {
                {"1","A"},{"6","A"},{"3","B"},{"4","B"}
            };
            var dictionary2 = new Dictionary<string, string>()
            {
                {"5","A"},{"6","A"},{"7","B"},{"8","B"}
            };
            var group = from d in dictionary1
                        group d by d.Value into g
                        select new
                            {
                                key = g.Key,
                                Member = g
                            };
            var join = from d1 in dictionary1
                       join d2 in dictionary2
                       on d1.Value equals d2.Value
                       select new
                           {
                               Key1=d1.Key,
                               Key2=d2.Key,
                               Value=d1.Value
                           };
            Debugger.Break();
            Console.ReadKey();

        }
    }
}
