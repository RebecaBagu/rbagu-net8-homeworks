using System;
public static class Exercise5
{
	public static string ToFullDateString( this DateTime date)
    {
		return date.ToString("MM/dd/yyyy/HH/mm/ss");
	}
}


