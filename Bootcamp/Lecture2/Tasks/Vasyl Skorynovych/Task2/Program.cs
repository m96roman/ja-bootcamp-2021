using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1;
            Book book2;

            Console.WriteLine("Insert the information of two books: ");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Information of book 1 : ");
            Console.Write("Input name of the book: ");
            book1.Id = 1;
            book1.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book1.Author = Console.ReadLine();

            Console.WriteLine("Information of book 2 : ");
            Console.Write("Input name of the book: ");
            book2.Id = 2;
            book2.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book2.Author = Console.ReadLine();

            book1.PrintBook();
            book2.PrintBook();

        }

        struct Book
        {
            public int Id;
            public string Title;
            public string Author;

            public void PrintBook()
            {
                Console.WriteLine($"{Id}: Title = {Title}, Author = {Author}");
            }
        }
    }
}
