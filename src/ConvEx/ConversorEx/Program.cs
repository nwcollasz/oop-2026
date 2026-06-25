using ConversorEx;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Cotação do dólar:");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double valor = Conversor.Convert(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + Conversor.Convert(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}