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

        }
    }
}
