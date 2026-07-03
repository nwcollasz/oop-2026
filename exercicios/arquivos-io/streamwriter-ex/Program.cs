using System;
using System.IO;

string sourcePath = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\streamwriter-ex\fileteste.txt";
string targetPath = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\streamwriter-ex\fileteste2.txt";

try
{
   string[] lines = File.ReadAllLines(sourcePath);
   using (StreamWriter sw = File.AppendText(targetPath))
   {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
   }
   console.WriteLine("Sucesso.");
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}