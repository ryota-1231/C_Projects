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
            var num = Console.ReadLine();
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
            }
        }
    }
}
