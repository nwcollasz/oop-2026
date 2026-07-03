using System;
using System.IO;

string sourcePath = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\fileinfo-ex\fileteste.txt";
string targetPath = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\fileinfo-ex\fileteste2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    Console.WriteLine("Sucesso.");
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}