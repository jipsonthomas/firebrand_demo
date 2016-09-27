using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrands.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Longitude:");
            int lng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Latitude:");
            int lat = Convert.ToInt32(Console.ReadLine());
            Coordinates MyCoordinate = new Coordinates();
            MyCoordinate.Latitude = lat;
            MyCoordinate.Longitude = lng;

            Console.WriteLine("Latitude is :{0}",MyCoordinate.Latitude);
            Console.WriteLine("Longitude is :{0}",MyCoordinate.Longitude);
            Console.ReadKey();
        }
    }
    public struct Coordinates
    {
        private int _latitud, _longitud;
        public int Latitude {
            get { return _latitud; }
            set { _latitud = value; }
        }
        public int Longitude {
            get { return _longitud; }
            set{_longitud = value; }
        }
    }
}
