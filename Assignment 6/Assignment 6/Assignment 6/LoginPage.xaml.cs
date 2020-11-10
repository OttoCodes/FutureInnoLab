using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Banking;

namespace Assignment_6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class LoginPage : ContentPage
{
        Bank fnb;

        public LoginPage()
    {
        InitializeComponent();
            fnb = new Bank("First National Bank", 4324, "Kenilworth");

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var customer = (Customer)BindingContext;


            await App.Database.SaveNoteAsync(customer);



            await Navigation.PushAsync(new MainPage());
            
        }
    }
}