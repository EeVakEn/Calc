﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculator(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
