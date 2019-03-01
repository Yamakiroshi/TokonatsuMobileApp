using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace TokonatsuApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tokonatsu.org.uk")));
        }

        public ICommand OpenWebCommand { get; }
    }
}