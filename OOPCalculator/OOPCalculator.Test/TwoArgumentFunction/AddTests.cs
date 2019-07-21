using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OOPCalculator.Test.TwoArgumentFunction
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void AdderTest()
        {

            AdditionCalculator calculator = new AdditionCalculator();
            double result = calculator.Calculator(2, 5);
            Assert.AreEqual(7, result);
        }

    }
}
