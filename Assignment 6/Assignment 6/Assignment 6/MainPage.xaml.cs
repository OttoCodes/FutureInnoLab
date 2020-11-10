using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;
using Assignment_6.Data;

namespace Assignment_6
{
    public partial class MainPage : ContentPage
    {

        
        private Customer myNewCustomer;

        BankAccount account;

        public MainPage()
        {
            InitializeComponent();
            

            myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            
            account = myNewCustomer.ApplyForBankAccount();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
                decimal amount = Decimal.Parse(amountDeposit.Text.ToString());
                string reason = reasonDeposit.Text.ToString();
                account.DepositMoney(amount, DateTime.Now, reason);
                await DisplayAlert("Information!", $"You have deposited R{amount}", "OK");
            
            
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            
                decimal amount = Decimal.Parse(amountWithdraw.Text.ToString());
                string reason = reasonWithdraw.Text.ToString();
                account.WithdrawMoney(amount, DateTime.Now, reason);
                await DisplayAlert("Information!", $"You have withdrawn R{amount}", "OK");
            
            
               
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            string history = account.GetTransactionHistory();
            TransactionHistory.Text = history;

        }

        
    }
}
