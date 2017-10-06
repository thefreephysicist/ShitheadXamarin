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

        public void AddToBottom(Card card)
        {
            CardsCollection.Insert(0, card);
        }

        public void AddToTop(Card card)
        {
            AddCard(card);
        }

    }
}