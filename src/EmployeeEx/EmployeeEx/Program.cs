using System;
using System.Collections.Generic;

namespace EmployeeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":\n");
                int id;
                bool idExists;

                do
                {
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());

                    idExists = list.Exists(x => x.Id == id);

                    if (idExists)
                    {
                        Console.WriteLine("Id already taken. Try again.");
                    }
                }
                while (idExists);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();
                list.Add(new Employee(id, name, salary));
            }
            
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }

    }
}