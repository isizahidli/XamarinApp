using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Service.Controls;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.Droid;

[assembly: ExportRenderer(typeof(Entry), typeof(MyRenderer))]
namespace XamarinApp.Droid
{
    [Obsolete]
    public class MyRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Violet);
        }
    }
}