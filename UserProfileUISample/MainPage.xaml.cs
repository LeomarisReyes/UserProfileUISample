using System;
using System.ComponentModel;

namespace UserProfileUISample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PhoneClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Contact", "Phone clicked!", "OK");
        }

        private async void MailClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Contact", "Mail clicked!", "OK");
        }

        private async void FollowClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Follow", "Follow clicked!", "OK");
        }
    }
}
