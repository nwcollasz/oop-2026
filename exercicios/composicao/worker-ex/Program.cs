using System.Globalization;
using WorkerEx.Entities;
using WorkerEx.Entities.Enums;

Console.Write("Enter department's name: ");
string dtName = Console.ReadLine();

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Departaments departament = new Departaments(dtName);
Worker worker = new Worker(name, level, baseSalary, departament);

Console.WriteLine("--------------------------------------------");
Console.WriteLine("How many contracts to this worker? ");
int c = int.Parse(Console.ReadLine());

for (int i = 0; i < c; i++)
{
    Console.WriteLine($"Enter contract #{i + 1} data:");
    Console.Write("Date (dd/MM/yyyy): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);

}

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Enter month and year to calculate income (MM/yyyy): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Departament.Name}");
Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
