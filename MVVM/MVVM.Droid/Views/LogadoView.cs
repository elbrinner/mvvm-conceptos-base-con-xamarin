using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MVVM.Droid.Views
{
    [Activity(Label = "Logado")]
    public class LogadoView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.logadoView);
        }
    }
}
