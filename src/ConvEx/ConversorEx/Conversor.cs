using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorEx
{
    internal class Conversor
    {
        public static double IOF = 0.06;
        public static double Convert(double dolar, double quantidade)
        {
            double total = (dolar * quantidade);
            return total + (total * IOF);
        }

    }
}
