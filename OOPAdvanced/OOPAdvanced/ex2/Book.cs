using System;
namespace OOPAdvanced.ex2
{
    public class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int currentPage;

        public Book(string title, string author, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.currentPage = 1;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetPageCount()
        {
            return pageCount;
        }

        public int GetCurrentPage()
        {
            return currentPage;
        }

        public void NextPage()
        {
            if (currentPage < pageCount)
                currentPage++;
        }

        public void PreviousPage()
        {
            if (currentPage >= 1)
                currentPage--;
        }

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
    }
}
