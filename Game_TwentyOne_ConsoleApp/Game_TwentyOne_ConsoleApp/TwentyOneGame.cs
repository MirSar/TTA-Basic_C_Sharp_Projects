using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // This class inherits from parent class Game
    public class TwentyOneGame:Game
    {
        // Overriding the abstract method
        public override void Play()
        {
            // if this is called we throw and error
            throw new NotImplementedException();

        }

        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack '21' Players:");
            base.ListPlayers();
        }
    }
}
