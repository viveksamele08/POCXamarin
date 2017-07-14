using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Gms.Common;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Views;
using System;
using Android.Support.V4.View;
using Android.Content;

namespace MyDemoSP
{
    [Activity(Label = "Singapore Polytechnic", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener, View.IOnClickListener
    {
        private TextView home, feedback, faq, aboutSp;
        private ImageView close, sign_out;
        private DrawerLayout drawer;
        private FloatingActionButton fab;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //toolbar.setTitleTextColor(0xFFFFFFFF);
            SetSupportActionBar(toolbar);


            drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            home = FindViewById<TextView>(Resource.Id.home);
            faq = FindViewById<TextView>(Resource.Id.faq);
            feedback = FindViewById<TextView>(Resource.Id.feedback);
            aboutSp = FindViewById<TextView>(Resource.Id.aboutSP);
            fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            sign_out = FindViewById<ImageView>(Resource.Id.sign_out);
            close = FindViewById<ImageView>(Resource.Id.close);

            home.SetOnClickListener(this);
            faq.SetOnClickListener(this);
            feedback.SetOnClickListener(this);
            aboutSp.SetOnClickListener(this);


            BottomNavigationView bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            bottomNavigationView.SetOnNavigationItemSelectedListener(this);
            IsPlayServicesAvailable();
            bottomNavigationView.SelectedItemId=(Resource.Id.navigation_home);


            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.SetDrawerListener(toggle);
            toggle.SyncState();
            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);




            close.Click += (o, e) =>
            {
                if (drawer.IsDrawerOpen(GravityCompat.Start))
                {
                    drawer.CloseDrawer(GravityCompat.Start);
                }
            };

            sign_out.Click += (o, e) =>
            {
                Intent intent = new Intent(this, typeof(LoginActivity));
                intent.AddFlags(ActivityFlags.NewTask);
                intent.AddFlags(ActivityFlags.ClearTask);
                StartActivity(intent);
            };


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

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    fab.SetVisibility(ViewStates.Visible);
                    SupportFragmentManager.BeginTransaction().Add(Resource.Id.content, new HomeFragment(), "Home").Commit();
                    return true;
                case Resource.Id.navigation_dashboard:
                    fab.SetVisibility(ViewStates.Gone);
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.content, new DashboardFragment(), "Dash").Commit();
                    return true;
                case Resource.Id.navigation_notifications:
                    fab.SetVisibility(ViewStates.Gone);
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.content, new NotificatrionsFragment(), "Notification").Commit();

                    return true;
            }
            return false;

        }

        public void OnClick(View view)
        {
            if (view.Id == Resource.Id.home)
            {
                home.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                feedback.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                faq.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                aboutSp.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                if (drawer.IsDrawerOpen(GravityCompat.Start))
                {
                    drawer.CloseDrawer(GravityCompat.Start);
                }
            }
            else if (view.Id == Resource.Id.feedback)
            {
                home.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                feedback.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                faq.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                aboutSp.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                if (drawer.IsDrawerOpen(GravityCompat.Start))
                {
                    drawer.CloseDrawer(GravityCompat.Start);
                }
            }
            else if (view.Id == Resource.Id.faq)
            {
                home.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                feedback.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                faq.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                aboutSp.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                if (drawer.IsDrawerOpen(GravityCompat.Start))
                {
                    drawer.CloseDrawer(GravityCompat.Start);
                }
            }
            else if (view.Id == Resource.Id.aboutSP)
            {
                home.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                feedback.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                faq.SetTypeface(null, Android.Graphics.TypefaceStyle.Normal);
                aboutSp.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                if (drawer.IsDrawerOpen(GravityCompat.Start))
                {
                    drawer.CloseDrawer(GravityCompat.Start);
                }
            }
        }

        public override void OnBackPressed()
        {
            

            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main, menu);
            return true;

        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // as you specify a parent activity in AndroidManifest.xml.
            int id = item.ItemId;

            //noinspection SimplifiableIfStatement
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

    }
}

