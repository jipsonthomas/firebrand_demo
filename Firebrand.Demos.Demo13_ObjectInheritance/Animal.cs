using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    public abstract class Animal : IAnimal
    {
        protected string _sound;
        public Animal(int numberOfLegs, string sound)
        {
            NumberOfLegs = numberOfLegs;
            _sound = sound;
        }
        public int NumberOfLegs { get; set; }
        public virtual void DisplayName()
        {
            Console.WriteLine("Animal");
        }
        public void Vocalize()
        {
            Console.WriteLine(_sound);
        }


    }
}
