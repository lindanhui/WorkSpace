using System;

namespace ConsoleApp_struct
{
    class Program
    {


        struct book
        {
            public  string author;
            public string bookname;
            public string bookprice;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is struct test !");

            book b1 = new book();

            b1.author = "lindanhui";
            b1.bookname = "this is book";
            b1.bookprice = "50";

            Console.WriteLine($"this is my book and it is author is {b1.author} and it is price is {b1.bookprice} and it is name is {b1.bookname}");

            Console.ReadKey();


        }
    }
}