using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace App2
{
    public class SignUpPageCS : ContentPage
    {
        Entry usernameEntry, passwordEntry, emailEntry;
        Label messageLabel;

        public SignUpPageCS()
        {
            messageLabel = new Label();
            usernameEntry = new Entry
            {
                Placeholder = "username"
            };
            passwordEntry = new Entry
            {
                IsPassword = true
            };
            emailEntry = new Entry();
            var signUpButton = new Button
            {
                Text = "Sign Up"
            };
            signUpButton.Clicked += OnSignUpButtonClicked;

            Title = "Sign Up";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    new Label {Text = "Username" },
                    usernameEntry,
                    new Label {Text = "Password" },
                    passwordEntry,
                    new Label{Text = "Email address"},
                    emailEntry,
                    signUpButton,
                    messageLabel
                }
            };
        }
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new User()
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text,
                Email = emailEntry.Text
            };

            var signUpSucceeded = AreDetailsValid(user);
            if (signUpSucceeded)
            {
                var rootPage = Navigation.NavigationStack.FirstOrDefault();
                if(rootPage != null)
                {
                    CodeFile1.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainPageCS(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    messageLabel.Text = "Sign up failed";
                }
            }

            bool AreDetailsValid(User use)
            {
                return (!string.IsNullOrWhiteSpace(use.Username) && !string.IsNullOrWhiteSpace(use.Password) && !string.IsNullOrWhiteSpace(use.Email) && user.Email.Contains("@"));
            }
        }
    }
}
