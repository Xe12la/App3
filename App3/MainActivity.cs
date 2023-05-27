using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using AlertDialog = Android.App.AlertDialog;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button start_s = FindViewById<Button>(Resource.Id.Open);
            start_s.Click += Start_Click;
        }


        private void Start_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder alertStart = new AlertDialog.Builder(this);
            alertStart.SetTitle("Confirmation!");
            alertStart.SetMessage("Do you want to start the tour?");
            alertStart.SetIcon(Resource.Drawable.alert);
            alertStart.SetPositiveButton("Ok", delegate
            {
                var a  = new Intent(this, typeof(SecondActivity));
                StartActivity(a);
            });
            alertStart.SetNegativeButton("Cancel", delegate
            {
                Toast.MakeText(this, "You have cancelled the action", ToastLength.Long).Show();
            });
            Dialog diag = alertStart.Create();
            diag.Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}