List<int> Numbers = new List<int> { 1,2,3,4,5 };

//-----EX1

foreach(int no in Numbers.Reverse1())
{
    Console.WriteLine(no);
}

Console.WriteLine();

//-------EX2

Numbers.LambdaApp(x => { Console.WriteLine(x * x); }) ;

Console.WriteLine();

//---------EX3

MyQueue<int> newQueue = new MyQueue<int>();
newQueue.Enqueue(10);
newQueue.Enqueue(5);
newQueue.Enqueue(3);

Console.WriteLine(newQueue.Peek());
newQueue.Dequeue();
Console.WriteLine(newQueue.IsEmpty());
Console.WriteLine(newQueue.Dequeue());
newQueue.Dequeue();
Console.WriteLine(newQueue.IsEmpty());

Console.WriteLine();

//--------EX4
//await Ex4.Ex4Run();

Console.WriteLine();

//---------EX5
string firstName = "Rebeca";
string lastName = "Bagu";

List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
List<int> numbers2 = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 8, 9 };

new StringCompare().CompareTwoItems(firstName, lastName);
new CollectionsCompare<int>().CompareTwoItems(numbers1, numbers2);

Console.WriteLine();

//-------EX6
//Console.WriteLine(await new Ex6().HttpGetRequest("http://webcode.me"));

Console.WriteLine();

//-------EX7

await new Ex7().WriteStringToFile("Ne plac vacantele", "/Users/rebeca/Desktop/rbagu-net8-homeworks/week11-homework/week11-homework/Ex7/Text1.txt");