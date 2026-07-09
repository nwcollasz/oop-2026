using System;
using System.Globalization;
using System.Collections.Generic;
using restricao_ex.Entities;
using restricao_ex.Services;

 List<Product> list = new List<Product>();

            Console.Write("Número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);

            Console.WriteLine("Produto mais caro:");
            Console.WriteLine(p);