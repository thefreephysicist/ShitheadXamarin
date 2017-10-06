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
    public interface IShitheadPresenter
    {
        IShitheadModel Model
        {
            get;
            set;
        }

        IShitheadView View
        {
            get;
            set;
        }

        List<ShitHand> Hands
        {
            get;
            set;
        }

        Deck Deck
        {
            get;
            set;
        }

        Pile Pile
        {
            get;
            set;
        }

        int NumberOfPlayers
        {
            get;
        }
    }
}