using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.Commands.LoginPageCommands;
using XamarinApp.Models;
using XamarinApp.Views.Login;

namespace XamarinApp.ViewModel.LoginPage
{
    public class LoginPageViewModel
    {
        public Views.Login.LoginPage View { get; set; } = new Views.Login.LoginPage(); 

        #region Models
            public LoginModel Login { get; set; } = new LoginModel();
        #endregion

        #region Command
        public LoginCommand LoginCommand => new LoginCommand(this);
        #endregion
    }
}
