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
    class SinTests
    {
        [Test]
        public void SinusTest()
        {

            Sin calculator = new Sin();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
     
    }
}
