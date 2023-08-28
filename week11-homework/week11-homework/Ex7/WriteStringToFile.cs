public class Ex7
{
	public async Task WriteStringToFile(string strings, string fileName)
	{
		using(StreamWriter writer=new StreamWriter(fileName))
		{
			await writer.WriteAsync(strings);
		}
	}
}

