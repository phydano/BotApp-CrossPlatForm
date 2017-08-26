using Xamarin.Forms;

namespace ChatBotApp
{
    public partial class App : Application
    {
        public App()
        {
            this.MainPage = new MainPage { Title = "ContosoBot" };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
