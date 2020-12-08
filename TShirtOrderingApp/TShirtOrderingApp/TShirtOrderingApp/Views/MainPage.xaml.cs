using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TShirtOrderingApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new OrderListViewModel(Navigation);
       

        } 
    }
}
