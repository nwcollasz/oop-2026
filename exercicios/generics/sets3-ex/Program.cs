using System.Collections.Generic;
using System;

HashSet<int> a = new HashSet<int>();
HashSet<int> b = new HashSet<int>();
HashSet<int> c = new HashSet<int>();

Console.Write("quantos estudantes no curso A? (insira o numero da matricula): ");
int number = int.Parse(Console.ReadLine());
for(int i = 0; i < number; i++)
{
    int count = int.Parse(Console.ReadLine());
    a.Add(count);
}

Console.Write("quantos estudantes no curso B? (insira o numero da matricula): ");
number = int.Parse(Console.ReadLine());
for(int i = 0; i < number; i++)
{
    int count = int.Parse(Console.ReadLine());
    b.Add(count);
}

Console.Write("quantos estudantes no curso C? (insira o numero da matricula): ");
number = int.Parse(Console.ReadLine());
for(int i = 0; i < number; i++)
{
    int count = int.Parse(Console.ReadLine());
    c.Add(count);
}

HashSet<int> x = new HashSet<int>(a);
            x.UnionWith(b);
            x.UnionWith(c);
            Console.WriteLine("total de estudantes: " + x.Count);