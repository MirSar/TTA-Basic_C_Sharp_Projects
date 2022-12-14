using System;
using System.Collections.Generic; // Lists
using System.IO; // to access file class to read-write txt files
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game Introduction
            const string casinoName = "BlackJack Rules Casino";
            Console.WriteLine("##########################################");
            Console.WriteLine("Welcome to the {0}!!",casinoName);
            Console.WriteLine("##########################################");

            // Getting new player info
            Console.Write("What is your name young player?\n>>> ");
            string newPlayerName = Console.ReadLine();

            // Admin access to print out Exceptions
            if (newPlayerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                // Loop through the list
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                // keep it open
                Console.Read();
                return;
            }

            // using TryParse as an exception handler
            bool validAnswer = false;
            int newPlayerBank = 0;
            while (!validAnswer)
            {
                Console.Write("{0} how much money are you playing with today?\n>>> $ ", newPlayerName);
                validAnswer = int.TryParse(Console.ReadLine(), out newPlayerBank);
                if (!validAnswer) Console.WriteLine("Please enter a Whole number.");
            }

            Console.Write("\n{0}, Would you like to join a game of 21 right now?\n>>> ",newPlayerName);
            string answer = Console.ReadLine().ToLower();          

            // Creating a new player and game
            if (answer == "yes"|| answer == "yeah" || answer == "ya" || answer == "y" || answer == "ok"||answer == "sure"||answer == "yup")
            {
                // Creating a new Player object and initilize the player
                Player player = new Player(newPlayerName, newPlayerBank);
                // creating a unique identifier for the player
                player.Id = Guid.NewGuid();
                // Logging the player id
                using (StreamWriter file = new StreamWriter(@"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\TwentyOne\LogFolder\logCardsDealt.txt", true))
                {
                    // Adding a DateTime
                    file.WriteLine(player.Id);
                }

                // Creating a new Game object and initilize the Game
                // Using polymorphism...gives access to overloaded operators
                Game game = new TwentyOneGame();
                // Adding player to the game
                game += player;
                // Set the players status
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    // catch any exception during Play()
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        // Logging our Exception via "UpdateDBWithException ()" method
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                    catch (Exception ex)
                    {
                        Console.WriteLine("A unique Exception occured during Play().");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
           
                }

                // When exiting while loop, remove player
                game -= player;
                // End of the game message
                Console.WriteLine("##########################################");
                Console.WriteLine("Thank you {0} for playing with us!", player.Name);
                Console.WriteLine("##########################################");
            }
            else
            {
                // Message if they don't want to play
                Console.WriteLine("Feel free to look around the casino. \nGoodby {0}", newPlayerName);
            }
            
            // Keep the Console Open
            Console.ReadLine();      

            /************* This was for DEVOPS and Learning*********************************/
            //    Console.WriteLine("******************************************");
            //    Console.WriteLine("White Jack? ... no\n" +
            //        "Blue Jack?... no\n" +
            //        "BlackJack! ... YES, let's Play!!");
            //    Console.WriteLine("******************************************");

            //    // User interface
            //    Console.Write("Lady Luck is with you ...\n" +
            //        "What shall we call you? >>> ");
            //    string userName = Console.ReadLine();

            //    //using "out parameter to verify number of shuffles
            //    int timesShuffled;

            //    // Setting default of one shuffle for user option
            //    int times = 1;

            //    // User Input for number of time to shuffle
            //    try
            //    {
            //        Console.Write(userName+", tell me how many times will I shuffle for you? >>> ");
            //        times = Convert.ToInt32(Console.ReadLine());

            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Please enter Integers only... I will assume it is One for now.");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Let's start!");
            //        Console.ReadLine();
            //    }

            //    //// Instantiating class TwentyOneGame
            //    //TwentyOneGame game = new TwentyOneGame();

            //    //// We can access methods from class game (parent class)
            //    //// In this case game is the superclass
            //    //game.Players = new List<string>() { "Jesse", "Mir", "Erik" };

            //    //// This method prints the players names
            //    //game.ListPlayers();
            //    //Console.ReadLine();


            //    // Instantiating by using Polymorphism 
            //    Game game = new TwentyOneGame();
            //    // Initializing a List of Players
            //    game.Players = new List<Player>();

            //    // Creating a new waiting list of players
            //    List<string> waitingList = new List<string>
            //    {
            //        userName, "Amber", "Nadine", "Ronda","Jesse", "Cindy"
            //    };

            //    // Using foreach loop to add the waitinglist players to the 
            //    // game Players list
            //    foreach (string newplayer in waitingList)
            //    {
            //        // Initilizing player
            //        Player player = new Player();
            //        // Addding the name to the new player from the waitinglist 
            //        player.Name = newplayer;
            //        // Using the overloaded operator as defined in Player.cs
            //        game += player;

            //        // To remove a player ... no Jesse allowed :) j/p
            //        if (player.Name == "Jesse")
            //        {
            //            game -= player;
            //        }
            //    };


            //    // To print the list we are calling ListPlayers
            //    game.ListPlayers();


            //    // Creating an object; using class=Decks
            //    Deck deck = new Deck(); // Instantiated an empty object called deck
            //    // Calling the shuffle method
            //    //deck = Shuffle(deck);
            //    //deck = Shuffle(deck, times);
            //    // using "named parameters" for ease of readability
            //    //deck = Shuffle(deck: deck, times: times, out timesShuffled);
            //    deck.Shuffle(out timesShuffled, times);

            //    // printing the Cards from the Deck using foreach loop
            //    Console.WriteLine("-----------------------------------------");
            //    Console.WriteLine(" Your Deck of Cards ");
            //    Console.WriteLine("-----------------------------------------");

            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " of " + card.Suit);
            //    }
            //    // printing the length of the list
            //    Console.WriteLine("-----------------------------------------");
            //    Console.WriteLine("Number of Cards in this deck = "+deck.Cards.Count);
            //    Console.WriteLine("Number of times the deck was shuffled = {0}", timesShuffled);

            //    Console.WriteLine("-----------------------------------------");

            //    //// DevOp Use ONLY: Testing 
            //    //// The below method of creating each deck is not feasible method
            //    //// It is better to create and use a Constroctor for the Deck Class
            //    //deck.Cards = new List<Card>(); // Instantiating the datatype list<card>
            //    //// Creating an object; using our user-defined class Card
            //    //Card cardOne = new Card(); // this is an empty object
            //    //cardOne.Face = "Queen"; // assigned value to Card property Face
            //    //cardOne.Suit = "Spades";
            //    //// Now we can add cards to the deck.Cards of list<Card>
            //    //deck.Cards.Add(cardOne);
            //    //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            //    // Keep the Console Open
            //    Console.ReadLine();
            //}

            ////********moved suffling method to Deck class*********
            ////// Create a Method to Shuffle the Deck--takes in and outputs class type Deck
            ////// using "optional parameter" for multiple shuffling {int times=1) makes it optional
            ////public static Deck Shuffle(Deck deck, int times, out int timesShuffled) // Static, can be used without creating an object of it's class
            ////{
            ////    // keep count of how many times the deck has been shuffled -verify times shuffled
            ////    timesShuffled = 0;

            ////    for (int i=0; i < times; i++)
            ////    {
            ////        // create an empty tempList
            ////        List<Card> TempList = new List<Card>();
            ////        Random random = new Random();

            ////        // To shuffle. Get a random card and add it to tempList of cards
            ////        while (deck.Cards.Count > 0)
            ////        {
            ////            // 1. create a random index to pick a card out of the deck
            ////            int randomIndex = random.Next(0, deck.Cards.Count); // minvalue=1 maxvalue=52
            ////                                                                // add to our empty templist
            ////            TempList.Add(deck.Cards[randomIndex]);
            ////            // Remove the card we picked
            ////            deck.Cards.RemoveAt(randomIndex);
            ////        }

            ////        // Now we take our empty deck and assign TempList to it.
            ////        deck.Cards = TempList;

            ////        // Output after each shuffle
            ////        Console.WriteLine("The Dealer is shuffling the deck:\n" +
            ////            "\tShuffle number " + (i+1) + " done.\n");
            ////        // increment times shuffled
            ////        timesShuffled++;
            ////    }

            ////    // Output
            ////    return deck;
            ////}

            //////// DevOp Use ONLY: Testing 
            //////// For multiple shuffling we use "method overloading" --Note, Alt option = "optional parameters"
            //////// using same method name but the difference is number of parameters it takes
            //////public static Deck Shuffle(Deck deck, int times)
            //////{
            //////    // for loop to shuffle the deck any number of times given
            //////    for (int i=0; i< times; i++)
            //////    {
            //////        deck = Shuffle(deck);
            //////        Console.WriteLine(" The Dealer is shuffling the deck:\n" +
            //////            "Shuffle number " + (i+1) + " done.");
            //////    }
            //////    // output
            //////    return deck;
            //////
        }

        //Accessing a Database to log our Exceptions
        private static void UpdateDBWithException(Exception ex)
        {
            // 1. Need a connection string ... get info from dB properties->General
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            // 2. Make a Query string ... using parameterized queries to protect against SQL injections
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES    
                                (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            // 3. Creating a Using statement...helps control unmanaged resources (includes auto close)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command (which is a specific data type)
                SqlCommand command = new SqlCommand(queryString, connection);
                
                // Add to the command the datatype...Note: by including the datatype we are protecting agains SQL injections
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                // Now we add the actual parameter Values
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                // Sending the data to the dataBase
                // Open the connection
                connection.Open();
                // Execute our command (insert statement is nonQuery)
                command.ExecuteNonQuery();
                // Close connection
                connection.Close();

            }


        }

        // Method to query the dB read and display Exceptions
        private static List<ExceptionEntity> ReadExceptions()
        {
            // 1. Need a connection string ... get info from dB properties->General
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            // 2. Making a query string
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand (queryString, connection);

                connection.Open();

                // Execute a reader
                SqlDataReader reader = command.ExecuteReader();

                // Looping through each record
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);

                    // Adding it to the list
                    Exceptions.Add(exception);
                }
                // Close our connection
                connection.Close();
            }
            // return our Exceptions
            return Exceptions;

        }

    }
}
