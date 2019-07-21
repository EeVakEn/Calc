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
    class ArccosTests
    {
        [TestCase(0.1, 1.470)]
        [TestCase(1, 0)]
        [TestCase(0.5, 1.047)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new Arccos();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new Arccos();
            Assert.Throws<System.Exception>(() => calculator.Calculate(-4));
        }

    }
}
