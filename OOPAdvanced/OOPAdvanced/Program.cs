using System;
using System.Collections.Generic;
using OOPAdvanced.ex2;
using OOPAdvanced.ex3;
using OOPAdvanced.ex4;
using OOPAdvanced.ex5;
using OOPAdvanced.ex6;
using OOPAdvanced.ex7;

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
            ex3.Rectangle rectangle1 = new ex3.Rectangle("Green", 6, 8);
            ex3.Rectangle rectangle2 = new ex3.Rectangle("Yellow", 10, 12);

            ex3.Circle circle1 = new ex3.Circle("Purple", 3);
            ex3.Circle circle2 = new ex3.Circle("Orange", 5);

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

            //Ex 4
            Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
            Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

            Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
            Console.WriteLine(developer.CalculateBonus()); // Outputs 6000
            
            Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT, Email: john.d

            //Ex 5
            ex5.BankAccount account1 = new ex5.BankAccount("123456", "John Doe", 1000);
            ex5.BankAccount account2 = new ex5.BankAccount("654321", "Jane Smith", 2000);

            account1.Deposit(500);
            account2.Withdraw(1000);

            Console.WriteLine(account1.Balance); // Outputs 1500
            Console.WriteLine(account2.Balance); // Outputs 1000
            
            Console.WriteLine(account1.GetInterest()); // Outputs 15
            Console.WriteLine(account2.GetInterest()); // Outputs 20
            
            Console.WriteLine(Bank.NumAccounts); // Outputs 2
            //Ex 6
            IShape circle = new ex6.Circle(5);
            IShape rectangle = new ex6.Rectangle(10, 5);

            Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
            Console.WriteLine(rectangle.CalculateArea()); // Outputs 50
            
            Console.WriteLine(circle.CalculateArea(MeasurementUnit.Feet)); // Outputs "Area: 78.5398163397448 square feet"
            Console.WriteLine(rectangle.CalculateArea(MeasurementUnit.Feet)); // Outputs "Area: 50 square meters"

            IColor circleColor = (IColor)circle;
            circleColor.Color = "Red";

            IColor rectangleColor = (IColor)rectangle;
            rectangleColor.Color = "Blue";

            Console.WriteLine(circleColor.Color); // Outputs "Red"
            Console.WriteLine(rectangleColor.Color); // Outputs "Blue"

            //Ex 7
            Hotel hotel = new Hotel(1000000, 250000);
            Floor floor1 = new Floor(1);
            Room room1 = new StandardRoom(1, 1);
            floor1.AddRoom(room1);
            Room room2 = new StandardRoom(1, 2);
            floor1.AddRoom(room2);
            Room room3 = new PenthouseRoom(2, 1);
            floor1.AddRoom(room3);
            Floor floor2 = new Floor(2);
            Room room4 = new PenthouseRoom(1, 1);
            floor2.AddRoom(room4);
            Room room5 = new PenthouseRoom(2, 1);
            floor2.AddRoom(room5);
            hotel.AddFloor(floor1);
            hotel.AddFloor(floor2);

            Console.WriteLine(hotel.GetArea(AreaMeasurementUnit.SquaredMeters));
            Console.WriteLine(room1.GetArea(AreaMeasurementUnit.SquaredMeters));
        }
    }
}
