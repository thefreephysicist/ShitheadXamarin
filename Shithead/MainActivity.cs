using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Views;
using static Android.Views.ViewGroup;
using Android.Content.Res;

namespace Shithead
{
    [Activity(Label = "Shithead", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            /*
            int screenWidth = Resources.DisplayMetrics.WidthPixels;
            int screenHeight = Resources.DisplayMetrics.HeightPixels;

            // say 10 cards on a screen horizontally
            int cardWidth = screenWidth / 10;
            int cardHeight = (int)(726.0 / 500.0 * cardWidth);

            ImageView view = (ImageView)FindViewById(Resource.Id.imageView1);
            LayoutParams viewParams = view.LayoutParameters;
            viewParams.Width = cardWidth;
            viewParams.Height = cardHeight;

            view.SetImageResource(Resource.Drawable.aceOfClubs);
            */
            /*
            ImageView view = (ImageView)FindViewById(Resource.Id.imageView1);
            LayoutParams viewParams = view.LayoutParameters;
            */
            HandView view = (HandView)FindViewById(Resource.Id.handView1);
            LayoutParams viewParams = view.LayoutParameters;
            System.Diagnostics.Debug.WriteLine(viewParams.Width);
            System.Diagnostics.Debug.WriteLine(viewParams.Height);
            Button startGame = FindViewById<Button>(Resource.Id.button1);

            startGame.Click += StartGame_Click;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            var gameActivity = new Intent(this, typeof(GameActivity));
            gameActivity.PutExtra("MyData", "Data from Activity1");
            StartActivity(gameActivity);
        }
    }
}

