using System;
using delegates1_ex.Services;

namespace delegates1_ex
{
    delegate double Operation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            Operation op = new Operation(CalculationService.Sum);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}