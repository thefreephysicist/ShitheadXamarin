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
    public class ShitHand
    {
        Hand _inHand;
        Hand _faceDown;
        Hand _faceUp;

        private const int _cardCount = 3;

        private ShitHand()
        {
        }

        public ShitHand(int cardCount, Deck deck, Pile pile)
        {
            _inHand = new Hand(cardCount, deck, pile);
            _faceUp = new Hand(cardCount, deck, pile);
            _faceDown = new Hand(cardCount, deck, pile);
        }

        public override string ToString()
        {
            string str = string.Empty;
            str += "In hand:\n";
            str += _inHand + "\n";
            str += "Face up:\n";
            str += _faceUp + "\n";
            str += "Face down:\n";
            str += _faceDown + "\n";
            return str;
        }
    }
}