using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using static Android.Views.ViewGroup;

namespace Shithead
{
    public class PlayingCardView : ImageView
    {

        private static int _screenWidth;
        private static int _screenHeight;

        static PlayingCardView()
        {

        }

        public PlayingCardView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public PlayingCardView(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
            SetImageResource(Resource.Drawable.aceOfClubs);
        }
    }
}