using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;


namespace Casino
{
    // Design tip: design towards abstraction
    // Note we can NOT instantiate Game. We only inherit from it
    public abstract class Game
    {
        // General properties for any given game
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players{ get { return _players; } set { _players = value; } }        
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        public string Name { get; set; } // Name of the game

        // Methods for games
        // Creating an abstract method for play
        public abstract void Play();


        // Virtual keyword makes this a virtual method
        // This method gets inherited but can be overridden 
        public virtual void ListPlayers()
        {
            Console.WriteLine("========================");
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
            Console.WriteLine("========================\n");
           
            // adds a pause after listing players
            Console.ReadLine();
        }

    }
}
