using System;
using System.IO;

string path = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\fileblock-ex\text1.txt";

try
{
   
        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    
}
catch (IOException e)
{
    Console.WriteLine("An error occurred:");
    Console.WriteLine(e.Message);
}
