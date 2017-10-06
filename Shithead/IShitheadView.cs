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
    public interface IShitheadView
    {
        IShitheadPresenter Presenter
        {
            get;
            set;
        }

        void ShowHands();

        void ShowDeck();

        void ShowInConsole(string str);

        void GiveInstruction(string str);

        void WaitForResponse();
    }
}