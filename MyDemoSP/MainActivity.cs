using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Gms.Common;
using System;
using Java.IO;
using Firebase.Messaging;

namespace MyDemoSP
{
    [Activity(Label = "MyDemoSP")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.activity_main);

        }

        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                    System.Console.WriteLine(GoogleApiAvailability.Instance.GetErrorString(resultCode));
                else
                {
                    System.Console.WriteLine("This device is not supported");

                    Finish();
                }
                return false;
            }
            else
            {
                System.Console.WriteLine("Google Play Services is available.");
                return true;
            }
        }
    }
}

