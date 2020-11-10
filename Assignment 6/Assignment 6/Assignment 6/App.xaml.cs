using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment_6.Data;
using System.IO;

namespace Assignment_6
{
    public partial class App : Application
    {
        static CustomerDataBase database;

        public static CustomerDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CustomerDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Customers.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

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
