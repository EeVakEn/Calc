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
    class ArcsinTests
    {
        [TestCase(0.1, 0.100)]
        [TestCase(1, 1.570)]
        [TestCase(0.5, 0.523)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
