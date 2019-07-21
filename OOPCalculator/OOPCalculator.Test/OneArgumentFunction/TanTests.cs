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
    class TanTests
    {

        [TestCase(1, 1.557)]
        [TestCase(10, 0.648)]
        [TestCase(2, -2.185)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Tan();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
