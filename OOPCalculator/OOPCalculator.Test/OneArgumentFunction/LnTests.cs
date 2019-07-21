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
    class LnTests
    {
        [TestCase(2, 0.69)]
        [TestCase(1, 0)]
        [TestCase(0.5, -0.69)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Ln();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Ln();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4));
        }
    }
}
