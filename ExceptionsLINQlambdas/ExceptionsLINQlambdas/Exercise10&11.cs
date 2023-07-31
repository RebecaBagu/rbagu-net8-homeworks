using System;

public class Product
{
	public Product() { }
	public string Name { get; set; }
	public string Category { get; set; }
	public int Price { get; set; }
}


public class Exercise10
{
	public static void  Ex10(List<Product>products)
	{
		var result = products.GroupBy(x => x.Category)
			.Select(x => new { category = x.Key, list = x.OrderBy(x => x.Price).ThenBy(x=>x.Name) });

		foreach(var cat in result)
		{
			foreach(var item in cat.list)
			{
				Console.WriteLine($"{item.Category}, Price: {item.Price}, Name: {item.Name}");
			}
		}
	}
	public static void Ex11(List<Product> products)
	{
		var result = products.GroupBy(x => x.Category)
			.Select(x => new { category = x.Key, avg = x.Average(p => p.Price) })
			.OrderBy(x=>x.avg)
			.Select(x=>x.category).ToList();

		foreach(var cat in result)
		{
			Console.WriteLine(cat);
		}


    }
}


