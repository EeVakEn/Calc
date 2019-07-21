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
    public class GeometryMeanTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(4, 4, 4)]
        [TestCase(8, 2, 4)]
        public void CalculateTest(double arOne, double arTwo, double expected)
        {
            var calculator = new GeometryMean();
            var actualResult = calculator.Calculator(arOne, arTwo);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
