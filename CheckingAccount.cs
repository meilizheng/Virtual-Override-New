using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_New
{
    public class CheckingAccount : BankAccount //created an inheritance class;
    {
        double _OverdraftFee; //created a field;

        public CheckingAccount(string name, double balance, double overdraftFee = 50) : base(name, balance)//created constructor based on parent class(bank account)
        {
            _OverdraftFee = overdraftFee;
        }

        public override void Deposit(double amount) //created a deposit method based on parent class;
        {
            if (amount > 0)//if amount greater than zero, add it to balance;
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("please check you deposit amount.");//else notify user for the invalid input;
            }
        }

        public override void Withdraw(double amount) //created withdraw method based on parent class bankaccount;
        {
            if (amount > base.Balance) //if withdraw amount exceed the balance overdraft fee charged.
            {
                Balance -= _OverdraftFee;
                Console.WriteLine($"your withdraw amount ${amount} exseed the total balance, Overdraft fee charged.");
            }
        }       
    }
}
