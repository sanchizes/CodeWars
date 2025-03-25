using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class PokerStraight
    {
        public static bool IsStraight(List<Card> list)
        {
            return true;
        }

        public class Card
        {
            public int CardValue { get; set; }

            List<Card> cards = new List<Card>();
        }
    }
}
