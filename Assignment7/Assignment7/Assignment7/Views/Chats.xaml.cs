using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chats : ContentPage
    {
        
        public Chats()
        {
            InitializeComponent();
        }

        async void Contact_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MessagePage());
        }
    }
}