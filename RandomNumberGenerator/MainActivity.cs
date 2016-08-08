using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RandomNumberGenerator
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "RandomNumberGenerator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button randomNumberButton = FindViewById<Button>(Resource.Id.RandomNumberButton);
            Button randomPercentageButton = FindViewById<Button>(Resource.Id.RandomPercentageButton);
            Button randomPhoneNumberButton = FindViewById<Button>(Resource.Id.RandomPhoneNumberButton);

            randomNumberButton.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                StartActivity(typeof(NumberActivity));
            };

            randomPercentageButton.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                StartActivity(typeof(PercentageActivity));
            };

            randomPhoneNumberButton.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                StartActivity(typeof(PhoneNumberActivity));
            };
        }
    }
}

