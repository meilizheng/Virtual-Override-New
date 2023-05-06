namespace Virtual_Override_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstract.BankAccount bankAccount = new CheckingAccount("Meili Zheng", 1000); //created a new instance for bankaccount
            Console.WriteLine(bankAccount); //display bankaccount balance;
            bankAccount.Deposit(-500); //call deposit method;
            bankAccount.Withdraw(10000); //call withdraw method;
            Console.WriteLine("Current balance: $" + bankAccount.Balance +"\n"); //display current balance;

            CheckingAccount ckaccount = new CheckingAccount("Belle", 1500); //created a new instance for checking account;
            Console.WriteLine(ckaccount);           //display checking account balance;
            ckaccount.Withdraw(2500);   //call withdraw method;
            Console.WriteLine("Current balance: $" + ckaccount.Balance +"\n"); //display current balance;

            SavingAccount saving = new SavingAccount("Claire", 2000); //created a new instance for saving account;
            Console.WriteLine(saving);  //display balance;
            saving.Deposit(1000);
            saving.Withdraw(4000);//call deposit method;
            Console.WriteLine("Current balance: $" + saving.Balance + "\n"); //display current balance;

            RetirementAccount retirement = new RetirementAccount("Meili", 5000);
            retirement.Withdraw(500);
            Console.WriteLine( retirement.Name + "  Current balance: " + retirement.Balance + "\n");
        }   
    }
}