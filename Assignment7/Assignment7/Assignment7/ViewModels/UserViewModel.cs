using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assignment7.Models;
using Assignment7.Services;

namespace Assignment7.ViewModels
{
    class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<User> _users;
        public List<User> Users
        {
            get { return _users; }
            set { _users = value; NotifyPropertyChanged();  } 
        }


        public UserViewModel()
        {
            LoadUser();
        }

        public void LoadUser()
        {
            
           
                Users =  new UserDataConverter().GetData();
            
        }



        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }


    

}
