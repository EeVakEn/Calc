using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OOPCalculator.Test.TwoArgumentFunction
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void MultipierTest()
        {
            MultplyCalculator
             calculator = new MultplyCalculator();
            double result = calculator.Calculator(6, 5);
            Assert.AreEqual(30, result);
        }
    }
}
