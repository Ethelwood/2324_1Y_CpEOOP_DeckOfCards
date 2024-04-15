using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_DeckOfCards
{
    internal class Deck
    {
        private List<Card> _deck = new List<Card> ();

        public Deck()
        {
            for(int s = 0; s < 4; s++)
            {
                for(int v = 0; v < 13; v++)
                {
                    _deck.Add(new Card(s, v));
                }
            }
        }

        public int getCardCount()
        {
            return _deck.Count;
        }

        public Card draw()
        {
            Card single = _deck[_deck.Count - 1];
            _deck.RemoveAt(_deck.Count - 1);
            return single;
        }

    }
}
