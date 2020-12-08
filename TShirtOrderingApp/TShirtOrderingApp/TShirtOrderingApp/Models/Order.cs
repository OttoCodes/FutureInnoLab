using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TShirtOrderingApp
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }

    }
}
