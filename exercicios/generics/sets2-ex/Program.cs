using System;
using System.IO;
using System.Collections.Generic;
using sets2_ex.Entities;


HashSet<LogRecord> set = new HashSet<LogRecord>();

Console.WriteLine("entre com o caminho do arquivo: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord{Username = name, Instant = instant});
        }

        Console.WriteLine("total de users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}
