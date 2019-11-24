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
    public class Pile : Cards
    {
        public Pile() :  base()
        {
        }

        /// <summary>
        /// Adds a card to the bottom of the file
        /// </summary>
        /// <param name="card">The card</param>
        public void AddToBottom(Card card)
        {
            CardsCollection.Insert(0, card);
        }

        /// <summary>
        /// Adds a card to the top of the pile
        /// </summary>
        /// <param name="card"></param>
        public void AddToTop(Card card)
        {
            AddCard(card);
        }

    }
}