using System;
using System.Collections.Generic;
using System.Text;

namespace NestorPylatLecture2
{
     struct Book
    {
        public int index;
        public string name;
        public string author;
    } 
    class _3_Task
    {

        public static void doTask3()
        {
            Book book1;
            Book book2;
            Book book3;

            Console.WriteLine($@"Information of book 1:
Input name of the book1:");
            book1.name = Console.ReadLine();

            Console.WriteLine($@"Input the author:");
            book1.author = Console.ReadLine();

            Console.WriteLine($@"Information of book 2:
Input name of the book2:");
            book2.name = Console.ReadLine();

            Console.WriteLine($@"Input the author:");
            book2.author = Console.ReadLine();

            Console.WriteLine($@"1: Title = {book1.name},  Author = {book1.author}");
            Console.WriteLine($@"2: Title = {book2.name},  Author = {book2.author}");

        }
    }
}
