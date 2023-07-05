//-------   BUBLE SORT  ----------
int[] Numbers = new int[7] { 2, 5, 3, 8, 4, 1, 9 }; 
for( int i=0; i < (Numbers.Length - 1); i++)
{
   for(int j=i+1; j < (Numbers.Length - 1); j++)
    {
        if (Numbers[i] > Numbers[j])
        {
            int temp = Numbers[i];
            Numbers[i] = Numbers[j];
            Numbers[j] = temp;
        }
    }
}
foreach(int i in Numbers)
{
    Console.Write(i);
}
Console.WriteLine();


//----------    INSERTION SORT -------
for(int i = 0; i < (Numbers.Length); i++)
{
    int j = i-1;
    int key = Numbers[i];
    while( j>=0 && Numbers[j]>key)
    {
        Numbers[j + 1] = Numbers[j];
        j = j - 1;
    }
    Numbers[j + 1] = key;
}
foreach (int i in Numbers)
{
    Console.Write(i);
}
Console.WriteLine();


//--------- BINARY SEARCH -----------
int[] No = new int[9] { 5, 7, 8, 10, 15, 24, 34, 56, 89 };
int target = 10;
int left = 0;
int right = No.Length - 1;
while (left <= right)
{
    int mid = (left + right) / 2;
    if (No[mid] == target)
    {
        Console.WriteLine("The target number is on position: " + mid);
        break;
    }
    else if (No[mid] < target)
    {
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }
}