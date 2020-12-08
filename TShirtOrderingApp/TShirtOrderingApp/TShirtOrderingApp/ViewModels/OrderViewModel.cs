using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TShirtOrderingApp
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private OrderDatabase _orderDatabase;

        

        private string name;
        public string Name 
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string color;
        public string Color 
        {
            get { return color; }
            set { color = value;
                NotifyPropertyChanged("Color");
            } 
        }

        private string size;
        public string Size 
        {
            get { return size; }
            set
            {
                size = value;
                NotifyPropertyChanged("Size");
            }
        }

        private string address;
        public string Address 
        {
            get { return address; }
            set
            {
                address = value;
                NotifyPropertyChanged("Address");
            }
        }

        private string gender;
        public string Gender 
        {
            get { return gender; }
            set
            {
                gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        public ICommand SaveButtonCommand { get; set; }
        private INavigation _navigation;

        public OrderViewModel()
        {
            
        }

        public OrderViewModel(INavigation navigation)
        {
            _orderDatabase = new OrderDatabase();
            SaveButtonCommand = new Command(() => SaveButton());
            _navigation = navigation;
          
        }

        public async void SaveButton()
        {
            _orderDatabase.AddUser(Name,Color,Size,Address,Gender);
           
            await _navigation.PopAsync();

        }
      
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
