using System;
using HotelEx.Entities.Exceptions;
using HotelEx.Entities;

namespace HotelEx.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                Console.WriteLine("Data de entrada (dd/mm/yyyy): ");
                DateTime dataEntrada = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data de saída (dd/mm/yyyy): ");
                DateTime dataSaida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numeroQuarto, dataEntrada, dataSaida);
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

    }
}