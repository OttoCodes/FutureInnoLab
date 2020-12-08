using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using System.Linq;

namespace TShirtOrderingApp
{
    
    public class OrderDatabase
    {
        private SQLiteConnection _database;

        public OrderDatabase()
        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            _database.CreateTable<Order>();
            SeedDataBase();

        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"orders.db");

            return path;
        }


        public void SeedDataBase()
        {

            if (_database.Table<Order>().Count() == 0)
            {
                Order joe = new Order();

                joe.Address = "1234345";
                joe.Color = "black";
                joe.DateOfOrder = DateTime.Now;
                joe.Name = "joe";
                joe.Size = "XXL";
                joe.Gender = "Male";


                _database.Insert(joe);
            }

        }

        

        public List<Order> GetUsers()
        {

            var list = _database.Table<Order>().ToList();

            return list;
        }

        public void AddUser(string name, string color, string size, string address, string gender)
        {

            Order newOrder = new Order();
            newOrder.Address = address;
            newOrder.Color = color;
            newOrder.DateOfOrder = DateTime.Now;
            newOrder.Name = name;
            newOrder.Size = size;
            newOrder.Gender = gender;

            _database.Insert(newOrder);

        }
        

        public void DeleteUser(Order toDelete)
        {
            _database.Delete(toDelete);
        }

    }
}
