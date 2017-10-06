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
    public class Card
    {

        public Card(Number number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }

        public Number Number
        {
            get;
            set;
        }

        public Suit Suit
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Number.ToString() + " of " + Suit.ToString();
        }

    }
}