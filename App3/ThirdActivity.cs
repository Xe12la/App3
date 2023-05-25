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
    [Activity(Label = "ThirdActivity")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ThirdActivity);

            Button next3 = FindViewById<Button>(Resource.Id.btnMENext);
            next3.Click += Next3_Click;

            // Create your application here
        }

        private void Next3_Click(object sender, EventArgs e)
        {

            AlertDialog.Builder alertnext3 = new AlertDialog.Builder(this);
            alertnext3.SetTitle("Next");
            alertnext3.SetMessage("Do you want to start the tour?");
            alertnext3.SetIcon(Resource.Drawable.alert);
            alertnext3.SetPositiveButton("Ok", delegate
            {
                var a = new Intent(this, typeof(FourthActivity));
                StartActivity(a);
            });
            alertnext3.SetNegativeButton("Cancel", delegate
            {
                Toast.MakeText(this, "You have cancelled the action", ToastLength.Long).Show();
            });
            Dialog diag = alertnext3.Create();
            diag.Show();
        }
    }
}