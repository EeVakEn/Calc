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
    class TwoArgumentsFactoryTests
    {
        [TestCase("Add", typeof(AdditionCalculator))]
        [TestCase("Subtraction", typeof(SubtractionCalculator))]
        [TestCase("Multiplication", typeof(MultplyCalculator))]
        [TestCase("Divide", typeof(DivisionCalculator))]
        [TestCase("AMean", typeof(ArithmeticMean))]
        [TestCase("GMean", typeof(GeometryMean))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalc(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
