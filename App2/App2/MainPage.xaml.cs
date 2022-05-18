using System;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            CodeFile1.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}
