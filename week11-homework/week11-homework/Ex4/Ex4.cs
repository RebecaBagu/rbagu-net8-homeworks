public static class Ex4
{
	public static async Task  Ex4Run()
	{
		Task<string> firstURL= ReadData.GetDataFromWebAsync("https://www.youtube.com/");
		Task<string> secondURL = ReadData.GetDataFromWebAsync("https://www.google.com/");
		Task<string> thirdURL = ReadData.GetDataFromWebAsync("https://www.facebook.com/");

		Task<string> fastestTask = await Task.WhenAny(firstURL, secondURL, thirdURL);
		Console.WriteLine(await fastestTask);
	}
}

