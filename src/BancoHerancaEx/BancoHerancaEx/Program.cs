using BancoHeranca.Entities;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        //upcasting
        Account acc1 = bacc;
        Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

        //downcasting
        BusinessAccount acc4 = (BusinessAccount)acc2;
        SavingsAccount acc5 = (SavingsAccount)acc3;

        
    }
}
