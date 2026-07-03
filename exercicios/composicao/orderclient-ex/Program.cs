using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace OrderClientEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do cliente: ");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Dados do pedido: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos items para esse pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do item #{i}:");
                Console.Write("Produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("PEDIDOS:");
            Console.WriteLine(order);
           
        }
     }
}