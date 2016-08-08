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
    [Activity(Theme = "@style/Theme.NoTitle", Label = "PhoneNumberActivity")]
    public class PhoneNumberActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "phone number" layout resource
            SetContentView(Resource.Layout.PhoneNumberLayout);

            // Get our button from the layout resource,
            // and attach an event to it
            Button randomPhoneNumbereButton = FindViewById<Button>(Resource.Id.bGenerateRandomPhoneNumber);
            TextView randomPhoneNumberResult = FindViewById<TextView>(Resource.Id.tRandomPhoneNumberResult);

            randomPhoneNumbereButton.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                //generate a a random percentage
                Random r = new Random();
                String random_phone_number = "";
                int random_number;

                for(int i=1;i<=4;i++)
                { 
                    random_number = r.Next(1, 9);
                    random_phone_number = random_phone_number + random_number;
                }

                random_phone_number = random_phone_number + " ";

                for (int i = 1; i <= 4; i++)
                {
                    random_number = r.Next(1, 9);
                    random_phone_number = random_phone_number + random_number;
                }

                randomPhoneNumberResult.Text = "(03) " + random_phone_number;
            };
        }
    }
}