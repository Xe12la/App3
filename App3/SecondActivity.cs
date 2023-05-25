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
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SecondActivity1);

            Button next = FindViewById<Button>(Resource.Id.btnFamBack);
            next.Click += Next_Click;

            // Create your application here
        }

        private void Next_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alertnext2 = new AlertDialog.Builder(this);
            alertnext2.SetTitle("Next!");
            alertnext2.SetMessage("Do you want to start the tour?");
            alertnext2.SetIcon(Resource.Drawable.alert);
            alertnext2.SetPositiveButton("Ok", delegate
            {
                var a = new Intent(this, typeof(ThirdActivity));
                StartActivity(a);
            });
            alertnext2.SetNegativeButton("Cancel", delegate
            {
                Toast.MakeText(this, "You have cancelled the action", ToastLength.Long).Show();
            });
            Dialog diag = alertnext2.Create();
            diag.Show();
        }
    }
}