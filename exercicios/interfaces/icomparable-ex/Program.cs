using System;
using System.Globalization;
using icomparable_ex.Entities;

string s = 
"F:/source/repos/cursoUdemy/exercicios/interfaces/icomparable-ex/text.txt";

try {
    using (StreamReader sr = File.OpenText(s)) {
        List<Employee> list = new List<Employee>();

        while (!sr.EndOfStream) {

            string line = sr.ReadLine();

            if (string.IsNullOrWhiteSpace(line)) {
                continue;
            }
            list.Add(new Employee(line));
        }

        list.Sort();

        foreach (Employee emp in list) {
            Console.WriteLine(emp);
        }
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred: " + e.Message);
}