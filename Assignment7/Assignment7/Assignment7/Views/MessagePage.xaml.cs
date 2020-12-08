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
    public partial class MessagePage : ContentPage
    {
        public MessagePage()
        {
            InitializeComponent();
        }

        private void Entry_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            string none = string.Empty;

            if (box.Text != null && box.Text != none )
            {
                record.IsEnabled = false;
                record.IsVisible = false;
                enter.IsEnabled = true;
                enter.IsVisible = true;
            }
            else
            {
                record.IsEnabled = true;
                record.IsVisible = true;
                enter.IsEnabled = false;
                enter.IsVisible = false;
            }
        }
    }
}