using System;
using System.Globalization;
using ContaExceptionEx.Entities;

namespace ContaExceptionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informações da conta");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(id, name, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Informe o valor do saque: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                account.Withdraw(amount);

                Console.WriteLine($"Novo saldo: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        
        }
    }
}