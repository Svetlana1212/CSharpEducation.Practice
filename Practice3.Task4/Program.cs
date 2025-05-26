using System.Collections.Generic;

namespace Practice3.Task4
{
    internal class Program
    {
        class Book
        {
            public string author="Пушкин А.С.";
            public string name=" Сказка о царе Салтане";
            public Book()
            {
                
            }
            public Book(string authorName, string bookName)
            {
                author = authorName;
                name = bookName;
            }
            
        }
        static void Main(string[] args)
        {
            Book book1 = new Book("Лермонтов М.Ю. "," Кавказкий пленник");
            Book book2 = new Book();

            Console.Write(book1.author);
            Console.WriteLine(book1.name);
            Console.Write(book2.author);
            Console.WriteLine(book2.name);
        }
    }
}
