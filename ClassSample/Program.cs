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
            /* var book = new Book
             {
                 Title = "吾輩は猫である",
                 Author = "夏目漱石",
                 Pages = 610,
                 Rating = 4,
             　　Memo = "おもしろいよ"
             };
             book.Print();*/

            /*  var sale = new Sale
              {
                  ProductName = "おにぎり",
                  UnitPrice = 120,
                  Quantity = 4
              };
              var amount = sale.GetAmount();
              Console.WriteLine($"合計金額：{amount}円");*/
            /*
                        var bmicalc = new BmiCalclator();
                        var bmi = bmicalc.GetBmi(170, 70);
                        var type = bmicalc.GetBodyType(bmi);
                        Console.WriteLine("{0:.00}", bmi);
                        Console.WriteLine($"あなたは「{type}」です");*/

            /*   var employee = new Employee
               {
                   Id = 1,
                   FamilyName = "aoyagi",
                   GivenName = "ryota",
                   EmailAddress = "rrr@gmail.com"
               };



               var employee1 = new Employee
               {
                   Id = 1,
                   FamilyName = "aoyagi",
                   GivenName = "misaki",
                   EmailAddress = "rrr@gmail.com"
               };

               Console.WriteLine(employee.GetFullName());
               Console.WriteLine(employee1.GetFullName());*/

            /*var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            var n1 = double.Parse(num1);
            var n2 = double.Parse(num2);
            Console.WriteLine(Math.Min(n1, n2));*/

          /*  var date = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine(date);*/

            var date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date1.ToString("(ddd)"));

        }
    }

    /*class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public string Memo { get; set; }

        public void Print()
        {
            Console.WriteLine($"■{this.Title}");
            Console.WriteLine($" {this.Author} {this.Pages}ページ 評価：{this.Rating} メモ{Memo}");

        }
    }

    class Sale
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public int GetAmount()
        {
            return UnitPrice * Quantity;

        }
    }

    class BmiCalclator
    {
        public double GetBmi(double height, double weight)
        {
            var metersTall = height / 100;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }

        public string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "やせ型";
            }
            else if (bmi < 25)
            {
                type = "普通";
            }
            else if (bmi < 30)
            {
                type = "肥満(1度)";
            }
            else if (bmi < 35)
            {
                type = "肥満(2度)";
            }
            else if (bmi < 40)
            {
                type = "肥満(3度)";
            }
            else
            {
                type = "肥満(4度)";
            }
            return type;
        }

    }

    class Employee
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string EmailAddress { get; set; }

        public string GetFullName()
        {
            return $"{FamilyName} {GivenName}";   
        }
    }*/

   
}
