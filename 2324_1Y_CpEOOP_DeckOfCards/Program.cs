using System;
using System.Collections.Generic;
using System.Data;
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
            //int[] tempCard = new int[] { };
            Hand p1 = new Hand("Arvin");

            Console.WriteLine($"Sup, {p1.getPlayerName()}! Sit down, we're playing Blackjack!: ");
            int playing = 1;

            while (playing == 1 && myDeck.getCardCount() > 0)
            {
                Console.WriteLine($"There are {myDeck.getCardCount()} cards in the deck.");
                
                p1.drawCards(myDeck.draw(2));
                Console.WriteLine();
                p1.displayAllCards();
                Console.WriteLine();
                p1.checkAce();
                Console.WriteLine($"{p1.getPlayerName()} has a hand value of {p1.getHandValue()}");
                Console.WriteLine();
                while(p1.getHandValue() < 21) p1.drawAgain(myDeck);

                p1.checkWin();

                int ipvalid = -1;
                while (ipvalid == -1)
                {
                    Console.Write("Try Again? (Y/N): ");
                    string stillplaying = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (stillplaying == "N")
                    {
                        playing = 0;
                        Console.WriteLine("Game Over.");
                        ipvalid = 0;
                        p1.clearHand();
                    } 
                    
                    else if (stillplaying == "Y")
                    {
                        Console.WriteLine("Alright. Let's continue.");
                        Console.WriteLine();
                        ipvalid = 0;
                        p1.clearHand();
                    }
                    else Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}
