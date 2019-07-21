using NUnit.Framework;
using OOPCalculator.OneArgumentsFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.Test.OneArgumentFunction
{
    [TestFixture]
    class Log10Tests
    {
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        [TestCase(2, 0.30)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Log10();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
