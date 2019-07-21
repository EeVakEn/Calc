using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPCalculator.OneArgumentsFunction;

namespace OOPCalculator.Test.OneArgumentFunction
{
    [TestFixture]
    class CtgTests
    {
        [TestCase(1, 0.642)]
        [TestCase(0.5, 1.830)]
        [TestCase(0.75, 1.073)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Ctan();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
