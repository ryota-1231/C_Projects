using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            関係演算子*/
            /* var line = Console.ReadLine();
             var num = int.Parse(line);
             if (num >= 10)
             {
                 Console.WriteLine("num >= 10が成り立ちました");
                 Console.WriteLine($"numの値は{num}です");
             }*/

            /*           論理演算子*/

            /*   var month = 6;
               if (month >= 1 && month <= 12)
               {
                   Console.WriteLine("1以上、12以下の数値です");
               }
   */
            /* var num = Console.ReadLine();
             var count = int.Parse(num);
             if (count%3 == 0 && count%5 == 0)
             {
                 Console.WriteLine("FizzBuzz");
             } else if (count%3 == 0)
             {
                 Console.WriteLine("Fizz");
             } else if (count%5 == 0)
             {                Console.WriteLine("Buzz");
             }
             else
             {
                 Console.WriteLine(count);
             }*/


            /*        switch文*/

            /* Console.WriteLine("ご希望の時間帯の番号を選択してください");
             Console.WriteLine("１：10時から12時");
             Console.WriteLine("２：13時から15時");
             Console.WriteLine("３：15時から18時");
             var line = Console.ReadLine();
             var value = int.Parse(line);

             switch (value)
             {
                 case 1:
                     Console.WriteLine("10時から12時ご希望ですね");
                     break;
                 case 2:
                     Console.WriteLine("12時から15時ご希望ですね");
                     break;
                 case 3:
                     Console.WriteLine("15時から18時ご希望ですね");
                     break;
                 default:
                     Console.WriteLine("入力した値に誤りがあります");
                     break;
             }*/

            /*   var value = Console.ReadLine();
               *//*   if (value == "")
                  {
                      Console.WriteLine("空文字です");
                  }*//*

               var num = int.Parse(value);
               if (num == 0)
               {
                   Console.WriteLine("値は0です");
               } else if (num > 0) {
                   Console.WriteLine("値は正の数字です");
               } else
               {
                   Console.WriteLine("値は負の数字です");
               }*/

            /*      繰り返し処理*/

            /*  var year = 1;
              while (year <= 64)
              {
                  var westernYear = year + 1925;
                  Console.WriteLine($"昭和{year}年　西暦{westernYear}年");
                  year++;
              }*/

            /*  for (var year = 1; year <= 64; year++)
              {
                  var westernYear = year + 1925;
                  Console.WriteLine($"昭和{year}年　西暦{westernYear}年");
              }*/

            /*  var line = "";
              var num = 0;
              do
              {
                  Console.WriteLine("負の整数を入力してください");
                  line = Console.ReadLine();
                  if (line != "")
                  {
                      num = int.Parse(line) ;

                  }  
              } while (num >= 0);
              Console.WriteLine(num);*/
            /*
                        var content = "";
                        for (var n = 0; n < 10; n++)
                        {
                            var num = content.Length;
                            var str = Console.ReadLine();
                            var strLength = str.Length;
                            if (num <= strLength)
                            {
                                content = str;
                            }

                        }
                        Console.WriteLine(content);*/

            /*     var num = 0;
                 for (var i = 1; i < 501; i++)
                 {
                     if((i % 3 == 0 || i % 7 ==0) && i % 2 != 0)
                     {
                         num ++;
                     }
                 }
                 Console.WriteLine(num);*/
            /*   var sum = 0;
               while(true)
               {
                   Console.WriteLine("数字を入力してください");
                   var num = Console.ReadLine();
                   var n = int.Parse(num);
                   if (n <= 0)
                   {
                       break;
                   }
                   sum += n;
               }
               Console.WriteLine(sum);*/

            /*    var num = Console.ReadLine();
                var n = int.Parse(num);
                var str = "*";
                var sum = "*";
                for (var i = 0; i < n; i++)
                {
                    Console.WriteLine(sum);
                    sum += str;
                }*/


            /*            配列*/

            /*var score = new int[5] ;
            var sum = 0;
            for (var i = 0; i < score.Length; i++)
            {
                var num = Console.ReadLine();
                var n = int.Parse(num);
                score[i] = n;
            }

            foreach (var p in score)
            {
                sum += p;
            }
            Console.WriteLine(sum);*/

            /*       var numbers = new int[8];
                   var sum = 0;
                   for (var i = 0; i < numbers.Length; i++)
                   {
                       var input = Console.ReadLine();
                       var num = int.Parse(input);
                       sum += num;
                   }
                   var ave = (double)sum / numbers.Length;
                   Console.WriteLine($"合計{sum},平均{ave}です");
       */

            /* var numbers = new int[20];
             for (var i = 0; i < numbers.Length; i++)
             {
                 numbers[i] = 100 + i;

                 Console.WriteLine(numbers[i]);
             }*/

            string[] strs = { "hhh", "ttttt", "gg","5555555555"};
            var line = "";
            foreach (var str in strs)
            {
                if (line.Length <= str.Length)
                {
                    line = str;
                }
            }
            Console.WriteLine(line);
           
        }
    }
}
