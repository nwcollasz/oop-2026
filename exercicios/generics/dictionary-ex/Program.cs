using System;
using System.Collections.Generic;
using System.IO;


Console.WriteLine("entre com o caminho do arquivo: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        Dictionary<string, int> d = new Dictionary<string, int>();

        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int votes = int.Parse(line[1]);
            
            if (d.ContainsKey(name))
            {
                d[name] += votes;
            }
            else
            {
                d[name] = votes;
            }
        }

        foreach (var item in d) 
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}

