using System;
public class Student
{
	string firstName;
	string lastName;
	int studentId;
	double gPA;
	public Student(string firstName, string lastName, int studentId, double gPA)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.studentId = studentId;
		this.gPA = gPA;
	}
	public string GetFullName()
	{
		return this.firstName +" "+ this.lastName;
	}
	public bool HasHonors()
	{
		if (this.gPA >= 3.5)
			return true;
		else
			return false;
	}
}
public class Faculty
{
	string firstName;
	string lastName;
	int employeeId;
	List<string> subjectsTaught;
	public Faculty(string firstName, string lastName, int employeeId, List<string> subjectsTaught)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.employeeId = employeeId;
		this.subjectsTaught = subjectsTaught;
	}
    public string GetFullName()
    {
        return this.firstName + " " + this.lastName;
    }
	public List<string> GetSubjectsTaught()
	{
		return this.subjectsTaught;
	}
}
public  class University
{
	string name;
	List<Student> students;
	List<Faculty> faculties;
	public University(string name)
	{
		this.name = name;
		this.students = new List<Student>();
		this.faculties = new List<Faculty>();
	}
	public void AddStudent(Student student)
	{
		students.Add(student);
	}
	public void AddFaculty(Faculty faculty)
	{
		faculties.Add(faculty);
	}
	public  int GetStudentCount()
	{
		return students.Count();
	}
	public int GetFacultyCount()
	{
		return faculties.Count();
	}
}

