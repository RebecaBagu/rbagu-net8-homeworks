//-------Ex1-----

//Read three integer numbers from the user and display the minimum and maximum number.
//----varianta IF
Console.Write("Input the first number: ");
int no1 = int.Parse(Console.ReadLine());
Console.Write("Input the second number: ");
int no2 = int.Parse(Console.ReadLine());
Console.Write("Input the third number: ");
int no3 = int.Parse(Console.ReadLine());
int min = no1;
int max = no1;
if (no2 < min)
{
    min = no2;
}
else if (no3 < min)
{
    min = no3;
}
Console.WriteLine("Minimim number is: " + min);
if (no2 > max)
{
    max = no2;
}
else if (no3 > max)
{
    max = no3;
}
Console.WriteLine("Maximum number is: " + max);

//-----varianta cu functii Max si Min
Console.WriteLine("Maximum number is: " + Math.Max(no1, Math.Max(no2, no3)));
Console.WriteLine("Minimum number is: " + Math.Min(no1, Math.Min(no2, no3)));


//-------Ex2---
//Resolve exercise 1 using ternary operator. (Find information about the ternary operator in the useful resources and online.)
Console.WriteLine("Introduceti 3 numere:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
////(true/false) ? rezultat1 : rezultat2
////false ? rezultat1 : (false/true ? rez1 : rez2 )
min = a < b ? (a < c ? a : (c < b ? c : b)) : (b < c ? b : (c < a ? c : a));
max = a > b ? (a > c ? a : (c > b ? c : b)) : (b > c ? b : (c > a ? c : a));
Console.WriteLine("Max:{0} Min:{1}", max, min);


//-----------Ex3--------
//Read a number from the keyboard which represents a number of days and convert to years (1 year = 356days), months (1month = 30 days), weeks and days as in example. 
//Be careful here because when we have just 1 year, we will display "1 year" and not "1 years". Same for months and days.
Console.Write("Input a number of days: ");
int days = int.Parse(Console.ReadLine());
int years = days / 365;
int Rdays = days % 365;
int months = Rdays / 30;
Rdays = Rdays % 30;
string text = "";
if (years == 1)
{
    text = " 1 year ";
}
else if (years > 1)
{
    text = years + " years ";
}
if (months == 1)
{
    text = text + " 1 month ";
}
else if (months > 1)
{
    text = text + months + " months ";
}
if (Rdays == 1)
{
    text = text + " 1 day ";

}
else if (Rdays > 1)
{
    text = text + Rdays + " days ";
}
Console.WriteLine(text);



//------------Ex4-------
Console.Write("Enter the Physics mark (0-100): ");
int g1 = int.Parse(Console.ReadLine());
Console.Write("Enter the Chemistry mark (0-100): ");
int g2 = int.Parse(Console.ReadLine());
Console.Write("Enter the Biology mark (0-100): ");
int g3 = int.Parse(Console.ReadLine());
Console.Write("Enter the Mathematics mark (0-100): ");
int g4 = int.Parse(Console.ReadLine());
Console.Write("Enter the Computer Science mark (0-100): ");
int g5 = int.Parse(Console.ReadLine());
int per = (g1 + g2 + g3 + g4 + g5) / 5;
string txt = "";
if (per >= 90)
{
    txt = "Grade A ";
}
else if (per >= 80)
{
    txt = "Grade B ";
}
else if (per >= 70)
{
    txt = "Grade C ";
}
else if (per >= 60)
{
    txt = "Grade D ";
}
else if (per >= 40)
{
    txt = "Grade E ";
}
else
{
    txt = "Grade F ";
}
Console.WriteLine("Percentage = " + per + " and the grade is " + txt + ".");



//----------EX5--------
Console.Write("Input a grade(E,V,G,A,F): ");
string grade = Console.ReadLine();
if (grade == "E")
{
    Console.WriteLine("Excellent");
}
else if (grade == "V")
{
    Console.WriteLine("Very Good");
}
else if (grade == "G")
{
    Console.WriteLine("Good");
}
else if (grade == "A")
{
    Console.WriteLine("Average");
}
else if (grade == "F")
{
    Console.WriteLine("Fail");
}



//------------Ex6----------
Console.Write("Input the temperature: ");
int temp =int.Parse( Console.ReadLine());
if (temp <0)
{
    Console.WriteLine("Freezing weather  ");
}
else if (temp >=0 && temp<=10)
{
    Console.WriteLine("Very Cold weather");
}
else if (temp>10 && temp<=20)
{
    Console.WriteLine("Cold weather");
}
else if (temp>20&& temp<=30)
{
    Console.WriteLine("Normal in Temp  ");
}
else if (temp>30 && temp<=40)
{
    Console.WriteLine("Its Hot ");
}
else
{
    Console.WriteLine("Its Very Hot");
}