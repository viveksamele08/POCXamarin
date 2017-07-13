﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace MyDemoSP
{
    [Activity(Label = "BottomNavigationActivity", Theme = "@style/Theme.AppCompat.Light")]
    public class BottomNavigationActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_bottom_navigation);
            // Create your application here
        }
    }
}