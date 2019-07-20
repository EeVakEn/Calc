using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.TwoArgumentsFunctions
{
    public class GeometryMean : ITwoArgumentsCalculator
    {
        public double Calculator(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue * secondValue, 1.0 / 2.0);
        }
    }
}
