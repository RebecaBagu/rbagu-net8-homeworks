public static class ReadData
{
    public static async Task<string> GetDataFromWebAsync(string url)
	{
		using(var client =new HttpClient())
		{
			var response = await client.GetAsync(url);
			return await response.Content.ReadAsStringAsync();
		}
	}
}


