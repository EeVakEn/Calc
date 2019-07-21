using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPCalculator.TwoArgumentsFunctions;

namespace OOPCalculator
{
    public class TwoArgumentFactory
    {
       public  static  ITwoArgumentsCalculator CreateCalculator(string Name)

        {
            switch (Name)
            {
                case "Add":
                   return new AdditionCalculator(); break;
                case "Subtraction":
                    return new SubtractionCalculator(); break;
                case "Divide":
                    return new DivisionCalculator(); break;
                case "Multiply":
                    return new MultplyCalculator(); break;
                case "GMean":
                    return new GeometryMean();break;
                case "AMean":
                    return new ArithmeticMean();break;
                case "XInY":
                    return new XInY();break;
                case "XInReverseY":
                    return new XInReverseY();break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
