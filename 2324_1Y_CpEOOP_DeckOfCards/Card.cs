using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_DeckOfCards
{
    internal class Card
    {
        private int suite = -1; // 0 hearts, 1 spades, 2 diamond, 3 clubs
        private int value = -1; 

        public Card(int s, int v) 
        {
            suite = s;
            value = v;
        }

        public int[] getCard()
        {
            return new int[] { suite, value };
        }
    }
}
