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
            Product[] productlist ={ new Product(10,"ic-cream","Dessert","Chocolaqte"),
                                       new Product(15,"Cake","Dessert","Vanila"),
                                       new Product(30,"ic-cream","Dessert","Vanila"),
                                       new Product(20,"Tea","Drink","Earl Grey")
                                   };
            Array.Sort(productlist);
            Product[] orderedProducts = BubbleSort<Product>(productlist);
            foreach (var product in productlist)
            {
                Console.WriteLine("Product Name : {0}, Product Price: {1}", product.Name, product.Price);
            }
            Console.WriteLine("Generic Bubble Sort");
            foreach (var product in orderedProducts)
            {
                Console.WriteLine("Product Name : {0}, Product Price: {1}", product.Name, product.Price);
            }
            Console.WriteLine("Int Bubble Sort");
            int[] intArray = new[] { 2, 6, 3, 5, 2, 1, 8, 67, 34, 98, 23, 10 };
            int[] orderedArray = BubbleSort(intArray);
            foreach (var item in orderedArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] BubbleSort(int[] array)
        {
            int swap;
            for (int outer = array.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    if (array[inner] > array[inner + 1])
                    {
                        swap = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = swap;
                    }

                }
            }
            return array;
        }
        public static T[] BubbleSort<T>(T[] array) where T : IComparable
        {
            T swap;
            for (int outer = array.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    if (array[inner].CompareTo( array[inner + 1]) > 0)
                    {
                        swap = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = swap;
                    }

                }
            }
            return array;
        }
    }
}
