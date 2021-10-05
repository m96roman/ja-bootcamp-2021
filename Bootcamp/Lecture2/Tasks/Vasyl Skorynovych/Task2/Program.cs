using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = AddInfo();

            foreach(var item in books)
            {
                item.PrintBook();
            }
        }

        static Book[] AddInfo()
        {
            Console.WriteLine("Insert the information of books: ");
            Console.WriteLine("-------------------------------------");

            Console.Write("Enter amount books collection: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[amount];

            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Information of book {i+1} : ");
                Console.Write("Input name of the book: ");
                string bookTitle = Console.ReadLine();
                Console.Write("Input the author: ");
                string bookAuthor = Console.ReadLine();

                books[i] = new Book { Title = bookTitle, Author = bookAuthor, Id = i + 1 };
            }

            return books;
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
