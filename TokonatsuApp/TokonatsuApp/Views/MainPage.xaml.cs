using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using TokonatsuApp.ViewModels;

namespace TokonatsuApp.Views
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        
        public MainPage()
        {
            On<Android>()
                .SetToolbarPlacement(ToolbarPlacement.Bottom)
                .SetBarItemColor(Color.FromHex("#FFB144"))
                .SetBarSelectedItemColor(Color.ForestGreen);
            InitializeComponent();
        }
    }
}