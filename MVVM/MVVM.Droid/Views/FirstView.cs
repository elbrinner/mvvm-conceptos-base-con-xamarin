using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MVVM.Droid.Views
{
    [Activity(Label = "Login")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
