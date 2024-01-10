using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    //public delegate string BookDelegate(Book B);
    
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            this.ISBN = iSBN;
            this.Title = title;
            this.Authors = authors;
            this.PublicationDate = publicationDate;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"ISBN : {ISBN} , Book Title : {Title} , Book Authors {Authors} , Publication Date : {PublicationDate} , Book Price : {Price}";
        }


    }


    public class BookFunctions 
        {
            public static string GetTitle (Book B )
        { return B.Title; }

        public static string GetAuthor(Book B)
        {
           return B.Authors[0];
        }
        public static string GetPrice(Book B)
        { return B.Price.ToString(); }

        }


    
    public class LibraryEngine
    {
        /// <summary>
        /// Done user defined delegate to parametrize the BookFunctions Methods.
        /// Then Used the suitable built in delegate (predicate)
        /// </summary>
        /// 
        //public static void ProcessBooks(List<Book> bList, BookDelegate bookdelegate)
        //{
        //    foreach (Book b in bList)
        //       Console.WriteLine(bookdelegate(b));

        //}


        public static void ProcessBooks(List<Book> bList, Func<Book , string> func)
        {
            foreach (Book B in bList)
                Console.WriteLine(func(B));

        }

    }

}
