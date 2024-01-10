using System.Diagnostics;

namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book01", "The First Book", new string[1] { "Mazen Ellithy" }, new DateTime(2009, 1, 16), 32.5M);

            Book book2 = new Book("Book02", "The Second Book", new string[1] { "Hamada" }, new DateTime(2010, 2, 11), 35.5M);

            Book book3 = new Book("Book03", "The Third Book", new string[1] { "Mohamed Lotfy" }, new DateTime(2020, 10, 30), 40.5M);

            List<Book> books= new List<Book>()
            {
                book1,
                book2,
                book3
            };



            // GetISBN as Anonymous Method
            Func<Book, string> func = delegate (Book book) { return book.ISBN; };
            Console.WriteLine($"ISBN for Book1 is : {func(book1)} ");

            // Get Publication date as anonymous method with Lambda Expression
            Func<Book, DateTime> func2 = (Book book) => book.PublicationDate;
            Console.WriteLine($"Publication Date for Book 1 is : {func2(book1)}");

            Func<Book, string> func3 = delegate (Book book) { return BookFunctions.GetTitle(book); };
            Func<Book,string> func4 = delegate (Book book) { return BookFunctions.GetPrice(book); };
            Func<Book,string> func5 = delegate (Book book) { return BookFunctions.GetAuthor(book); };
            LibraryEngine.ProcessBooks(books, func3);
            LibraryEngine.ProcessBooks(books, func4);
            LibraryEngine.ProcessBooks(books, func5);

        }
    }
}