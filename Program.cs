using System;
using System.Collections.Generic;

namespace AllCardsOnDeck4CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suit = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            var listOfCards = new List<string>();
            var cardValue = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int index = 0; index < cardValue.Count; index++)
            {
                for (int j = 0; j < suit.Count; j++)
                    listOfCards.Add($"{cardValue[index]} of {suit[j]}");
            };

            var sizeOfDeck = listOfCards.Count;
            for (var endOfDeck = sizeOfDeck - 1; endOfDeck >= 0; endOfDeck--)
            {
                // added Fisher-Yates shuffle
                var randomNumberForDeck = new Random().Next(0, sizeOfDeck);
                var randomCardWithinDeck = listOfCards[randomNumberForDeck];
                listOfCards[randomNumberForDeck] = listOfCards[endOfDeck];
                listOfCards[endOfDeck] = randomCardWithinDeck;
            }
            // display shuffled cards in console
            Console.WriteLine(listOfCards[0]);
            Console.WriteLine(listOfCards[1]);

        }
    }
}