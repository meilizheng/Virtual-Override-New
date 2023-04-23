using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_New
{
    public class SavingAccount : BankAccount //created a inheritance class called savingaccount
    {
        double _interest;
        public SavingAccount(string name, double balance, double interest = 0.1) : base(name, balance) //created a constructor base on parent class add it own constructor interest;
        {
            _interest = interest;
        }

        public override void Deposit(double amount) //created a deposit method base on parent class;
        {
            base.Deposit(amount);
            Balance += amount * _interest;//add interest to balance;
            Console.WriteLine($"Added your deposit ${amount} and interest ${amount * _interest}");
        }
    }
}
