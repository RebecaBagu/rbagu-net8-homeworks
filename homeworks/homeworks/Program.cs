//Ex.1
Console.Write("Introduceti a = ");
float a = float.Parse(Console.ReadLine());
Console.Write("Introduceti b = ");
float b = float.Parse(Console.ReadLine());
Console.WriteLine("Addition = {0}", a+b);
Console.WriteLine("Subtraction = {0}", a-b);
Console.WriteLine("Division = {0}", a/b);
Console.WriteLine("Multiplication = {0}", a*b);
Console.WriteLine("Modulo = {0}", a%b);

//Ex.2
a++;
b--;
float sum = a + b;
float dif = a - b;
Console.WriteLine("a = {0}, b = {1} , sum = {2}, dif = {3}", a, b, sum, dif);
a -= 2;
b += 4;
float div = a / b;
float mul = a * b;
float modulo = a % b;
Console.WriteLine("a = {0}, b = {1} , div = {2}, mul = {3}, modulo = {4}", a, b, div, mul, modulo);

//Ex.3
bool isAequalToB = a == b;
bool isAnotequalToB = a != b;
bool ANDoperator = a == b && a != b;
bool ORoperator = a == b || a != b;
Console.WriteLine("a = b? {0} , a != b? {1}", isAequalToB, isAnotequalToB);