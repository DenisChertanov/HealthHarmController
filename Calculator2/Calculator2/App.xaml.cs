using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Realms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Calculator2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            try
            {
                Sigarets sigarets = new Sigarets();
                NavigationPage.SetHasNavigationBar(sigarets, false);
                MainPage = new NavigationPage(sigarets)
                {
                    BarBackgroundColor = Color.FromHex("#B00020")
                };
            }
            catch
            {
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                Realm _realm = Realm.GetInstance(config);
                _realm.Write(() => _realm.RemoveAll());

                ExceptionPage exceptionPage = new ExceptionPage();
                MainPage = new NavigationPage(exceptionPage)
                {
                    BarBackgroundColor = Color.FromHex("#B00020")
                };
            }

            //MainPage = new NavigationPage(new SplashPage());
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
