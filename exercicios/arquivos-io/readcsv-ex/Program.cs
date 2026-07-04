using System;
using System.IO;

string path = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\readcsv-ex\test.csv";
string targetPath = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\readcsv-ex\out\summary.csv";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1]);
            int quantity = int.Parse(fields[2]);
            double total = price * quantity;
                
            using (StreamWriter sw = File.AppendText(targetPath))
            {
                sw.WriteLine($"{name}, {total}");
            }

            
        }
    }

}
catch (IOException e)
{
    Console.WriteLine("An error occurred:");
    Console.WriteLine(e.Message);
}

















