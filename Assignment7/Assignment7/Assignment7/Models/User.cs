using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Assignment7.Models
{
    public class User
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string picture { get; set; }
        //public Conversation conversation;

        public User()
        {

        }

        public User(string FirstName, string LastName, string Picture)
        {
            firstName = FirstName;
            lastName = LastName;
            picture = Picture;
            
        }

        

    }
    public class Rootobject
    {
        public List<User> users { get; set; }
    }
}
