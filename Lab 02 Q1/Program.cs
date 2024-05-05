using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Book myBook = new Book();

            
            myBook.Title = "Harry Potter";
            myBook.Author = "J.K.Rowling";

            
            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Book Author: " + myBook.Author);

            Console.ReadLine(); 
        }
    }
}


      

