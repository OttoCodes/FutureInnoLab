using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Banking;
using System.Threading.Tasks;

namespace Assignment_6.Data
{
   public class CustomerDataBase
{
        readonly SQLiteAsyncConnection _database;

        public CustomerDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Customer>().Wait();
        }

        public Task<List<Customer>> GetNotesAsync()
        {
            return _database.Table<Customer>().ToListAsync();
        }

       

        public Task<int> SaveNoteAsync(Customer customer)
        {
            if (customer.ID != 0)
            {
                return _database.UpdateAsync(customer);
            }
            else
            {
                return _database.InsertAsync(customer);
            }
        }

    //    public Task<int> DeleteNoteAsync(Customer customer)
      //  {
      //      return _database.DeleteAsync(customer);
      //  }
    }
}
