using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    public class Cards 
    {
        public readonly CardSuits suit;
        public readonly CardRanks rank;

        public static bool useTrumps = false; // Flag for trump usage. If true, trumps are valued higher than cards of other suits.
        public static CardSuits trump = CardSuits.Club; // Trump suit to use if useTrumps is true.
        public static bool isAceHigh = true;  // Flag that determines whether aces are higher than kings or lower than two

        // Parameterized Constructor Using the CardSuits & CardRank Enumerators
        public Cards(CardSuits newSuit, CardRanks newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        // Default Constructor
        private Cards()
        {
        }

        public CardRanks Rank()
        {
             return rank;
        }

        public CardSuits Suit()
        {
            return suit;
        }

        //ToString Overide
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        // Method Overloads
        public static bool operator ==(Cards card1, Cards card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        public static bool operator !=(Cards card1, Cards card2)
        {
            return !(card1 == card2);
        }
        public override bool Equals(object card)
        {
            return this == (Cards)card;
        }
        
        public static bool operator >(Cards card1, Cards card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanks.Ace)
                    {
                        if (card2.rank == CardRanks.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanks.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Cards.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Cards card1, Cards card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Cards card1, Cards card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == CardRanks.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == CardRanks.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Cards.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Cards card1, Cards card2)
        {
            return !(card1 > card2);
        }

        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }
        
        
    }
}
