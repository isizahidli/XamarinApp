using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views.MainPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ShowLocationAlert()
        {
            DisplayAlert("Info", "Location activated!", "OK");
        }

        private void ButtonMapClicked(object sender, EventArgs e)
        {
            
        }
    }
}