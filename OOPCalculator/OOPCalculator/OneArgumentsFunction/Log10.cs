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
            if (firstValue < 0)
            {
                throw new Exception("Значение должно быть больше 0");
            }
            return Math.Log10(firstValue);
        }
    }
}
