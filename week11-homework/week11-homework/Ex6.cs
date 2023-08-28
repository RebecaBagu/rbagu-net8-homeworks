public class Ex6
{
	public async Task<string> HttpGetRequest(string url)
	{
        using var client = new HttpClient();
        {
            var result = await client.GetStringAsync(url);
            return  result;
        }
    }
}

