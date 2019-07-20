using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.TwoArgumentsFunctions
{
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        public double Calculator(double firstValue, double secondValue)
        {
            return (firstValue + secondValue) / 2.0;
        }
    }
}
