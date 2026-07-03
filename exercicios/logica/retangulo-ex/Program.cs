using RetanguloEx;
using System;
using System.Globalization;

namespace RetanguloEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medidas med = new Medidas();

            Console.WriteLine("Entre com a altura e largura do retângulo:");
            Console.Write("Largura: ");
            med.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            med.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + med.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + med.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + med.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
               
        }
    }
}