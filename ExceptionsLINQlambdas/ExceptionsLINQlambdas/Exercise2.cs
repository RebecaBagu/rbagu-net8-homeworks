using System;
public class Exercise2
{
	public static void Ex2()
	{
		List<string> Names = new List<string>();
		Console.Write("lenght of the list: ");
		int len = int.Parse(Console.ReadLine());
		Console.WriteLine($"Input {len} names: ");
		for(int i = 0; i < len; i++)
		{
			string name = Console.ReadLine();
			if (name == "")
			{
				throw new BlankNameException("Invalid name!");
			}
			Names.Add(name);
		}
	}
}
public class BlankNameException: Exception
{
	public BlankNameException(string message) : base(message)
	{ }
}


