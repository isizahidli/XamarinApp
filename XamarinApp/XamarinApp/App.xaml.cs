using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.ViewModel.LoginPage;
using XamarinApp.Views.Login;

namespace XamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();


            LoginPage loginPage = new LoginPage();
            LoginPageViewModel viewModel = new LoginPageViewModel();
            viewModel.View = loginPage;
            loginPage.BindingContext = viewModel;

            NavigationPage nvPage = new NavigationPage(loginPage);

            MainPage = nvPage;

            DependencyService.Get<IStartService>().StartForegroundServiceCompat();
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
