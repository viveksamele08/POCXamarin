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
using Uri = Android.Net.Uri;

namespace MyDemoSP
{
    public class HomeFragment : Fragment, View.IOnClickListener
    {
        private TextView ccc;
        private TextView acad_calendar;
        private TextView exam_timetable;
        private TextView library;
        private TextView live_cam;
        private TextView feedback;
        private TextView wassup;
        private TextView exam_results;
        private TextView timetable;
        private TextView staff_directory;
        private TextView staff_calendar;
        private TextView staff_timetable;

        public void OnClick(View view)
        {
            switch (view.Id)
            {
                case Resource.Id.exam_results:
                    var intent = new Intent(this.Activity, typeof(CCCWebView));
                    StartActivity(intent);
                    break;
                case Resource.Id.library:
                    Uri uri = Uri.Parse("https://library.sp.edu.sg/");
                    var intent1 = new Intent(Intent.ActionView, uri);
                    StartActivity(intent1);
                    break;

                case Resource.Id.live_cam:
                    Intent intentCam = new Intent(this.Activity, typeof(CCCWebView));
                    intentCam.PutExtra("key", "livecam");
                    StartActivity(intentCam);
                    break;
            }
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            //return inflater.Inflate(Resource.Layout.home_fragment, container, false);
            View view = inflater.Inflate(Resource.Layout.home_fragment, container, false);

            ccc = view.FindViewById<TextView>(Resource.Id.ccc);
            acad_calendar = view.FindViewById<TextView>(Resource.Id.acad_calendar);
            exam_timetable = view.FindViewById<TextView>(Resource.Id.exam_timetable);
            library = view.FindViewById<TextView>(Resource.Id.library);
            live_cam = view.FindViewById<TextView>(Resource.Id.live_cam);
            feedback = view.FindViewById<TextView>(Resource.Id.feedback);
            wassup = view.FindViewById<TextView>(Resource.Id.wassup);
            exam_results = view.FindViewById<TextView>(Resource.Id.exam_results);
            timetable = view.FindViewById<TextView>(Resource.Id.time_table);
            staff_directory = view.FindViewById<TextView>(Resource.Id.staff_directory);
            staff_calendar = view.FindViewById<TextView>(Resource.Id.staff_calendar);
            staff_timetable = view.FindViewById<TextView>(Resource.Id.staff_timetable);

            ccc.SetOnClickListener(this);
            acad_calendar.SetOnClickListener(this);
            exam_timetable.SetOnClickListener(this);
            library.SetOnClickListener(this);
            live_cam.SetOnClickListener(this);
            feedback.SetOnClickListener(this);
            wassup.SetOnClickListener(this);
            exam_results.SetOnClickListener(this);
            timetable.SetOnClickListener(this);
            staff_directory.SetOnClickListener(this);
            staff_calendar.SetOnClickListener(this);
            staff_timetable.SetOnClickListener(this);

            return view;
        }
    }
}