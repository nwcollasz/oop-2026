using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace BancoEx
{
    internal class ContaBancaria
    {
        public int Senha {get; private set;}
        public string Titular {get; set;}
        public double Saldo {get; private set;}
        
        public ContaBancaria(string titular, int senha)
        {
            Titular = titular;
            Senha = senha;
        }

        public ContaBancaria(string titular, int senha, double deposito) : this(titular, senha)
        {
            Depositar(deposito);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            while (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                Console.WriteLine("Digite um valor válido para o saque:");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Saldo -= valor + 5;
           
            if (Saldo < 0)
            {
                Console.Write("Atenção: Sua conta está com saldo negativo.");
            }
        }
        
        public override string ToString()
        {
            return $"Senha: {Senha}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
