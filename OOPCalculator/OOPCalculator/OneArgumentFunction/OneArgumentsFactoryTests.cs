using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPCalculator.OneArgumentsFunction;

namespace OOPCalculator.Test.OneArgumentFunction

{
    [TestFixture]
    class OneArgumentsFactoryTests
    {
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Ctg", typeof(Ctan))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("Arccos", typeof(Arccos))]
        [TestCase("Arctan", typeof(Arctan))]
        [TestCase("Arcctg", typeof(Arcctg))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("e^x", typeof(ExpLnX))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalc(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
