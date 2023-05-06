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
        double _OverdraftFee;

        public CheckingAccount(string name, double balance, double overdraftFee = 50) : base(name, balance)
        {
            _OverdraftFee = overdraftFee;
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("please check you deposit amount.");
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
