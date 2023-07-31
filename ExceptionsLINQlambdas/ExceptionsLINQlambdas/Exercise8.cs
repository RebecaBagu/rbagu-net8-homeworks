using System;
public class Exercise8
{
	public static void Ex8()
	{
        List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        List<int> Squares = Numbers.Select(x => x * x).ToList();

        foreach(int item in Squares)
        {
            Console.WriteLine(item);
        }
    }
}


