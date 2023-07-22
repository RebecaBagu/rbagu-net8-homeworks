using System;
namespace OOPAdvanced.ex5
{
    public class BankAccount
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public string AccountHolder { get { return accountHolder; } set { accountHolder = value; } }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("Balance cannot be negative.");
                }
            }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            Bank.NumAccounts++;
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public double GetInterest()
        {
            return Bank.CalculateInterest(Balance);
        }
    }
}
