using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo20_CallingRestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "http://localhost:3358/api/employees";
            var request = WebRequest.Create(uri) as HttpWebRequest;
            var response = request.GetResponse() as HttpWebResponse;
            Console.WriteLine("Status Code : {0}", response.StatusCode);
            Console.ReadKey();
            //request.Method = "POST";

        }
    }
}
