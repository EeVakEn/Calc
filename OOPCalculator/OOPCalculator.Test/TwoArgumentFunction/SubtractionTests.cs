using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOPCalculator.Test.TwoArgumentFunction
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void MultipierTest()
        {

            SubtractionCalculator calculator = new SubtractionCalculator();
            double result = calculator.Calculator(6, 5);
            Assert.AreEqual(1, result);
        }

    }
}
