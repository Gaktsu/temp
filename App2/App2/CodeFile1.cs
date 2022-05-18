using Xamarin.Forms;
namespace App2
{
    public class CodeFile1 : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public CodeFile1()
        {
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new App2.MainPage());
            }
        }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}