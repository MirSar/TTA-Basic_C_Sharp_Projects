using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // set as public so other programs can access it.
    public class Card
    {
        //// Creating a Constructor
        //// These will be the default values if no values are given upon creation
        //public Card() // constructor method name == class name
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        // defining properties
        public string Suit { get; set; }
        public string Face { get; set; }

    }
}
