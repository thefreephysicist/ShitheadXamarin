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
    public class HandView : View
    {
        public HandView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize(context);
            LinearLayout linearLayout = new LinearLayout(context);
            linearLayout.Orientation = Orientation.Vertical;
            this.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            linearLayout.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            Button btn = new Button(context);
            // btn.SetText("hiya");
            btn.LayoutParameters = new LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);

            PlayingCardView playingCard = new PlayingCardView(context, attrs);

            int _screenWidth = Resources.DisplayMetrics.WidthPixels;
            int _screenHeight = Resources.DisplayMetrics.HeightPixels;

            // say 10 cards on a screen horizontally
            int cardWidth = _screenWidth / 10;
            int cardHeight = (int)(726.0 / 500.0 * cardWidth);

            playingCard.LayoutParameters = new LayoutParams(cardWidth, cardHeight);
            linearLayout.AddView(playingCard);
            linearLayout.AddView(btn);
        }

        public HandView(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize(context);
        }

        private void Initialize(Context context)
        {
            // rootView = Inflate(context, Resource.Layout.HandView, this);
        }

        private void Initialize()
        {
            
        }
    }
}