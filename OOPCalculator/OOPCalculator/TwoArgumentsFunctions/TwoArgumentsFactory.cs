using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    class TwoArgumentsFactory
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
