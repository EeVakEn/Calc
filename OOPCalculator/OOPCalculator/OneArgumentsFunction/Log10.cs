using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.OneArgumentsFunction
{
    public class Log10 : I1ArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
