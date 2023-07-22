using System;
using System.Collections.Generic;
using OOPAdvanced.ex2;

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

            //Ex 2
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

            Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
            Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
            Console.WriteLine(book.GetPageCount()); // Outputs 180
            Console.WriteLine(book.GetCurrentPage()); // Outputs 1

            book.NextPage();
            Console.WriteLine(book.GetCurrentPage()); // Outputs 2

            book.NextPage();
            book.NextPage();
            book.NextPage();
            Console.WriteLine(book.GetCurrentPage()); // Outputs 5

            book.PreviousPage();
            Console.WriteLine(book.GetCurrentPage()); // Outputs 4

            book.Title = "The Great Gatsby (Revised Edition)";
            Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

            book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
            Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"
        }
    }
}
