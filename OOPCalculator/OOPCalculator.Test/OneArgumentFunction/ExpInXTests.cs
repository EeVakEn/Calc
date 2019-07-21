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
    class ExpInXTests
    {
        [TestCase(1, 2.71)]
        [TestCase(4, 54.59)]
        [TestCase(2, 7.38)]
        public void CalculateTest(double arOne, double expected)
        {
            var calculator = new ExpLnX();
            var actualResult = calculator.Calculate(arOne);
            Assert.AreEqual(expected, actualResult,0.01);
        }
    }
}
