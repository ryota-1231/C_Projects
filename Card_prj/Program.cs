using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    var card = new Card(CardSuit.Heart, 8);
                card.Print();
                if (card.Suit == CardSuit.Diamond)
                {
                    Console.WriteLine("ダイヤです");
                }
                else
                {
                    Console.WriteLine("ダイヤではありません");
                }*/

            /* 列挙型*/
            /* var week = DayOfWeek.Sunday;
             if (week == DayOfWeek.Friday)
             {
                 Console.WriteLine("金曜日です");
             }
             else
             {
                 Console.WriteLine("金曜日ではありません");
             }
         }*/

          
        }
    }

    /*    構造体・列挙型*/
    enum CardSuit
    {
        Club,
        Spade,
        Heart,
        Diamond
    }
    struct Card
    {
        public CardSuit Suit { get; private set; }
        public int Number { get; private set; }

        public Card(CardSuit suit, int number)
        {
            Suit = suit;
            Number = number;
        }

        public void Print()
        {
            var s = "";
            switch (Suit)
            {
                case CardSuit.Heart:
                    s = "ハート";
                    break;
                case CardSuit.Diamond:
                    s = "ダイヤ";
                    break;
                case CardSuit.Spade:
                    s = "スペード";
                    break;
                case CardSuit.Club:
                    s = "クラブ";
                    break;
            }
            Console.WriteLine($"{s} {Number}");
        }
    }


}
