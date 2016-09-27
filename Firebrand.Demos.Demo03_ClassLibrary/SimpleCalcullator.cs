using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    public class SimpleCalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Suv(int x, int y)
        {
            return x - y;
        }
        public int Div(int x, int y)
        {
           
            try
            {
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Y must be greater than zeor to divide");
                }
                return x / y;
            }
            catch (DivideByZeroException e)
            {
                throw new InvalidOperationException(e.Message);
            }
            catch (Exception e)
            {
                return 0;
            }
           
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }

    }
}
