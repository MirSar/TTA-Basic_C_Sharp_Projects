using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    // set as public so other programs can access it.
    public struct Card
    {
        // defining properties: Suit and Face properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        // Overriding the default "ToString" method with our own custom method
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

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
