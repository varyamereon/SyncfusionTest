using Xamarin.Forms;

namespace SyncfusionTest
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NjhAMzEzNjJlMzQyZTMwWXJKMlVOYlRpNmJxdVJaZHZueTZ0Z01DTG9Qam1Ydk1xMnhmRlNpdUUxRT0=");

            InitializeComponent();

            MainPage = new MainPage();
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
