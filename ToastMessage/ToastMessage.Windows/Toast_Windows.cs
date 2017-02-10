using ToastMessage.Windows;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Xamarin.Forms;

[assembly: Dependency(typeof(Toast_Windows))]
namespace ToastMessage.Windows
{
    class Toast_Windows : Toast
    {
        public void Show(string message)
        {
            ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText01;
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);
            XmlNodeList toastTextElements = toastXml.GetElementsByTagName("text");
            toastTextElements[0].AppendChild(toastXml.CreateTextNode(message));
            XmlNodeList toastImageAttributes = toastXml.GetElementsByTagName("image");
            ((XmlElement)toastImageAttributes[0]).SetAttribute("src", "ms-appx:///Assets/Logo.scale-240.png");
            ((XmlElement)toastImageAttributes[0]).SetAttribute("alt", "logo");
            IXmlNode toastNode = toastXml.SelectSingleNode("/toast");
            ((XmlElement)toastNode).SetAttribute("duration", "short");
            var toastElement = ((XmlElement)toastXml.SelectSingleNode("/toast"));
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
