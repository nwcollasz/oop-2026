using ImpostoEx.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ImpostoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuinte #{i} dados:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else if (tipo == 'j')
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numeroFuncionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS:");
            foreach (Pessoa pessoa in pessoas)
            {
                double imposto = pessoa.CalcularImposto();
                Console.WriteLine($"{pessoa.Nome}: $ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double totalImpostos = pessoas.Sum(p => p.CalcularImposto());
            Console.WriteLine();
            Console.WriteLine($"TOTAL DE IMPOSTOS: $ {totalImpostos.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}