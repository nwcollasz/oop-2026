using System;
using System.Collections.Generic;
using System.Globalization;
namespace BancoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Digite a senha da conta: ");
            int senha = int.Parse(Console.ReadLine());

            Console.Write("Haverá deposito inicial? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                Console.WriteLine();
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titular, senha, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(titular, senha);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
