using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Bank
    {
        User customer = new User();

        public double Deposit(double balance, double deposit)
        {
            if (balance > 0) 

            balance += deposit;
            return balance;
        }

        public double withDraw(double balance, double withdrawal)
        {
            if (withdrawal > 0 && withdrawal <=balance)
            
            balance -= withdrawal;
            return balance;
        }
        public bool CreateCurrentAccount(User user) {
            user.createCurrentAccount(0);
            return true;
        }
        public bool CreateSavingsAccount(User user) { 
            user.createSavingsAccount(0);
            return true;
        }
    }
}
