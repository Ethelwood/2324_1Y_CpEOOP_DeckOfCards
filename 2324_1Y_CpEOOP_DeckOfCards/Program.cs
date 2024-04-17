using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            int[] tempCard = new int[] { };
            Hand p1 = new Hand("Arvin");
            Hand p2 = new Hand("Anthonette");

            Console.WriteLine($"There are {myDeck.getCardCount()} cards in my deck.");

            p1.drawCards(myDeck.draw(2));
            p2.drawCards(myDeck.draw(2));

            Console.WriteLine($"{p1.getPlayerName()} has a hand value of {p1.getHandValue()}");
            p1.displayAllCards();   
            Console.WriteLine($"{p2.getPlayerName()} has a hand value of {p2.getHandValue()}");
            p2.displayAllCards();

            //while(myDeck.getCardCount() > 0)
            //{
            //    tempCard = myDeck.draw().getCard();
            //    Console.WriteLine($"Card belongs {tempCard[0]} and a value of {tempCard[1]}");
            //}


            Console.ReadKey();
        }
    }
}
