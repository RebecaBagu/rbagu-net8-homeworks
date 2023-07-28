using System;
public class Exercise7
{
	public static void Ex7()
	{
		List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

		int result = Numbers.Where(x => x % 2 == 0)
			.Sum(x=>x * x);
		Console.WriteLine(result);
	}
}

