namespace Practice3.Task11
{
    internal class Program
    {
        class Book
        {
            public string author;
            public string name;
            public Book(string authorName, string bookName)
            {
                author = authorName;
                name = bookName;
            }
        }
        static void BookInfo(Book myBook)
        {
            Console.WriteLine($"Книга {myBook.name}, автор {myBook.author}");
        }
        static void Main(string[] args)
        {
            Book kingBook = new Book("Ушинский К.Д", "Репка");
            BookInfo(kingBook);
        }
    }
}
