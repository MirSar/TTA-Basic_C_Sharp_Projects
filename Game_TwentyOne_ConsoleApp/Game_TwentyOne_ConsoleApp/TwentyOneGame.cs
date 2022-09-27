using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // This class inherits from parent class Game
    // IwalkAway is an interface (interface starts with I..)
    public class TwentyOneGame : Game, IWalkAway 
    {
        // Overriding the abstract method
        public override void Play()
        {
            // if this is called we throw and error
            throw new NotImplementedException();
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
