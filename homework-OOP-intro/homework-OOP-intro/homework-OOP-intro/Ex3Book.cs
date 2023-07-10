using System;

public class Book
{
    string title;
    string author;
    int year;
    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }
    public string GetTitle()
    {
        return this.title;
    }
    public string GetAuthor()
    {
        return this.author;
    }
    public int GetYear()
    {
        return this.year;
    }
    public void SetTitle(string NewTitle)
    {
        this.title = NewTitle;
    }
    public void SetAuthor(string NewAuthor)
    {
        this.author = NewAuthor;
    }
    public void SetYear(int NewYear)
    {
        this.year = NewYear;
    }
}

