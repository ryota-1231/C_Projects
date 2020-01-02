using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_log
{
    class Program
    {
        static void Main(string[] args)
        {
            //ミニコンピュータ
            //var a = 0;
            //var b = 0;

            //var line = System.Console.ReadLine();
            //var x = int.Parse(line);
            //var lists = new int[x];
            //var orders = new string[x];
            //for (var i = 0; i < lists.Length; i++)
            //{
            //    orders[i] = System.Console.ReadLine();
            //}
            //foreach (var order in orders)
            //{
            //    var od = order.Split(' ');
            //    if (od[0] == "SET")
            //    {
            //        if (od[1] == "1")
            //        {
            //            a = int.Parse(od[2]);
            //        }
            //        else
            //        {
            //            b = int.Parse(od[2]);
            //        }
            //    }
            //    else if (od[0] == "ADD")
            //    {
            //        b = a + int.Parse(od[1]);
            //    }
            //    else
            //    {
            //        b = a - int.Parse(od[1]);
            //    }
            //}
            //System.Console.WriteLine($"{a} {b}");

            //完全数とほぼ完全数
            //var line = System.Console.ReadLine();
            //var lists = new string[int.Parse(line)];
            //var nums = new int[int.Parse(line)];
            //for (var i = 0; i < lists.Length; i++)
            //{
            //    var num = System.Console.ReadLine();
            //    nums[i] = int.Parse(num);
            //}
            //foreach (var num in nums)
            //{
            //    var count = 0;
            //    for (var i = 1; i < num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            count += i;
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //    if (count == num)
            //    {
            //        System.Console.WriteLine("perfect");
            //    }
            //    else if (num - count == 1)
            //    {
            //        System.Console.WriteLine("nearly");
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("neither");
            //    }
            //}

            //温度差計算
            //var line = System.Console.ReadLine();
            //string[] nums = line.Split(' ');
            //var x = int.Parse(nums[0]);
            //var y = int.Parse(nums[1]);
            //System.Console.WriteLine(x - y);

            //Leet文字列
            //     var line = System.Console.ReadLine();
            //var a = line.Replace("A", "4");
            //var b = a.Replace("E", "3");
            //var c = b.Replace("G", "6");
            //var d = c.Replace("I", "1");
            //var e = d.Replace("O", "0");
            //var f = e.Replace("S", "5");
            //var g = f.Replace("Z", "2");

            //System.Console.WriteLine(g);

            //三角形の内角の和
            //var line = System.Console.ReadLine();
            //var num = System.Console.ReadLine();

            //System.Console.WriteLine(180 - int.Parse(line) - int.Parse(num));

            //数字の桁数
            //var line = System.Console.ReadLine();
            //System.Console.WriteLine(line.ToString().Length);

            //サイコロの裏面
            //var line = System.Console.ReadLine();
            //var num = 7 - int.Parse(line);
            //System.Console.WriteLine(num);

            //忘年会の予算
            //    var line = System.Console.ReadLine();
            //string[] nums = line.Split(' ');
            //var x = int.Parse(nums[0]);
            //var y = int.Parse(nums[1]);
            //System.Console.WriteLine(x * 6000 + y * 4000);

            //縦書きと横書き
            //var line = System.Console.ReadLine();
            //string[] lists = new string[int.Parse(line)];
            //for (var i = 0; i < lists.Length; i++)
            //{
            //    var list = System.Console.ReadLine();
            //    lists[i] = list;
            //}

            //// 配列内の各要素を"　"で区切って連結
            //string data = string.Join(" ", lists);

            //// 変数の中身を表示
            //System.Console.WriteLine(data);


            //イルミネーションの数
            //var line = Console.ReadLine();
            //string[] nums = line.Split(' ');
            //var x = double.Parse(nums[0]);
            //var y = double.Parse(nums[1]);
            //var z = double.Parse(nums[2]);
            //var result = Math.Ceiling(x / y) * z;
            //Console.WriteLine(result);

            //契約の交渉
            //var line = Console.ReadLine();
            //var y = line.Replace("n", "");
            //Console.WriteLine(y.Length);

            //家族で分ける
            // var line = System.Console.ReadLine();
            //var nums = System.Console.ReadLine();
            //var lists = nums.Split(' ');
            //var h = int.Parse(lists[0]);
            //var w = int.Parse(lists[1]);
            //var result = h * w % int.Parse(line);
            //System.Console.WriteLine(result);

            //ワインのキャッチコピー
            //var line = System.Console.ReadLine();
            //var str = "Best in";
            //System.Console.WriteLine($"{str} {line}");

            //自動でチャージ
            //var line = System.Console.ReadLine();
            //var num = int.Parse(line);
            //if (num >= 10000)
            //{
            //    System.Console.WriteLine(num);
            //}
            //else
            //{
            //    System.Console.WriteLine(num + 10000);
            //}

            //西暦の計算
            //var line = System.Console.ReadLine();
            //var nums = line.Split(' ');
            //var num1 = int.Parse(nums[0]);
            //var num2 = int.Parse(nums[1]);
            //System.Console.WriteLine(num2 - num1);

            //カード並べ
            //var line = Console.ReadLine();
            //var numbers = line.Split(' ');
            //int[] intArray = numbers.Select(int.Parse).ToArray();
            //Array.Sort(intArray);
            //var num1 = intArray[3] * 10;
            //var num2 = intArray[2] * 10;
            //var result = num1 + num2 + intArray[0] + intArray[1];
            //Console.WriteLine(result);


            //テストの採点
            //var line = Console.ReadLine();
            //var lines = line.Split(' ');
            //int[] lists = lines.Select(int.Parse).ToArray();
            //var members = new List<int>();
            //for (var i = 0; i < lists[0]; i++)
            //{
            //    var eles = Console.ReadLine();
            //    var ele = eles.Split(' ');
            //    var nums = ele.Select(int.Parse).ToArray();
            //    if (lists[1] != 0)
            //    {
            //        if ((nums[0] - nums[1] * 5 - lists[1]) < 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {

            //            members.Add(i + 1);
            //        }
            //    }
            //    else
            //    {
            //        members.Add(i + 1);
            //    }
            //}
            //foreach (var mem in members)
            //{
            //    Console.WriteLine(mem);
            //}

            //ログのフィルター
            //var line = Console.ReadLine();
            //var imp = Console.ReadLine();
            //var str = new List<string>();
            //for (var i = 0; i < int.Parse(line); i++)
            //{
            //    var target = Console.ReadLine();
            //    var num = target.IndexOf(imp);
            //    if (num >= 0)
            //    {
            //        str.Add(target);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //if (str.Count == 0)
            //{
            //    Console.WriteLine("None");
            //}
            //else
            //{
            //    foreach (var s in str)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //数字の調査
            //var line = Console.ReadLine();
            //var nums = line.Split(' ').Select(int.Parse).ToArray();
            //var num = nums[1];
            //var orders = new List<int>();
            //var lists = new List<int>();
            //for (var i = 0; i < nums[0]; i++)
            //{
            //    orders.Add(int.Parse(Console.ReadLine()));
            //}

            //while (true)
            //{
            //    if (num == 0 || num == 1)
            //    {
            //        lists.Add(num);
            //        break;
            //    }
            //    lists.Add(num % 2);
            //    num = num / 2;
            //}
            //foreach (var ord in orders)
            //{
            //    Console.WriteLine(lists[ord - 1]);
            //}

            //    public class Hello
            //{
            //    public static void Main()
            //    {
            //        // 自分の得意な言語で
            //        // Let's チャレンジ！！

            //        var line = System.Console.ReadLine();
            //        var result = 100 + 10 * int.Parse(line);
            //        System.Console.WriteLine(result);
            //    }
            //}

            //先生の宿題

            //var line = System.Console.ReadLine();
            //// System.Console.WriteLine(line);
            //var src = line.Split(' ');
            //var lists = new List<string>();
            //lists.AddRange(src);
            //var x = "x";
            //var plus = "+";
            //var num = lists.IndexOf(x);
            //var judge = lists.IndexOf(plus);

            //if (num == 4)
            //{
            //    if (judge >= 0)
            //    {
            //        var result = int.Parse(lists[0]) + int.Parse(lists[2]);
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        var result = int.Parse(lists[0]) - int.Parse(lists[2]);
            //        Console.WriteLine(result);
            //    }
            //}
            //else if (num == 2)
            //{
            //    if (judge >= 0)
            //    {
            //        var result = int.Parse(lists[4]) - int.Parse(lists[0]);
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        var result = int.Parse(lists[0]) - int.Parse(lists[4]);
            //        Console.WriteLine(result);
            //    }
            //}
            //else
            //{
            //    if (judge >= 0)
            //    {
            //        var result = int.Parse(lists[4]) - int.Parse(lists[2]);
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        var result = int.Parse(lists[4]) + int.Parse(lists[2]);
            //        Console.WriteLine(result);
            //    }
            //}


        }
    }
}
