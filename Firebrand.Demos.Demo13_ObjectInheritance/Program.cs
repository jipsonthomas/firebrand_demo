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
            Dog rober = new Dog("This dog can say hello");
            rober.Vocalize();
            Console.ReadKey();
        }
        
       
    }
    public class Dog : Animal
    {
        public Dog(): base(4,"Woof!")
        {
            
        }
        public Dog(string sound)
            : base(4, sound)
        {

        }
        // Overriding base class method
         public override void DisplayName()
        {
             // To extend from parent class
            //base.DispayName();
            Console.WriteLine("Dog");
        }
    }
}
