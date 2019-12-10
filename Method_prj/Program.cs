using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var name = Console.ReadLine();
             var mypet = new VirtualPet(name);
             Console.WriteLine($"name: {mypet.Name}");
             Console.WriteLine($"mood: {mypet.Mood}");
             Console.WriteLine($"energy: {mypet.Energy}");*/

            var name = Console.ReadLine();
            var author = Console.ReadLine();
            var pages = int.Parse(Console.ReadLine());
            var rating = int.Parse(Console.ReadLine());

            var book = new Book(name, author, pages, rating);

            Console.WriteLine($"書籍名： {book.Title}");
            Console.WriteLine($"著者名： {book.Author}");
            Console.WriteLine($"ページ数： {book.Pages}");
            Console.WriteLine($"評価： {book.Rating}");


        }
    }

    /*class VirtualPet
    {
        public string Name { get; set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
    }*/

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        /* public int Rating { get; set; }*/
        int _rating;
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value <= 1)
                {
                    _rating = 1;
                }
                else if (value >= 6) {
                    _rating = 5;
                }
                else
                {
                    _rating = value;
                }
                
            }
        }

        public Book(string name, string author, int pages, int rating)
        {
            Title = name;
            Author = author;
            Pages = pages;
            Rating = rating;
        }
    }
 
}
