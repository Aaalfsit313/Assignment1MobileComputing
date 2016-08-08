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
    [Activity(Theme = "@style/Theme.NoTitle", Label = "NumberActivity")]
    public class NumberActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.NumberLayout);

            // Get our button from the layout resource,
            // and attach an event to it
            Button randomNumberButton = FindViewById<Button>(Resource.Id.bGenerateRandomNumber);
            TextView randomNumberResult = FindViewById<TextView>(Resource.Id.tRandomNumberResult);

            randomNumberButton.Click += delegate
            {
                //get the starting number and ending number
                EditText startEditText = FindViewById<EditText>(Resource.Id.tStartingNumber);
                EditText endEditText = FindViewById<EditText>(Resource.Id.tEndingNumber);

                String startString = startEditText.Text;
                String endString = endEditText.Text;

                int startInt = 0;
                int endInt = 0;

                Boolean is_start_number = Int32.TryParse(startString, out startInt);
                Boolean is_end_number = Int32.TryParse(endString, out endInt);

                if(is_start_number==false)
                {
                    startEditText.Text = "NaN";
                }
                else if(is_end_number==false)
                {
                    endEditText.Text = "NaN";
                }
                else if(startInt>endInt)
                {
                    startEditText.Text = "Start < End";
                }
                else
                { 
                    //button.Text = string.Format("{0} clicks!", count++);
                    //generate a a random percentage
                    Random r = new Random();
                    int random_number = r.Next(startInt, endInt);

                    randomNumberResult.Text = (random_number+"");
                }
            };
        }
    }
}