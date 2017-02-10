using ToastMessage.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Toast_iOS))]
namespace ToastMessage.iOS
{
    public class Toast_iOS : Toast
    {
        public void Show(string message)
        {
            ToastIOS.Toast.MakeText(message).Show();
        }
    }
}