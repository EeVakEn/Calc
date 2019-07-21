using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculator(double firstValue, double secondValue)
        {
            if (secondValue == 0)

            {

                throw new Exception("Деление на 0");

            }
            return firstValue / secondValue;
        }
    }
}
