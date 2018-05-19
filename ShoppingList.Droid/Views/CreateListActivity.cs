using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace ShoppingList.Droid.Views
{
    [
        Activity(Label = "@string/activity_create_list", 
        Theme = "@style/AppTheme", 
        MainLauncher = true)
    ]
    public class CreateListActivity : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_create_list);
        }
    }
}

