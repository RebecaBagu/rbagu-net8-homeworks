public class CollectionsCompare<T> : ICompare<ICollection<T>>
{
    public void CompareTwoItems(ICollection<T> firstItem, ICollection<T> secondItem)
    {
        if (firstItem.Count > secondItem.Count)
        {
            Console.WriteLine("The first collection is bigger than the second collection");
        }
        else if (firstItem.Count< secondItem.Count)
        {
            Console.WriteLine("The second collection  is bigger than the first collection");
        }
        else
        {
            Console.WriteLine("The first collection is equal to the second collection");
        }
    }
}


