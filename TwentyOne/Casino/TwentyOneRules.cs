using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; // Needed for Lambda expressions

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        // Dictionary of Card values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            // Instantiate with all of our objects (dictionary entries)
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            // Ace will need additional logic to choose values of 1 or 11
            [Face.Ace] = 1,
        };

        // Method: Get all possible hand values
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // The Ace card has 2 values
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // Ace options are 1,1(2) or 11,11(22)or 1,11(12)
            int[] result = new int[aceCount + 1];
            // The lowest possible value (1+1)
            int value = Hand.Sum(x => _cardValues[x.Face]);
            // Take the first entry and set value to it
            result[0] = value;

            // For all other cards have one value
            if (result.Length == 1) // No Ace Card
            {
                return result;
            }
            // Iterate through putting diff values with ACE
            // Note i=0 is addressed above
            for (int i = 1; i < result.Length; i++)
            {
                // Note that Value = 1 (lowest value) 
                value += (i * 10); // other value of one Ace = 11, if 2 Aces then we add 20
                result[i] = value;
            }
            return result;
        }

        // Method: Check for BlackJack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            // Create an int array of possible values
            int[] possibleValues = GetAllPossibleHandValues(Hand);          
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        // Method: Check if player busted
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        // Method: Should the dealer stay?
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value >16 && value < 21)
                {
                    return true;
                }
            }
            return false;
        }

        // Method: Compare hands...returns a nullable bool
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            // Get the max value of the cards that is less than 22
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
