using System;

public class College
{
	string name;
	int foundedYear;
	string city;
	public College()
	{
		this.name = "Unknow";
		this.foundedYear = 0;
		this.city = "Unknow";

    }
}
public class Student8
{
	string name;
	DateTime startDate;
	DateTime endDate;
	College college;
	DateTime birthdate;
	public Student8(string name, DateTime startDate, DateTime endDate, College college, DateTime birthdate)
	{
		this.name = name;
		this.startDate = startDate;
		this.endDate = endDate;
		this.college = college;
		this.birthdate = birthdate;
	}
	public bool IsStillStudent()
	{
		if (this.endDate < DateTime.Today)
			return false;
		else
			return true;
	}
	public int GetAge()
	{
		TimeSpan age = DateTime.Today - birthdate;
		return (int)(age.TotalDays / 365);


	}
	public void Print()
	{
		Console.WriteLine($"Name: {name}, Start date: {startDate}, End date: {endDate}, College: {college}, Birth date: {birthdate}");
	}
}
public class Professor
{
	string name;
	College faculity;
	string specialization;
	List<Student8> studentsWhoGiveTheirDegree;
	public Professor(string name, College faculity, string specialization)
	{
		this.name = name;
		this.faculity = faculity;
		this.specialization = specialization;
	}
	public Professor(string name, College faculity, string specialization, List<Student8> studentsWhoGiveTheirDegree)
	{
        this.name = name;
        this.faculity = faculity;
        this.specialization = specialization;
		this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
    }
}

