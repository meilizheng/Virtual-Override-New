using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Override_New
{
    internal class RetirementAccount : BankAccount
    {
        public RetirementAccount(string name, double balance) : base(name, balance)
        {
           
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            Balance = base.Balance;
            Console.WriteLine(GetType().Name + "  Cannot withdraw from a retirement account");
        }     
    }
}
