using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

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
    }
}

