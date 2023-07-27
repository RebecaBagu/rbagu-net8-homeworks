using System;
public class Exercise3
{
	public static void Ex3()
	{
        List<int> Numbers = new List<int>();
        Console.Write("lenght of the list: ");
        int len = int.Parse(Console.ReadLine());

        if (len == 0)
        {
            throw new DivideByZeroException("The list is empty.");
        }

        Console.WriteLine($"Input {len} numbers: ");
        for (int i = 0; i < len; i++)
        {
            
            if(int.TryParse(Console.ReadLine(), out int no))
            {
                Numbers.Add(no);
            }
            else
            {
                throw new FormatException("The input is not a number.");
            }
        }

        int sum = Numbers.Sum();
        Console.WriteLine("Sum: "+ sum);
       
        double avg = Numbers.Average();
        Console.WriteLine("Average: "+ avg);

        if (sum> 2147483647)
        {
            throw new OverflowException("The sum is to large.");
        }

        if (len == 0)
        {
            throw new DivideByZeroException("The list is empty.");
        }
    }
}

public class FormatException : Exception
{
    public FormatException(string message) : base(message)
    { }
}

public class OverflowException : Exception
{
    public OverflowException(string message) : base(message)
    { }
}

public class DivideByZeroException : Exception
{
    public DivideByZeroException(string message) : base(message)
    { }
}

