using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Book, string> bookStudentMap = new Dictionary<Book, string>(new BookComparer());
            bookStudentMap.Add(new Book("CSharp"), "A");
            bookStudentMap.Add(new Book("CSharp"), "B");

        }
    }

    public class Book
    {        
        public Book(string title)
        {
            Title = title;
        }

        public string Title { get; set; }       
    }

    public class BookComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book book1, Book book2)
        {            
            return book1.Title.Equals(book2.Title);
        }      

        public int GetHashCode(Book obj)
        {
            return obj.Title.GetHashCode();
        }
     
    }
}
