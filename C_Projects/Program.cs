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
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num >= 10)
            {
                Console.WriteLine("num >= 10が成り立ちました");
                Console.WriteLine($"numの値は{num}です");
            }
        }
    }
}
