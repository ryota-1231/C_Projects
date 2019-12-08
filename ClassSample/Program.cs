using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Title = "吾輩は猫である";
            book.Author = "夏目漱石";
            book.Pages = 610;
            book.Rating = 4;

            var title = book.Title;
            var author = book.Author;
            var pages = book.Pages;
            var rating = book.Rating;
            Console.WriteLine($"書籍名　{title}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
    }
}
