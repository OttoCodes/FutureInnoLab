using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TShirtOrderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewOrder : ContentPage
    {
        public NewOrder()
        {
            InitializeComponent();

            BindingContext = new OrderViewModel(Navigation);

        }
    }
}