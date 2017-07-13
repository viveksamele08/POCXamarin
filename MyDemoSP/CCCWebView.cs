using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;

using Android.Support.V7.App;
using Android.Webkit;
using Android.Support.V7.Widget;
using Android.Widget;

namespace MyDemoSP
{
    [Activity(Label = "CCCWebView", Theme = "@style/Theme.AppCompat.Light")]
    public class CCCWebView : AppCompatActivity
    {
        WebView webview;
        private ProgressBar mProgressBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_cccweb_view);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitleTextColor(Android.Graphics.Color.White);
            SetSupportActionBar(toolbar);
        }
    }
}