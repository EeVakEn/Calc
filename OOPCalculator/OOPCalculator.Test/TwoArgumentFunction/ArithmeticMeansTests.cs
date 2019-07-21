using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPCalculator.TwoArgumentsFunctions;

namespace OOPCalculator.Test.TwoArgumentFunction
{
    [TestFixture]
    public class ArithmeticMeansTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(4, 6, 5)]
        [TestCase(1, 3, 2)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new ArithmeticMean();
            var actualResult = calculator.Calculator(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
