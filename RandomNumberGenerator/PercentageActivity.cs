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

namespace RandomNumberGenerator
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "PercentageActivity")]
    public class PercentageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "percentage" layout resource
            SetContentView(Resource.Layout.PercentageLayout);

            // Get our button from the layout resource,
            // and attach an event to it
            Button randomPercentageButton = FindViewById<Button>(Resource.Id.bGenerateRandomPercentage);
            TextView randomPercentageResult = FindViewById<TextView>(Resource.Id.tRandomPercentageResult);

            randomPercentageButton.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                //generate a a random percentage
                Random r = new Random();
                int random_number = r.Next(1, 100);

                randomPercentageResult.Text = (random_number) + "%";
            };
        }
    }
}