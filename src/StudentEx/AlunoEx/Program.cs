using AlunoEx;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas not = new Notas();

            Console.Write("Nome do aluno: ");
            not.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            not.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            not.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            not.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + not.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (not.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + not.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
