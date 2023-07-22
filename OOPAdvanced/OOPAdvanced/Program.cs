using System;
using System.Collections.Generic;

namespace OOPAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

            myAccount.Deposit(500);
            myAccount.Withdraw(200);

            Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

            List<Transaction> transactions = myAccount.GetTransactionHistory();
            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
            }

            /* Outputs:
            [Timestamp of first transaction]: Deposited $500
            [Timestamp of second transaction]: Withdrew $200
            */

            myAccount.AccountNumber = 654321;
            myAccount.AccountHolder = "Jane Smith";

            Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
            Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith"
        }
    }
}
