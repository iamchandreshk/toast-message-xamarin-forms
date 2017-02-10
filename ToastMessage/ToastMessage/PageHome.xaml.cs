using System;

using Xamarin.Forms;

namespace ToastMessage
{
    public partial class PageHome : ContentPage
    {
        public PageHome()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ButtonToast.Clicked += ButtonToast_Clicked;
        }

        private void ButtonToast_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("Toast Message");
        }
    }
}
