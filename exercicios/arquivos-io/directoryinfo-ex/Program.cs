using System;
using System.IO;
using System.Collections.Generic;

string path = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\directoryinfo-ex\myfolder";

try
{
    var directories = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("DIRETÓRIOS:");
    Console.WriteLine();
    foreach (string dir in directories)
    {
        Console.WriteLine(dir);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("ARQUIVOS:");
    Console.WriteLine();
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + @"\newfolder");
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}