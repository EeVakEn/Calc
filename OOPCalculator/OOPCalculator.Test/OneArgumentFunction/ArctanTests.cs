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
    class ArctanTests
    {
        [TestCase(0.1, 0.099)]
        [TestCase(1, 0.785)]
        [TestCase(0.5, 0.463)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arctan();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
