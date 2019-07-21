using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPCalculator.Test.TwoArgumentFunction
{
    [TestFixture]
    public class DivideTests
    {

        [Test]
        public void DividerTest()
        {

            DivisionCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculator(6, 3);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void NegativeCalculateTest()
        {
            var calculator = new DivisionCalculator();
            Assert.Throws<System.Exception>(() => calculator.Calculator(2, 0));
        }
    }
}
