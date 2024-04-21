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
        private Random _rnd = new Random ();

        public Deck()
        {
            for(int s = 0; s < 4; s++)
            {
                for(int v = 0; v < 13; v++)
                {
                    _deck.Add(new Card(s, v));
                }
            }
            for(int i = 0; i < 7; i++)
            {
                shuffle();
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

        public Card[] draw(int num)
        {
            Card[] temp = new Card[num];

            for(int x = 0; x < temp.Length; x++)
                if(_deck.Count > 0)
                    temp[x] = draw();

            return temp;
        }

        public void shuffle()
        {
            int pos = 0;
            int num = 0;
            List<Card> temp = new List<Card>();

            while(_deck.Count > 0)
            {
                pos = _rnd.Next(_deck.Count);
                num = _rnd.Next(5) + 1;

                while(pos < _deck.Count && num > 0)
                {
                    temp.Add(_deck[pos]);
                    _deck.RemoveAt(pos);
                    num--;
                }
            }

            _deck = new List<Card>(temp);
            temp.Clear();
        }
    }
}
