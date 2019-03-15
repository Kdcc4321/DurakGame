using Ch10CardLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    public class Cards : CollectionBase
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }

        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        /*
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
        
        
    }*/
    }
}
