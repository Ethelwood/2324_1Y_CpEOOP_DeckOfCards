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

            Console.WriteLine($"There are {myDeck.getCardCount()} cards in my deck.");

            while(myDeck.getCardCount() > 0)
            {
                tempCard = myDeck.draw().getCard();
                Console.WriteLine($"Card belongs {tempCard[0]} and a value of {tempCard[1]}");
            }


            Console.ReadKey();
        }
    }
}
