using System;
using vetorsimples_ex.Services;

PrintService<int> p = new PrintService<int>();

Console.Write("Quantos valores?: ");
int v = int.Parse(Console.ReadLine());

for (int i = 0; i < v; i++)
{
    int n = int.Parse(Console.ReadLine());
    p.AddCount(n);
}

p.Print();
Console.WriteLine();

Console.WriteLine($"First: {p.First()}");
