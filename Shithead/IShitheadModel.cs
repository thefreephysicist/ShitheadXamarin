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
    public interface IShitheadModel
    {
        Deck Deck
        {
            get;
            set;
        }

        List<ShitHand> Hands
        {
            get;
            set;
        }

        Pile Pile
        {
            get;
            set;
        }
    }
}