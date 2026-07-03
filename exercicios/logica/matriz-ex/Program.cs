
namespace MatrizEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tamanho da matriz:");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz digitada:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine("\nQuantidade de números negativos:)");

            int countNegativos = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        countNegativos++;
                    }
                }
            }
        }
    }
}