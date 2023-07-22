﻿using System;
using System.Collections.Generic;
using OOPAdvanced.ex2;
using OOPAdvanced.ex3;

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

            //Ex 3
            Rectangle rectangle1 = new Rectangle("Green", 6, 8);
            Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

            Circle circle1 = new Circle("Purple", 3);
            Circle circle2 = new Circle("Orange", 5);

            List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

            foreach (Shape shape in shapes)
            {
                shape.CalculateArea();
            }

            shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Color + ": " + shape.Area);
            }

            /* Outputs:
            Yellow: 120
            Purple: 28.2743338823081
            Orange: 78.5398163397448
            Green: 48
            */

            double totalPerimeter = 0;
            foreach (Shape shape in shapes)
            {
                totalPerimeter += shape.GetPerimeter();
            }

            Console.WriteLine("Total perimeter: " + totalPerimeter + " inches"); // Outputs "Total perimeter: 122,26548245744 inches"
        }
    }
}
