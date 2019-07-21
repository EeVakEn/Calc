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
    public class XInReverseYTests
    {
        [Test]
        public void XInReverseYTest()
        {
            XInReverseY calculator = new XInReverseY();
            double result = calculator.Calculator(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
