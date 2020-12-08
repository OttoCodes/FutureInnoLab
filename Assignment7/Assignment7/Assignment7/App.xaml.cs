using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment7.Views;

namespace Assignment7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Starter());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
