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

            // User interface
            Console.Write("Lady Luck is with you ...\n" +
                "What shall we call you? >>> ");
            string userName = Console.ReadLine();

            //using "out parameter to verify number of shuffles
            int timesShuffled;

            // Setting default of one shuffle for user option
            int times = 1;

            // User Input for number of time to shuffle
            try
            {
                Console.Write(userName+", tell me how many times will I shuffle for you? >>> ");
                times = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter Integers only... I will assume it is One for now.");
            }
            finally
            {
                Console.WriteLine("Let's start!");
                Console.ReadLine();
            }

            //// Instantiating class TwentyOneGame
            //TwentyOneGame game = new TwentyOneGame();

            //// We can access methods from class game (parent class)
            //// In this case game is the superclass
            //game.Players = new List<string>() { "Jesse", "Mir", "Erik" };

            //// This method prints the players names
            //game.ListPlayers();
            //Console.ReadLine();

            // Creating List of players
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>()
            {
                userName, "Amber", "Nadine", "Ronda"
            };
            // Calling ListPlayers
            game.ListPlayers();




            // Creating an object; using class=Decks
            Deck deck = new Deck(); // Instantiated an empty object called deck
            // Calling the shuffle method
            //deck = Shuffle(deck);
            //deck = Shuffle(deck, times);
            // using "named parameters" for ease of readability
            //deck = Shuffle(deck: deck, times: times, out timesShuffled);
            deck.Shuffle(out timesShuffled,times);

            // printing the Cards from the Deck using foreach loop
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Your Deck of Cards ");
            Console.WriteLine("-----------------------------------------");

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // printing the length of the list
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Number of Cards in this deck = "+deck.Cards.Count);
            Console.WriteLine("Number of times the deck was shuffled = {0}", timesShuffled);

            Console.WriteLine("-----------------------------------------");

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

        //********moved suffling method to Deck class*********
        //// Create a Method to Shuffle the Deck--takes in and outputs class type Deck
        //// using "optional parameter" for multiple shuffling {int times=1) makes it optional
        //public static Deck Shuffle(Deck deck, int times, out int timesShuffled) // Static, can be used without creating an object of it's class
        //{
        //    // keep count of how many times the deck has been shuffled -verify times shuffled
        //    timesShuffled = 0;

        //    for (int i=0; i < times; i++)
        //    {
        //        // create an empty tempList
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        // To shuffle. Get a random card and add it to tempList of cards
        //        while (deck.Cards.Count > 0)
        //        {
        //            // 1. create a random index to pick a card out of the deck
        //            int randomIndex = random.Next(0, deck.Cards.Count); // minvalue=1 maxvalue=52
        //                                                                // add to our empty templist
        //            TempList.Add(deck.Cards[randomIndex]);
        //            // Remove the card we picked
        //            deck.Cards.RemoveAt(randomIndex);
        //        }

        //        // Now we take our empty deck and assign TempList to it.
        //        deck.Cards = TempList;

        //        // Output after each shuffle
        //        Console.WriteLine("The Dealer is shuffling the deck:\n" +
        //            "\tShuffle number " + (i+1) + " done.\n");
        //        // increment times shuffled
        //        timesShuffled++;
        //    }

        //    // Output
        //    return deck;
        //}

        ////// DevOp Use ONLY: Testing 
        ////// For multiple shuffling we use "method overloading" --Note, Alt option = "optional parameters"
        ////// using same method name but the difference is number of parameters it takes
        ////public static Deck Shuffle(Deck deck, int times)
        ////{
        ////    // for loop to shuffle the deck any number of times given
        ////    for (int i=0; i< times; i++)
        ////    {
        ////        deck = Shuffle(deck);
        ////        Console.WriteLine(" The Dealer is shuffling the deck:\n" +
        ////            "Shuffle number " + (i+1) + " done.");
        ////    }
        ////    // output
        ////    return deck;
        ////}



    }
}
