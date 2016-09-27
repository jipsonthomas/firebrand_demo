using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    public class AdvanceCalculator : SimpleCalculator
    {
        public int Mod(int x, int y) {
            return x % y;
        }
    }
}
