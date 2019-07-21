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
    class CosTests
    {
        [Test]
        public void CosinusTest()
        {

            Cos calculator = new Cos();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
