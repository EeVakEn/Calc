using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator.OneArgumentsFunction
{
    public static class OneArgumentFactory
    {
        public static I1ArgumentCalculator CreateCalc(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "ln":
                    return new Ln();
                case "log10":
                    return new Log10();
                case "Arccos":
                    return new Arccos();
                case "Arcsin":
                    return new Arcsin();
                case "ExpInX":
                    return new ExpLnX();
                case "Tan":
                    return new Tan();
                case "Arctan":
                    return new Arctan();
                case "Ctg":
                    return new Ctan();
                default:
                    throw new Exception("Ошибка");
            }
        }
    }
}
