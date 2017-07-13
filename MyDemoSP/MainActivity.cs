using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
<<<<<<< HEAD
using Android.Gms.Common;
using System;
using Java.IO;
using Firebase.Messaging;
=======
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Views;
using System;
>>>>>>> 06149a2e5d068ec0f69778bcc83d1411afc1d43f

namespace MyDemoSP
{
    [Activity(Label = "MyDemoSP", Theme = "@style/Theme.AppCompat.Light")]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private TextView home, feedback, faq, aboutSp;
        private ImageView close;
        private DrawerLayout drawer;
        private FloatingActionButton fab;

       
    protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.activity_main);
<<<<<<< HEAD

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
=======
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            drawer = FindViewById <DrawerLayout>(Resource.Id.drawer_layout);
            home = FindViewById <TextView>(Resource.Id.home);
            faq = FindViewById <TextView>(Resource.Id.faq);
            feedback = FindViewById <TextView>(Resource.Id.feedback);
            aboutSp = FindViewById <TextView>(Resource.Id.aboutSP);
            fab = FindViewById <FloatingActionButton>(Resource.Id.fab);

            toolbar.SetTitleTextColor(Android.Graphics.Color.White);
            SetSupportActionBar(toolbar);

            //home.setOnClickListener(this);
            //faq.setOnClickListener(this);
            //feedback.setOnClickListener(this);
            //aboutSp.setOnClickListener(this);

            BottomNavigationView navigation = FindViewById < BottomNavigationView>(Resource.Id.navigation);
            

            navigation.SetOnNavigationItemSelectedListener(this);
          


        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.getItemId())
            {
                case R.id.navigation_home:
                    fab.setVisibility(View.VISIBLE);
                    getSupportFragmentManager().beginTransaction().add(R.id.content, new HomeFragment(), "Home").commit();
                    return true;
                case R.id.navigation_dashboard:
                    fab.setVisibility(View.GONE);
                    getSupportFragmentManager().beginTransaction().replace(R.id.content, new DashboardFragment(), "Dash").commit();
                    return true;
                case R.id.navigation_notifications:
                    fab.setVisibility(View.GONE);
                    getSupportFragmentManager().beginTransaction().replace(R.id.content, new NotificatrionsFragment(), "Notification").commit();
                    return true;
            }
            return false;
>>>>>>> 06149a2e5d068ec0f69778bcc83d1411afc1d43f
        }
    }
}

