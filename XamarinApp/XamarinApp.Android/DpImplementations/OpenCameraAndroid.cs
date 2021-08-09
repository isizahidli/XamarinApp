using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinApp.DpIntefaces;

[assembly: Dependency(typeof(XamarinApp.Droid.DpImplementations.OpenCameraAndroid))]
namespace XamarinApp.Droid.DpImplementations
{
    public class OpenCameraAndroid : IOpenCameraAndriod
    {
        [Obsolete]
        public void OpenCamera()
        {
            //Camera cam = null;
            //var cameraInfo = new Camera.CameraInfo();

            //for (int i = 0; i < Camera.NumberOfCameras; i++)
            //{
            //    Camera.GetCameraInfo(i, cameraInfo);

            //    if (cameraInfo.Facing == CameraFacing.Front)
            //        cam = Camera.Open(i);
            //}

            Forms.Context.StartActivity(new Intent(Android.Provider.Contacts.Authority));
        }
    }
}