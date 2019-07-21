using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.OneArgumentsFunction
{
    public class Arcctg : I1ArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.PI / 2 - Math.Atan(firstValue);
        }
    }
}
