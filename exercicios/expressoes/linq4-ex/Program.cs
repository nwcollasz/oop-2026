using linq4_ex.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

Console.WriteLine("path do arquivo: ");
// F:\source\repos\cursoUdemy\exercicios\expressoes\linq4-ex\teste.txt
string path = Console.ReadLine();

List<Employee> employee = new List<Employee>();

using(StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] campos = sr.ReadLine().Split(',');
        string name = campos[0];
        string email = campos[1];
        double salary = double.Parse(campos[2]);
        employee.Add(new Employee(name, email, salary));
    }
}

Console.WriteLine("Email dos funcionários com salário acima de 2000");
Console.WriteLine();
var showEmail = from e in employee
                where e.Salary > 2000
                select e.Email;
foreach (var email in showEmail)
{
    Console.WriteLine(email);
}

Console.WriteLine("Soma dos salários dos funcionários que começam com a letra M");
Console.WriteLine();
var showSum = employee
              .Where(e => e.Name[0] == 'M')
              .Sum(e => e.Salary);

Console.WriteLine(showSum);
