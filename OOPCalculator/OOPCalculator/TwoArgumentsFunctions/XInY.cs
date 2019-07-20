using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.TwoArgumentsFunctions
{
    public class XInY : ITwoArgumentsCalculator
    {
        public double Calculator(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
