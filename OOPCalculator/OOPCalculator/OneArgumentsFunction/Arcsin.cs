﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.OneArgumentsFunction
{
    public class Arcsin : I1ArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            if (firstValue > 1 || firstValue < -1)
            {
                throw new Exception("Значения должны быть от -1 до 1 включительно");
            }
            return Math.Asin(firstValue);
        }
    }
}
