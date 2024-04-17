using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        public string[] prepForDisplay()
        {
            string[] dCard = { "",""};

            switch(suite)
            {
                case 0:
                    dCard[0] = "Hearts";
                    break;
                case 1:
                    dCard[0] = "Spades";
                    break;
                case 2:
                    dCard[0] = "Diamonds";
                    break;
                case 3:
                    dCard[0] = "Clubs";
                    break;
            }

            switch(value)
            {
                case 0:
                    dCard[1] = "Ace";
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    dCard[1] = (value + 1).ToString();
                    break;
                case 10:
                    dCard[1] = "Jack";
                    break;
                case 11:
                    dCard[1] = "Queen";
                    break;
                case 12:
                    dCard[1] = "King";
                    break;
            }

            return dCard;
        }
    }
}
