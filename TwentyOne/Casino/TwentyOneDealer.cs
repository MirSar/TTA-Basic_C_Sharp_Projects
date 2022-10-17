using System;
using System.Collections.Generic;
using System.Text;

namespace Casino.TwentyOne
{
    // Inheriting from Dealer
    public class TwentyOneDealer : Dealer
    {
        // Properties
        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get{return _hand; } set{_hand=value;}}
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
