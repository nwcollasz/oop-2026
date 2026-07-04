using System.Globalization;
using paypal_ex.Entities;
using paypal_ex.Services;
using System;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: $");
double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contract contract = new Contract(number, date, totalValue);

Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, installments);

Console.WriteLine("Installments:");
foreach (Installments installment in contract.Installments)
{
    Console.WriteLine($"{installment.DueDate:dd/MM/yyyy} - ${installment.Amount:F2}");
}



