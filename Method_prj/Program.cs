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
            var name = Console.ReadLine();
            var mood = int.Parse(Console.ReadLine());
            var mypet = new VirtualPet(name, mood);
            mypet.MoodUp();
            Console.WriteLine($"name: {mypet.Name}");
            Console.WriteLine($"mood: {mypet.Mood}");
            Console.WriteLine($"energy: {mypet.Energy}");
            mypet.MoodDown();
            Console.WriteLine($"mood: {mypet.Mood}");



            /*    var name = Console.ReadLine();
                var author = Console.ReadLine();
                var pages = int.Parse(Console.ReadLine());
                var rating = int.Parse(Console.ReadLine());

                var book = new Book(name, author, pages, rating);

                Console.WriteLine($"書籍名： {book.Title}");
                Console.WriteLine($"著者名： {book.Author}");
                Console.WriteLine($"ページ数： {book.Pages}");
                Console.WriteLine($"評価： {book.Rating}");*/

            /* var numbers = new int[] { 2, 3, 4, -1, 1 };
             var num = ArrayUtils.GetMin(numbers);
             Console.WriteLine(num);*/
        }
    }

    class VirtualPet
    {
        public string Name { get; private set; }
        int _mood;
        public int Mood
        {
            get
            {
                return _mood;
            }
            private set
            {
                if (_mood <= 1)
                {
                    _mood = 1;
                }
                else if (_mood >= 10)
                {
                    _mood = 10;
                }
                else
                {
                    _mood = value;
                }
            }
        }
        public int Energy { get; set; }

        public VirtualPet(string name, int mood)
        {
            Name = name;
            Mood = mood;
            Energy = 100;
        }

        public void MoodUp()
        {
            Mood++;
        }

        public void MoodDown()
        {
            Mood--;
        }
    }

    /* class Book
     {
         public string Title { get; set; }
         public string Author { get; set; }
         public int Pages { get; set; }
         *//* public int Rating { get; set; }*//*
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
     }*/

    /* class Sale
     {
         string _productName;
         public string ProductName
         {
             get
             {
                 return _productName;
             }
             set
             {
                 _productName = value;
             }
         }
     }*/

    /* static class ArrayUtils
     {
         public static int Total(int[] numbers)
         {
             var total = 0;
             foreach (var n in numbers)
             {
                 total += n;
             }
             return total;
         }

         public static double Average(int[] numbers)
         {
             var total = Total(numbers);
             return (double)total / numbers.Length;
         }

         public static int GetMin(int[] numbers, bool isPositive = false)
         {
             var nums = new int[] { 1 };
             if (isPositive == true)
             {
                 foreach (var n in numbers)
                 {
                     if (n <= 0)
                     {
                         continue;
                     }
                     else
                     { 
                         if (nums[0] >= n)
                         {
                             nums[0] = n;
                         }
                     }
                 }
                 return nums[0];
             }
             else
             {
                 foreach (var n in numbers)
                 {
                     if (nums[0] >= n)
                     {
                         nums[0] = n;
                     }
                 }
                 return nums[0];
             }

         }
     }*/


}
