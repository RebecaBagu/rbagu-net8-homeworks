using System;
public class Student
{
	public Student(string name, string grade)
	{
		Name = name;
		Grade = grade;
	}
	public Student() { }
	public string Name { get; set; }
	public string Grade { get; set; }
}




public class Exercise9
{
	public static void Ex9(List<Student> Students)
	{
		var result = Students.Where(x => x.Grade == "A")
			.OrderByDescending(x => x.Name).ToList();

		foreach(Student student in result)
		{
			Console.WriteLine(student.Name);
		}
	}
}


