public class MyQueue<T>
{
	public MyQueue() { }
	private List<T> queue = new List<T>();

	public void Enqueue(T item)
	{
		queue.Add(item);
	}

	public T Dequeue()
	{
        if (queue.Count > 0)
        {
			T firstValue = queue[0];

            queue.Remove(queue[0]);
			return firstValue;
        }
        else
        {
			throw new Exception("Queue is empty");
        }
    }
       
       

	public T Peek()
	{
		return queue[queue.Count - 1];
	}

	public bool IsEmpty()
	{
		if (queue.Count == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}


