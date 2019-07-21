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
        [TestCase("Multiply", typeof(MultplyCalculator))]
        [TestCase("Divide", typeof(DivisionCalculator))]
        [TestCase("AMean", typeof(ArithmeticMean))]
        [TestCase("GMean", typeof(GeometryMean))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
