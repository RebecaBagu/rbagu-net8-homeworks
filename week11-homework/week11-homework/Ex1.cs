public static class Ex1
{
    public static List<T> Reverse1<T>(this List<T> list)
    {
        List<T> reversedList = new List<T>();
        for(int i=0; i< list.Count; i++)
        {
            T lastItem = list[list.Count - 1-i];
            reversedList.Add(lastItem);
        }
        return reversedList;
    }
}

