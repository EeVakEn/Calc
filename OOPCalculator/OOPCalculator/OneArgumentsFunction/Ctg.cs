using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.OneArgumentsFunction
{
    public class Ctan : I1ArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return 1.0 / Math.Tan(firstValue);
        }
    }
}
