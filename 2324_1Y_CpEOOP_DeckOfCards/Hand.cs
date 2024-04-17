using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2324_1Y_CpEOOP_DeckOfCards
{
    internal class Hand
    {
        private List<Card> _hand = null;
        private string playerName = "";
        private int HandValue = 0;

        public Hand(string name)
        {
            _hand = new List<Card>();
            playerName = name;
        }

        public void drawCards(Card[] cards)
        {
            foreach(Card card in cards)
                if(card != null)
                    _hand.Add(card);

            calculateHandValue();
        }

        private void calculateHandValue()
        {
            foreach(Card card in _hand)
            {
                HandValue += card.getCard()[1];
            }
        }

        public int getHandValue() 
        { 
            return HandValue;
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public void displayAllCards()
        {
            foreach (Card card in _hand)
            {
                Console.WriteLine($"{card.prepForDisplay()[1]} of {card.prepForDisplay()[0]}");
            }
        }
    }
}
