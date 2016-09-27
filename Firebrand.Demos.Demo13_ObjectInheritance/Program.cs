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
            GermenShepherd max = new GermenShepherd();
            max.Vocalize();
            Monkey KingLouise = new Monkey();
            KingLouise.Vocalize();

            var animals = new IAnimal[]{
                new Dog(),
                new GermenShepherd(),
                new Monkey()};
            foreach (var animal in animals)
            {
                animal.Vocalize();
            }
            Dog Spock = new GermenShepherd();
            GermenShepherd Harry = new GermenShepherd();
            Spock.DisplayName();
            Harry.DisplayName();
            Console.ReadKey();
        }
        
       
    }
    public class Monkey : Animal
    { 
       public Monkey() : base(2,"Ooooh monkey sound!!!")
        {
        }
        // Overriding base class method
        public override void DisplayName()
        {
             // To extend from parent class
            //base.DispayName();
            Console.WriteLine("Monkey");
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
    public class GermenShepherd : Dog
    {
        public GermenShepherd()
            : base("Big woolf from GS")
        {
 
        }
        public new void DisplayName()
        {
            Console.WriteLine("German Shepherd");
        }
    }
}
