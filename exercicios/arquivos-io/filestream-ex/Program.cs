using System;
using System.IO;

string path = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\filestream-ex\file1.txt";

StreamReader streamReader = null;

try
{
    streamReader = File.OpenText(path);

    while (!streamReader.EndOfStream)
    {
        string line = streamReader.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}
finally
{
    if (streamReader != null)
    {
        streamReader.Close();
    }
}