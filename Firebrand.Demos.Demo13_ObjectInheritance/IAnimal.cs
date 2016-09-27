using System;
namespace Firebrand.Demos
{
    interface IAnimal
    {
        void DisplayName();
        int NumberOfLegs { get; set; }
        void Vocalize();
    }
}
