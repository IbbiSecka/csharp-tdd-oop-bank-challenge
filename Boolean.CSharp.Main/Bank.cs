using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Bank
    {
        User customer = new User();
        List<Transaction> _transactions = new List<Transaction>();

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

        public List<Transaction> transactionlist() {

            DateOnly firstTransactio = new DateOnly(2023, 12, 12);
            DateOnly secondTrans = new DateOnly(2023, 11, 12);
            DateOnly thirdTrans = new DateOnly(2023, 8, 12);


            Transaction first = new Transaction(firstTransactio, 1000, 0, 5000);
            Transaction second = new Transaction(secondTrans, 0, 500, 5000);

            Transaction third = new Transaction(thirdTrans,0, 100, 5000);

             _transactions.Add(third);
            _transactions.Add(second);
            _transactions.Add(first);
            var orderedTransactions = _transactions.OrderByDescending(x => x.date).ToList();

            // Print the bank statement header
            Console.WriteLine("date     || credit      || debit      || balance");

            
            foreach (var trans in orderedTransactions)
            {
                Console.WriteLine(trans.ToString());
            }

            return orderedTransactions;

            
        
        }
        
    }
}
