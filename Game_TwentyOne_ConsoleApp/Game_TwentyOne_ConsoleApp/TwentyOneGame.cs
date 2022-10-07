using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.Threading.Tasks;


namespace Game_TwentyOne_ConsoleApp
{
    // This class inherits from parent class Game
    // IwalkAway is an interface (interface starts with I..)
    public class TwentyOneGame : Game, IWalkAway 
    {
        // Properties
        public TwentyOneDealer Dealer { get; set; }

        // Overriding the abstract method
        public override void Play()
        {
            // Instantiate a dealer
            Dealer = new TwentyOneDealer();
            // Setting default of one shuffle for user option
            int times = 1;
            // User Input for number of time to shuffle
            foreach (Player player in Players)
            {
                // At the start of each hand, we need to reset
                player.Hand = new List<Card>();
                player.Stay = false;
                try
                {
                    Console.Write("\n{0}, tell me how many times shall I shuffle for you? >>> ", player.Name);
                    times = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter Integers only... I will assume it is One for now.");
                }
                finally
                {
                    Console.WriteLine("Let's start!");
                    Console.ReadLine();
                }
            }
            // Resetting dealer's hand
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            // Use a new deck of cards to avoid using a partial deck
            Dealer.Deck = new Deck();
            // Shuffling the deck
            Dealer.Deck.Shuffle(times);

            Console.Write("\nPlace your bet! >>> $ ");
            // Loop through each player and have them place thier bets
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                // check the bet status
                if (!successfullyBet)
                {
                    // End this method...loops back to asking place your bet
                    return;
                }
                // Using the dictionary entry to track the bets
                Bets[player] = bet;
            }

            // Dealing Cards
            Console.WriteLine("\n*******************************************");
            for (int i=0; i<2; i++)
            {
                Console.WriteLine("DEALING...\n");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    // Check for BlackJack
                    if (i == 1) // second card
                    {
                        // Call our method to check for BJ
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                            Console.WriteLine("BLACKJACK!! {0} WINS!! {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player]*1.5)+Bets[player]);
                            Console.WriteLine("{0}'s new balance is {1}", player.Name, player.Balance);
                            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                            // End round
                            return;
                        }
                    }
                }
                // Check Dealers hand
                Console.Write("Dealer's card: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1) // Second card is dealt
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("Dealer has BlackJack. Everyone loses :(");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        // Iterate through the Dictionary
                        foreach (KeyValuePair<Player,int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        // End round
                        return;
                    }
                }
            }

            Console.WriteLine("\n*******************************************");
            // All cards are dealt... now we continue to play
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        // We are using our custom "ToString" mehtod to show thier cards
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++\n");

                    Console.Write("\nHit or Stay?\n>>> ");
                    // Note: May want to add Try/Catch here for user entry verification
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    // Check if player busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted. You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("{0}, do you want to continue playing?", player.Name);
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y" || answer == "yup")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }

            // Now it's the dealers turn
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("\nDealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("\nDealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer BUSTS!!");
                // Bets is a dictionary property of class Game
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!!", entry.Key.Name, entry.Value);
                    // paying the players... using lambda expression
                    // note: where creates a list which is why we need to indicate ".first()"
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                // end round
                return;
            }
            // Comparing the players hand with the dealers hand
            foreach (Player player in Players)
            {
                // using a nullable bool
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push!! No one wins.");
                    player.Balance += Bets[player];
                    Console.WriteLine("Your balance remains as {0}", player.Balance);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!!", player.Name, Bets[player]); ;
                    player.Balance += (Bets[player]*2);
                    Dealer.Balance -= Bets[player];
                    Console.WriteLine("Your new balance is {0}", player.Balance);
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}.", Bets[player]);
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("Your new balance is {0}", player.Balance);
                }

                // Ask if the player want to continue playing
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y" || answer == "yup" && player.Balance>0)
                {
                    player.isActivelyPlaying = true;
                }
                else player.isActivelyPlaying = false;
            }          

        }

        // Including the Interface method
        public void WalkAway(Player player)
        {
            // Temperary throw this exception till we use the method
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack '21' Players:");         
            base.ListPlayers();
        }
    }
}
