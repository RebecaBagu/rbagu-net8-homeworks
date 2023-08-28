public class StringCompare : ICompare<string>
{
    public void CompareTwoItems(string firstItem, string secondItem)
    {
        if (firstItem.Length > secondItem.Length)
        {
            Console.WriteLine($"{firstItem} is bigger than {secondItem}");
        }
        else if (firstItem.Length < secondItem.Length)
        {
            Console.WriteLine($"{secondItem} is bigger than {firstItem}");
        }
        else
        {
            Console.WriteLine($"{firstItem} is equal {secondItem}");
        }
    }
}


