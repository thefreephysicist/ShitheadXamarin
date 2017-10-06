using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Shithead
{
    public class Deck : Cards
    {
        private const int _defaultCardCount = 52;

        private Deck() : base()
        {
        }

        public Deck(int size) : base(size)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Number number in Enum.GetValues(typeof(Number)))
                {
                    AddCard(new Card(number, suit));
                }
            }
        }

        public Card PeekTopCard()
        {
            if (CardsCollection.Count > 0)
            {
                return CardsCollection[0];
            }
            else
            {
                return null;
            }
        }

        public Card PeekBottomCard()
        {
            return CardsCollection[CardsCollection.Count];
        }

        public bool RemoveCardFromTop()
        {
            if (CardsCollection.Count > 0)
            {
                CardsCollection.RemoveAt(0);
                return true;
            }
            return false;
        }
    }
}