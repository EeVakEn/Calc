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
    class ArcctgTests
    {
        [TestCase(0.1, 1.471)]
        [TestCase(1, 0.785)]
        [TestCase(0.5, 1.107)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arcctg();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}
