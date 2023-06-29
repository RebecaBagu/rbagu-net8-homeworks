//----------EX2-----
int[,] biArray = new int[4,3] {
    { 123, 345, 567},
    {12,56,-12 },
    {34,-98,65 },
    {765,543,321}
};
Console.WriteLine(biArray[1, 1] +" , "+ biArray[2, 1]);



//------------EX3------
List<string> names = new List<string>();
names.Add("Maria");
names.Add("Andrei");
names.Add("Andreea");
Console.Write("Please input a name: ");
string name = Console.ReadLine();
if (!names.Contains(name))
{
    names.Add(name);
    Console.WriteLine("The name"+ name + "was added to the list.");
}
else
{
    Console.WriteLine(name + " is in the list. ");
}



//---------EX4-----
Stack<int> numbers = new Stack<int>();
Console.Write("Please input no1= ");
int no1 = int.Parse(Console.ReadLine());
Console.Write("Please input no2= ");
int no2 = int.Parse(Console.ReadLine());
numbers.Push(no1);
numbers.Push(no2);
if (no1 == 30 || no2 == 30 || (no1 + no2) == 30)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("False");
}




//---------------Ex5-----
Queue<int> number = new Queue<int>();
Console.Write("Please input no1= ");
int nr1 = int.Parse(Console.ReadLine());
Console.Write("Please input no2= ");
int nr2 = int.Parse(Console.ReadLine());
Console.Write("Please input no3= ");
int nr3 = int.Parse(Console.ReadLine());
Console.Write("Please input no4= ");
int nr4 = int.Parse(Console.ReadLine());
Console.Write("Please input no5= ");
int nr5 = int.Parse(Console.ReadLine());
number.Enqueue(nr1);
number.Enqueue(nr2);
number.Enqueue(nr3);
number.Enqueue(nr4);
number.Enqueue(nr5);
int topNr = number.Peek();

if (!(topNr > 0 && (topNr % 3 == 0 || topNr % 7 == 0)))
{ 
    number.Dequeue();
    Console.WriteLine(number.Peek());
}


