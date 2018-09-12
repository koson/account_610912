using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("qwert1234", 10000);
            ac.Display();
            ac.Debit(300);
            ac.Display();
            ac.Credit(5000);
            ac.Debit(20000);
            ac.Display();
        }
    }

    public class Account
    {
        private string accountName;
        private int accountBalance;
        private int creditBalance;

        public void Credit(int amount)
        {
            Console.WriteLine("Credit {0} bath", amount);
            creditBalance += amount;
        }
        public void Debit(int amount)
        {
            if (amount > accountBalance)
                Console.WriteLine("Sorry, there is not enough money");
            else
                accountBalance -= amount;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Balance: {1 , 20:C}", 
                accountName, accountBalance);
        }

        public Account(string accountName, int amount)
        {
            this.accountName = accountName;
            accountBalance = amount;
        }


    }

}
