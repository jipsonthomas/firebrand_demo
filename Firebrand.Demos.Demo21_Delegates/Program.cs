using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo21_Delegates
{
    class Program
    {
        // create a class MyDeligate
        delegate void MyDeligate(string name);
        static void Main(string[] args)
        {
            SayHello("Aidan");
            // Get a hold of a reference to a method
            MyDeligate del = new MyDeligate(SayHello);
            del += SayGoodBye;
            del.Invoke("Gisha");
            del("Jipson");
            del -= SayHello;
            Test(del);
            // Anonymous methods and delegates
            MyDeligate del1 = delegate(string name) { Console.WriteLine("My Lord ! My God!, {0}",name); };
            del1("Anonymous Deligate");
            // lamda expressions
            MyDeligate del2 = (string name) => { Console.WriteLine("My Lord ! My God!, {0}", name); };
            del2("Lamda Deligate");
            // Lamda 2
            MyDeligate del3 = ( name) => { Console.WriteLine("My Lord ! My God!, {0}", name); };
            del3("Lamda3 Deligate");

            // Lamda 3
            MyDeligate del4 = name => { Console.WriteLine("My Lord ! My God!, {0}", name); };
            del4("Lamda4 Deligate");
            // Lamda 4
            //MyDeligate del5 = (fname,lname) => { Console.WriteLine("My Lord ! My God!, {0}", fname,lname); };
            //del5("Lamda4 Deligate");

            // Generic delegates : Fun & Action (Action can receive but not return)
            Action<string> del6 = name => { Console.WriteLine("My Lord ! My God!, {0}", name); };
            //del5("Lamda4 Deligate");
            Action<string,string> del7 = (fname, lname) => { Console.WriteLine("My Lord ! My God!, {0},{1}", fname, lname); };
            del7("Lamda4 Deligate","Action");

            Func<int, int, int> del8 = (x, y) => { return x * y; };
            int result = del8(2, 4);
            Console.WriteLine(result);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hey There, {0}!",name);
        }
        static void SayGoodBye(string name)
        {
            Console.WriteLine("{0}, Good Bye!!!", name);
        }
        static void Test (MyDeligate del)
        {
            del("John");
        }
    }
}
