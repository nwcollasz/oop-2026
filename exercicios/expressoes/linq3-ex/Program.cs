using linq3_ex.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

Console.WriteLine("path do arquivo: ");
// F:\source\repos\cursoUdemy\exercicios\expressoes\linq3-ex\teste.txt
string p = Console.ReadLine();

List<Product> list = new List<Product>();

using(StreamReader sr = File.OpenText(p))
{
    while (!sr.EndOfStream)
    {
        string[] campos = sr.ReadLine().Split(',');
        string nome = campos[0];
        double preco = double.Parse(campos[1]);
        list.Add(new Product(nome, preco));
    }
}

var avg = list.Select(pr => pr.Price)
              .DefaultIfEmpty(0.0).Average();
Console.WriteLine("preço médio: " + avg.ToString("F2"));

var nomes = list.Where(p => p.Price < avg)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);
foreach(string nome in nomes)
{
    Console.WriteLine(nome);
}