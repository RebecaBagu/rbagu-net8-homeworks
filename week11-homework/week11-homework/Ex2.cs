public static class Ex2
{
	public static void LambdaApp<T>(this List<T> list, Action<T>lambdaFunc)
	{

		foreach(T item in list)
		{
			lambdaFunc(item);
			
		}

		
	}

}

