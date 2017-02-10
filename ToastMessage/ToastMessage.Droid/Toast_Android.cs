using Xamarin.Forms;
using Android.Widget;
using ToastMessage.Droid;

[assembly: Dependency(typeof(Toast_Android))]
namespace ToastMessage.Droid
{
    public class Toast_Android : Toast
    {
        public void Show(string Message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, Message, ToastLength.Long).Show();
        }
    }
}