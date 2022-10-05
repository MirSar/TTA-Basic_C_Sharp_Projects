using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // set as public so other programs can access it.
    public struct Card
    {
        //// Creating a Constructor
        //// These will be the default values if no values are given upon creation
        //public Card() // constructor method name == class name
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        // This Class makes Cards with Suit and Face properties ==> defining properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

    }
    // Defining Enumerated types
    public enum Suit
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

}
