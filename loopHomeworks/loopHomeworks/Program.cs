//------ex1
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine("the total of all the values that are even numbers is: " + sum);


//-----ex2
//-2xFor

int[] numbers1 = new int[5] { 1, 2, 3, 3, 4 };

for (int i = 0; i < numbers1.Length - 1; i++)
{
    for (int j = i + 1; j < numbers1.Length; j++)
    {
        if (numbers1[i] == numbers1[j])
        {
            Console.WriteLine("The duplicates is: " + numbers[i]);
        }
    }
}

//---Dictionary

Dictionary<int, int> dicNumbers = new Dictionary<int, int>();
foreach (int nr in numbers1)
{
    if (!dicNumbers.ContainsKey(nr))
    {
        dicNumbers.Add(nr, 1);
    }
    else if (dicNumbers.ContainsKey(nr))
    {
        Console.WriteLine("The duplicates is: " + nr);
    }
}

//----Array

int[] Array = new int[5];
for (int i = 0; i < numbers1.Length; i++)
{
    if (Array[numbers1[i]] == 0)
    {
        Array[numbers1[i]] = 1;
    }
    else
    {
        Console.WriteLine("The duplicates is: " + numbers1[i]);
    }
}


//------ex3
List<string> letters = new List<string> { "a", "b", "b", "c", "c", "d" };
for (int i = 0; i < letters.Count; i++)
{
    for (int j = i + 1; j < letters.Count; j++)
    {
        if (letters[i] == letters[j])
        {
            letters.Remove(letters[j]);
        }
    }
}
foreach (string letter in letters)
{
    Console.Write(letter);
}
Console.WriteLine();

//---ex4
int[] numbers2 = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
Dictionary<int, int> frequency = new Dictionary<int, int>();
foreach(int no in numbers2)
{
    if (!frequency.ContainsKey(no))
    {
        frequency.Add(no, 1);
    }
    else
    {
        frequency[no] = frequency[no] + 1;
    }
}
foreach(KeyValuePair<int,int> kvp in frequency)
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}


//----Ex5

Console.Write("Input the lenght of the array: ");
int lenght = int.Parse(Console.ReadLine());
int[] numbers3 = new int[lenght] ;
int[] numbersOdd = new int[lenght] ;
int[] numbersEven = new int[lenght] ;
int countE = 0;
int countO = 0;
for (int i=0;i<=lenght-1; i++)
{
    Console.Write("Input a number: ");
    int no = int.Parse(Console.ReadLine());
    numbers3[i] = no;
}
foreach(int no in numbers3)
{
   if (no % 2 == 0)
    {
        numbersEven[countE] = no;
        countE = +1;
    }
    else
    {
        numbersOdd[countO] = no;
        countO = +1;
    }
}
foreach(int n in numbersEven)
{
    Console.WriteLine(n);
}


//------Ex6

Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());
List<int> numere = new List<int>();
if (a < b)
{
    for(int i = a; i <= b; i++)
    {
        numere.Add(i);
    }
}
else
{
    for (int i = b; i <= a; i++)
    {
        numere.Add(i);
    }
}
foreach(int no in numere)
{
    if(no % 3 == 0)
    {
        Console.WriteLine(no);
    }
}


//----ex7
List<int> listOfNumbers = new List<int>();
for(int i =123; i<=234; i++)
{
    listOfNumbers.Add(i);
}
foreach(int nr in listOfNumbers)
{
    if(nr % 3 == 0 && nr % 5 == 0)
    {
        Console.WriteLine(nr + " FizzBuzz");
    }
    else if(nr % 3 == 0)
    {
        Console.WriteLine(nr + " Fizz");

    }
    else if (nr % 5 == 0)
    {
        Console.WriteLine(nr + " Buzz");
    }
    else
    {
        Console.WriteLine(nr);
    }
   
}


//-----ex8

List<string> Names = new List<string>();
for(int i=1; i <= 10; i++)
{
    Console.Write("Input a name: ");
    string name = Console.ReadLine();
    Names.Add(name);
}
int ind = 0;
while(ind < 6)
{
    Console.WriteLine(Names[ind]);
    ind++;
}



//--------ex9
int number1;
do
{
    Console.Write("Input a number: ");
    number1 = int.Parse(Console.ReadLine());
}
while (number1 != 0);



//---------ex10
int x = -1;
do
{
    Console.WriteLine(x);
    if (x % 21 == 0)
    {
        break;
    }
    x--;
} while (x >= -123);


//------ex11
int count = 0;
List<string> Names1 = new List<string>();
while(count<10)
{
    Console.Write("Input a name: ");
    string name = Console.ReadLine();
    Names1.Add(name);
   
    count++;
} 
foreach(string name in Names1)
{
    if (name[0] == 'a' || name[0]=='A'|| name[0] == 'b' || name[0] == 'B')
    {
        continue;
    }
    Console.WriteLine(name);
}
char w=Names1[0].ToArray()[0];