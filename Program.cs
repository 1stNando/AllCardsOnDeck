using System;
using System.Collections.Generic;
namespace OurDotnetApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //First version attempt at making the deck of cards:
            //var cards = new List<string>() {
            //        "AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD",
            //"AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH",
            //"AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC",
            //"AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS"};

            //var rightIndex = cards.Count - 1;



            //Algorithm B
            // - Make a list of the 4 suits and call this list 'suits'
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            // - Make a list of the 13 ranks and call this list 'ranks'
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // - Make a new list of strings named 'deck'
            var deck = new List<string>();


            // -Make a loop that goes through the list of 'suits'
            foreach (var suit in suits)
            {
                //Make a loop that goes through the list of 'ranks'
                foreach (var rank in ranks)
                {
                    // for each rank, make a new string of the form $"{rank} of $"{suit}"
                    var card = $"{rank} of {suit}";

                    // add that newly formed string to the end of the deck
                    deck.Add(card);
                }
            }
            //Create a  new list of the number of cards in the deck.
            var numberOfCards = deck.Count;
            //For right index, from (number of cards -1) down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex.
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);

                //Now swap the values at rightIndex and leftIndex by doing this:

                //leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];

                // rightCard= the value from deck[rightIndex]
                var rightCard = deck[rightIndex];

                // deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                // deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;
            }





            //exited shuffle loop notification
            Console.WriteLine("Done shuffling");

            //firstCard define it
            var firstCard = deck[0];
            //secondCard define it
            var secondCard = deck[1];

            // Print on screen the first and second card of the shuffled deck
            Console.WriteLine($"The first card is {firstCard} and the second card is {secondCard}");

        }
    }
}