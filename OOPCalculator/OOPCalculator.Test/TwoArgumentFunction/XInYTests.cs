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
    public class XInYTests
    {
        
        [Test]
        public void XInReverseYTest()
        {
            XInY calculator = new XInY();
            double result = calculator.Calculator(4, 2);
            Assert.AreEqual(16, result);
        }

    }
}
