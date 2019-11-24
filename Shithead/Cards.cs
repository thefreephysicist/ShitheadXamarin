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
    public class Cards
    {

        private List<Card> _cards;

        /// <summary>
        /// Gets or sets the  cards collection
        /// </summary>
        protected List<Card> CardsCollection
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cards"/> class.
        /// </summary>
        public Cards()
        {
            CardsCollection = new List<Card>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cards"/> class.
        /// </summary>
        /// <param name="size"></param>
        public Cards(int size)
        {
            CardsCollection = new List<Card>(size);
        }

        /// <summary>
        /// Shuffle the cards
        /// </summary>
        public void ShuffleCards()
        {
            if (CardsCollection != null)
            {
                CardsCollection.Shuffle();
            }
        }

        /// <summary>
        /// Add card to cards
        /// </summary>
        /// <param name="card">A card</param>
        public void AddCard(Card card)
        {
            CardsCollection.Add(card);
        }

        /// <summary>
        /// Remove card from cards
        /// </summary>
        /// <param name="card">A card</param>
        public bool RemoveCard(Card card)
        {
            if (CardsCollection.Count > 0)
            {
                CardsCollection.Remove(card);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove card from cards by index
        /// </summary>
        /// <param name="index">The index</param>
        public void RemoveCard(int index)
        {
            CardsCollection.RemoveAt(index);
        }

        /// <summary>
        /// Clear the cards
        /// </summary>
        public void Clear()
        {
            CardsCollection.Clear();
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (Card card in CardsCollection)
            {
                str += card + "\n";
            }
            return str;
        }
    }
}