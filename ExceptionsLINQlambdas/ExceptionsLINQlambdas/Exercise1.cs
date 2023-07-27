using System;

public class Exercise1
{
	public static void Ex1()
	{
        DateTime today = DateTime.Today;
		Console.WriteLine("Input a date: ");
		DateTime date = DateTime.Parse(Console.ReadLine());
		if (date < today)
		{
			throw new InvalidDateException("The input date is in the past.");
		}
    }

   
	
}
public class InvalidDateException : Exception
{
	public InvalidDateException(string message) : base(message) { }
}


