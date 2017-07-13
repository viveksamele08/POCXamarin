using System;
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
    [Activity(Label = "LoginActivity", Theme = "@style/FullscreenTheme", Icon = "@drawable/icon")]
    public class LoginActivity : AppCompatActivity
    {
        private Button _loginButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            _loginButton = FindViewById<Button>(Resource.Id.email_sign_in_button);
            _loginButton.Click += LoginBtn_OnClick;
        }
        private void LoginBtn_OnClick(object sender, EventArgs e)
        {
            EditText userName = FindViewById<EditText>(Resource.Id.email);
            EditText passWord = FindViewById<EditText>(Resource.Id.password);
            if ((("Demo").Equals(userName.Text.Trim())) && (("Demo").Equals(passWord.Text.Trim())))
            {
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
                Finish();
            }
        }
       
    }
}