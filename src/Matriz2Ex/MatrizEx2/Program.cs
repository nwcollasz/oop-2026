using System;

namespace MatrizEx
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];

            Console.WriteLine($"Digite os elementos da matriz {n}x{m}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatriz digitada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("\n Digite um número da matriz:");
                int x = int.Parse(Console.ReadLine());

            bool numeroPosicao = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        numeroPosicao = true;
                        Console.WriteLine($"Posição de {x}: [{i},{j}]");
                        if (j > 0)
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                        if (j < m - 1)
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                        if (i > 0)
                            Console.WriteLine($"Acima: {matriz[i - 1, j]}");
                        if (i < n - 1)
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                    }
                }
            }

            if (!numeroPosicao)
            {
                Console.WriteLine($"\nNúmero {x} não encontrado na matriz.");
            }
        }
    }
}







