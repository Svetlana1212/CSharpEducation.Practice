namespace Practice3.Task5
{
    internal class Program
    {
        class Book
        {
            public string author;
            public string name;
            public string year;
            public Book():this(string.Empty,string.Empty,string.Empty) { }
            
            public Book(string bookName):this (string.Empty,bookName,string.Empty) 
            {
                name = bookName;
            }
            public Book(string authorName, string bookName) : this(authorName, bookName, string.Empty)
            {
                author = authorName;
                name = bookName;

            }
            public Book(string authorName, string bookName,string bookYear)
            {
                author = authorName;
                name = bookName;
                year = bookYear;
            }

        }
        static void Main(string[] args)
        {
            Book Book1 = new Book("Сказки");
            Book Book2 = new Book("Пушкин А.С.", "Сказки Пушкина");
            Book Book3 = new Book("Пушин А.С.", "Сказки народов мира", "1997");
            Console.WriteLine(Book1.author);
            Console.WriteLine(Book1.name);
            Console.WriteLine(Book1.year);
            Console.WriteLine(Book2.author);
            Console.WriteLine(Book2.name);
            Console.WriteLine(Book2.year);
            Console.WriteLine(Book3.author);
            Console.WriteLine(Book3.name);
            Console.WriteLine(Book3.year);
        }
    }
}
