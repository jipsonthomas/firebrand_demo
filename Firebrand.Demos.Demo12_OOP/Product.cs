using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    
    public class Product: IComparable
    {
        public Product(int price, string name, string category, string flavour)
        {
            this.Price = price;
            this.Category = category;
            this.Name = name;
            this.Flavour = flavour;
        }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Flavour { get; set; }

        public int CompareTo(object obj)
        {
            Product other = (Product)obj;
            return this.Price.CompareTo(other.Price);
            //return this.Name.CompareTo(other.Name);
        }
    }
}
