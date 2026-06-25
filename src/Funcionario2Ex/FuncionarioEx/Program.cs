using FuncionarioEx;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario sal = new Salario();

            Console.Write("Nome: ");
            sal.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            sal.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            sal.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + sal.Nome + ". Salário líquido: " + sal.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            sal.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + sal.Nome + ". Salário líquido: " + sal.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
