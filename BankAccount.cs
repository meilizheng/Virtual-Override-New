using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_New
{
    public class BankAccount
    {
        //creat field;
        string _Name;
        string _AccountNumber;
        double _Balance;

        public BankAccount(string name, double balance) //creat constructor with two arguments name and balance;
        {
            _Name = name;            
            _Balance = balance;
        }

        public string Name { get => _Name; set => _Name = value; } //creat properties
        public string AccountNumber { get => _AccountNumber; }
        public double Balance { get => _Balance; protected set => _Balance = value; } //protected before set, only the child class can change the balance;

        public virtual void Deposit(double amount) //created a deposit method, use virtual limits of authority
        {
            if (amount >= 0) 
            {
                _Balance += amount;
                
            }
            else
            {
                Console.WriteLine($"deposit amount: ${amount} invaild");
            }
        }

        public virtual void Withdraw(double amount)  //created a deposit method, use virtual limits of authority
        {
            
            if (amount > 0 && amount <= _Balance)
            {
                _Balance -= amount;
            }

            else
            {
                Console.WriteLine($"Withdraw amount: ${amount} exceed balance or invaild");
            }
        }
       
        public override string ToString() //use override to string display result;
        {
            return GetType().Name + $" Name: {_Name} Balance: ${_Balance}";
        }
    }
}
