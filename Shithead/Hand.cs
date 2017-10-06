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
    public class Hand : Cards
    {
        Deck _deck;
        Pile _pile;
        int _cardCount = 1;

        protected Hand()
        {
        }

        private Hand(int cardCount) : base(cardCount)
        {
            _cardCount = cardCount;
        }

        private Hand(int cardCount, Deck deck) : base(cardCount)
        {
            _cardCount = cardCount;
            _deck = deck;
        }

        public Hand(int cardCount, Deck deck, Pile pile) : base(cardCount)
        {
            _cardCount = cardCount;
            _deck = deck;
            _pile = pile;

            PickUpCards(_cardCount);
        }

        public bool PickUpCards(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (!PickUpCard())
                {
                    return false;
                }
            }
            return true;
        }

        public bool DropCard(Card card)
        {
            if (RemoveCard(card))
            {
                return true;
            }
            return false;
        }

        public bool PickUpCard()
        {
            Card card = _deck.PeekTopCard();
            if (card == null)
            {
                return false;
            }

            _deck.RemoveCardFromTop();
            AddCard(card);
            return true;
        }
    }
}