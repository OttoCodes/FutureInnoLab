using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TShirtOrderingApp
{
    public class OrderListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private OrderDatabase _orderDatabase;

        private List<Order> tempList;

        private ObservableCollection<Order> list;

        public ObservableCollection<Order> List 

        {
            get { return list; }
            set {list = value;

                NotifyPropertyChanged("List");
            } 
        }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                NotifyPropertyChanged("SelectedOrder");
            }
        }

        public ICommand DeleteCommand { get; private set; }

        public ICommand AddButtonCommand { get; set; }

        private INavigation _navigation;

        public OrderListViewModel()
        {

        }

        public OrderListViewModel(INavigation navigation)
        {
            _orderDatabase = new OrderDatabase();

             tempList = _orderDatabase.GetUsers();

            List = new ObservableCollection<Order>(tempList);

            AddButtonCommand = new Command(() => AddButton());

            DeleteCommand = new Command(() => DeleteButton());

            _navigation = navigation;
        }

        public void DeleteButton()
        {
           _orderDatabase.DeleteUser(SelectedOrder);
            tempList = _orderDatabase.GetUsers();
            List.Clear();
            foreach (var item in tempList)
            {
                List.Add(item);
            }
        }


        public async void AddButton()
            {
            await _navigation.PushAsync(new NewOrder()); ;
            }

        

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
