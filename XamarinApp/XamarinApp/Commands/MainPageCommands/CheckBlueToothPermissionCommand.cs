using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using XamarinApp.ViewModel.MainPage;
using XamarinApp.Views.MainPages;

namespace XamarinApp.Commands.MainPageCommands
{
    public class CheckBlueToothPermissionCommand : BaseCommand<MainPageViewModel>
    {
        public CheckBlueToothPermissionCommand(MainPageViewModel viewModel): base(viewModel) { }
        public override async void Execute(object parameter)
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status == PermissionStatus.Granted)
            {
                viewModel.View.ShowLocationAlert();
            }
            else
            {
                await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }
        }
    }
}
