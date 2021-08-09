using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinApp.ViewModel.LoginPage;
using XamarinApp.ViewModel.MainPage;
using XamarinApp.Views.MainPages;

namespace XamarinApp.Commands.LoginPageCommands
{
    public class LoginCommand : BaseCommand<LoginPageViewModel>
    {
        public LoginCommand(LoginPageViewModel viewModel) : base(viewModel) { }
        public override void Execute(object parameter)
        {
            if(viewModel.Login.Username == "1" && viewModel.Login.Password == "1")
            {
                MainPage mainPage = new MainPage();
                MainPageViewModel mainPageViewModel = new MainPageViewModel();
                mainPage.BindingContext = mainPageViewModel;
                mainPageViewModel.View = mainPage;

                viewModel.View.Navigation.PushAsync(mainPage);
                
            }
        }
    }
}
