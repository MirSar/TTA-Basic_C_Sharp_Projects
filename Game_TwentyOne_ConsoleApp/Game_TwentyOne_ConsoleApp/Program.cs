using System;
using System.Collections.Generic; // Lists


namespace Game_TwentyOne_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("White Jack? ... no\n" +
                "Blue Jack?... no\n" +
                "BlackJack! ... YES, let's Play!!");
            Console.WriteLine("******************************************");

            // Creating an object; using class=Decks
            Deck deck = new Deck(); // Instantiated an empty object called deck

            // Calling the shuffle method
            deck = Shuffle(deck);

            // printing the Cards from the Deck using foreach loop
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // printing the length of the list
            Console.WriteLine("Number of Cards in this deck = "+deck.Cards.Count);

            //// DevOp Use ONLY: Testing 
            //// The below method of creating each deck is not feasible method
            //// It is better to create and use a Constroctor for the Deck Class
            //deck.Cards = new List<Card>(); // Instantiating the datatype list<card>
            //// Creating an object; using our user-defined class Card
            //Card cardOne = new Card(); // this is an empty object
            //cardOne.Face = "Queen"; // assigned value to Card property Face
            //cardOne.Suit = "Spades";
            //// Now we can add cards to the deck.Cards of list<Card>
            //deck.Cards.Add(cardOne);
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            // Keep the Console Open
            Console.ReadLine();
        }

        // Create a Method to Shuffle the Deck
        public static Deck Shuffle(Deck deck)
        {
            // create an empty tempList
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            // To shuffle. Get a random card and add it to tempList of cards
            while (deck.Cards.Count > 0)
            {
                // 1. create a random index to pick a card out of the deck
                int randomIndex = random.Next(0, deck.Cards.Count); // minvalue=1 maxvalue=52
                // add to our empty templist
                TempList.Add(deck.Cards[randomIndex]);
                // Remove the card we picked
                deck.Cards.RemoveAt(randomIndex);
            }
            // Now we take our empty deck and assign TempList to it.
            deck.Cards = TempList;
            return deck;
        }



    }
}
