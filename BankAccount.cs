using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class BankAccount
    {
        //creat field;
        string _Name;
        string _AccountNumber;
        double _Balance;

        protected BankAccount(string name, double balance) //creat constructor with two arguments name and balance;
        {
            _Name = name;            
            _Balance = balance;
        }

        public string Name { get => _Name; set => _Name = value; } //creat properties
        public double Balance { get => _Balance; protected set => _Balance = value; } //protected before set, only the child class can change the balance;

        public abstract void Deposit(double amount);//created a deposit method, use virtual limits of authorit
        public abstract void Withdraw(double amount);  //created a deposit method, use virtual limits of authority
       
        public override string ToString() //use override to string display result;
        {
            return GetType().Name + $" Name: {_Name} Balance: ${_Balance}";
        }
    }
}
