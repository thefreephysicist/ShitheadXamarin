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
    public class ShitheadModel : IShitheadModel
    {
        private int _numOfCards = 3;

        public ShitheadModel()
        {
        }

        public Deck Deck
        {
            get;
            set;
        }

        public List<ShitHand> Hands
        {
            get;
            set;
        }

        public Pile Pile
        {
            get;
            set;
        }
    }
}