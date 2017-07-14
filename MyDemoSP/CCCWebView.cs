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
    [Activity(Label = "Singapore Polytechnic", Theme = "@style/AppTheme")]
    public class CCCWebView : AppCompatActivity
    {
        WebView webview;
        private ProgressBar mProgressBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_cccweb_view);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
          //  toolbar.SetTitleTextColor(Android.Graphics.Color.White);
            SetSupportActionBar(toolbar);


            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            mProgressBar = FindViewById<ProgressBar>(Resource.Id.pb);
            mProgressBar.Visibility = (ViewStates.Visible);
            webview = FindViewById<WebView>(Resource.Id.webView);
            webview.SetWebViewClient(new MyBrowser());
            webview.Settings.JavaScriptEnabled = (true);
            if (!string.IsNullOrEmpty(Intent.GetStringExtra("key")) && Intent.GetStringExtra("key").Equals("library"))
            {
                webview.LoadUrl("https://sso.sp.edu.sg/login");
            }
            else if (!string.IsNullOrEmpty(Intent.GetStringExtra("key")) && Intent.GetStringExtra("key").Contains("livecam"))
            {
                webview.LoadUrl("http://www.sp.edu.sg/wps/portal/vp-spws/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOJDPUxdjdxMTQz8Q7xMDTz9g10tnVwDjJydDPULsh0VAaQI1v8!/?WCM_GLOBAL_CONTEXT=");
            }
            else
            {
                if (!string.IsNullOrEmpty(Intent.GetStringExtra("key")))
                {
                    webview.LoadUrl(Intent.GetStringExtra("key").ToString().Trim());
                }
            }

            //    webview.SetWebChromeClient(new WebChromeClient()
            //    {
            //       void onProgressChanged(WebView view, int newProgress)
            //    {
            //        //Make the bar disappear after URL is loaded, and changes string to Loading...
            //        mProgressBar.SetProgress(newProgress,true);
            //        if (newProgress == 100)
            //        {
            //            // Hide the progressbar
            //            mProgressBar.Visibility=(ViewStates.Gone);
            //        }
            //    }
            //});


        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            //noinspection SimplifiableIfStatement
            if (id == Android.Resource.Id.Home)
            {
                Finish();
            }

            return base.OnOptionsItemSelected(item);
        }

        class MyBrowser : WebViewClient
        {

            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);

                return true;
            }




        }
    }
}