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
            HandValue = 0;
            foreach(Card card in _hand)
            {
                HandValue += (card.getCard()[1] + 1);
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

        public void checkAce()
        {
            for(int i = 0; i < _hand.Count; i++)
            {
                if (_hand[i].getCard()[1] == 0)
                {
                    Console.Write("Ace found. Should its value be 1 or 11?: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        //do nothing
                    }
                    else if (choice == 11)
                    {
                        HandValue += 10;
                        _hand[i].prepForDisplay()[1] = "Ace";
                    }
                    else Console.WriteLine("Invalid input.");
                }
            }
        }

        public void drawAgain(Deck _deck)
        {
            if (getHandValue() < 21)
            {
                Console.Write("Draw another? (Y/N): ");
                string ans = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (ans == "N")
                {
                    Console.WriteLine("You thought we were playing regular Blackjack, but you're in my house, betch! You play it safe, you LOSE!\n");
                    Console.WriteLine();
                }
                else if (ans == "Y")
                {
                    drawCards(_deck.draw(1));
                    checkAce();
                    Console.WriteLine();
                }
                else Console.WriteLine("Invalid input!");
                displayAllCards();
                Console.WriteLine();
                Console.WriteLine($"{getPlayerName()} has a hand value of {getHandValue()}");
                Console.WriteLine();
            }
        }

        public void checkWin()
        {
            if (getHandValue() == 21) Console.WriteLine($"{playerName} wins!\n");

            else if (getHandValue() < 21) Console.WriteLine($"No one wins.\n");

            else if (getHandValue() > 21) Console.WriteLine($"Dealer wins.\n");
        }

        public void clearHand()
        {
            _hand.Clear();
        }
    }
}
