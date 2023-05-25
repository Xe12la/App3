using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App3
{
    [Activity(Label = "FourthActivity")]
    public class FourthActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FourthActivity);

            Button next3 = FindViewById<Button>(Resource.Id.btnHpage);
            next3.Click += Next3_Click;

            // Create your application here
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alerthome = new AlertDialog.Builder(this);
            alerthome.SetTitle("Next");
            alerthome.SetMessage("Thanks! will you proceed to home page?");
            alerthome.SetIcon(Resource.Drawable.alert);
            alerthome.SetPositiveButton("Ok", delegate
            {
                var a = new Intent(this, typeof(MainActivity));
                StartActivity(a);
            });
            alerthome.SetNegativeButton("Cancel", delegate
            {
                Toast.MakeText(this, "You have cancelled the action", ToastLength.Long).Show();
            });
            Dialog diag = alerthome.Create();
            diag.Show();
        }
    }
}