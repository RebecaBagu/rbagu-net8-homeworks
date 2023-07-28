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
		var result= products.GroupBy(x=>x.Category)
			.OrderBy()
	}
}


