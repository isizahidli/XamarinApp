using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.Commands.MainPageCommands;
using Mp = XamarinApp.Views.MainPages;

namespace XamarinApp.ViewModel.MainPage
{
    public class MainPageViewModel
    {
        public Mp.MainPage View { get; set; } = new Mp.MainPage();

        #region Commands
        public CheckBlueToothPermissionCommand CheckBlueTooth => new CheckBlueToothPermissionCommand(this);
        public CameraOpenCommand OpenCamera => new CameraOpenCommand(this);

        public CreateGridFromListCommand CreateList => new CreateGridFromListCommand(this);
        #endregion
    }
}
