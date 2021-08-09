using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinApp.Droid.Adds
{
    public class StatusBarSettings
    {
        public void SetStatusBarColor()
        {
            CrossCurrentActivity.Current.Activity.Window.SetStatusBarColor(Color.Red);
        }
    }
}