using ContaExceptionEx.Entities.Exceptions;

namespace ContaExceptionEx.Entities
{
    public class Account
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawalLimit { get; private set; }

        public Account(
            int id, 
            string name, 
            double balance, 
            double withdrawalLimit)
        {
            Id = id;
            Name = name;
            Balance = balance;
            WithdrawalLimit = withdrawalLimit;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawalLimit)
            {
                throw new InvalidOperationException("Seu saque excede o limite.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Balance -= amount;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}