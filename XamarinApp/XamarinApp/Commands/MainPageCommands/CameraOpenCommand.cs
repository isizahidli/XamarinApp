using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.ViewModel.MainPage;
using Xamarin.Essentials;
using static Xamarin.Essentials.Permissions;
using Xamarin.Forms;
using XamarinApp.DpIntefaces;

namespace XamarinApp.Commands.MainPageCommands
{
    public class CameraOpenCommand : BaseCommand<MainPageViewModel>
    {
        public CameraOpenCommand(MainPageViewModel viewModel) : base(viewModel) { }
        public override async void Execute(object parameter)
        {
            //var status = await CheckStatusAsync<Camera>();

            //if (status == PermissionStatus.Granted)
            //{
            //    DependencyService.Get<IOpenCameraAndriod>().OpenCamera();
            //}
            //else
            //{
            //    await RequestAsync<Camera>();
            //}

            DependencyService.Get<IOpenCameraAndriod>().OpenCamera();
        }
    }
}
