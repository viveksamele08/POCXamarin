using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyDemoSP
{
    public class NotificatrionsFragment : Fragment, View.IOnClickListener
    {
        ImageView refresh;

        public void OnClick(View view)
        {
            switch (view.Id)
            {
                case Resource.Id.refresh:
                    Toast.MakeText(this.Activity, "Refreshing.....", ToastLength.Short).Show();
                    break;
               
            }
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_notificatrions, container, false);
            refresh = view.FindViewById<ImageView>(Resource.Id.refresh);
            return view;
        }
    }
}