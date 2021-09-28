using System;

namespace BookApp
{
    /// <summary>
    /// Task related to Books.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BookStruct book1 = new BookStruct { bookId = 1, bookName = "BASIC", bookAuthor = "S.TROELSTRA" };
            BookStruct book2 = new BookStruct { bookId = 2, bookName = "C+", bookAuthor = "G.RTRTG" };

            BookStruct.PrintBookInfo(book1);
            BookStruct.PrintBookInfo(book2);
        }

        struct BookStruct
        {
            public int bookId;
            public string bookName;
            public string bookAuthor;

            public BookStruct(int bookId, string bookName, string bookAuthor)
            {
                this.bookId = bookId;
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
            }

            public static void PrintBookInfo(BookStruct book)
            {
                Console.WriteLine($"{book.bookId}: Title = {book.bookName}, Author = {book.bookAuthor}");
            }
        }
    }
}
