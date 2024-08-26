using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transaction
    {
        DateOnly date;
        double amount {  get; set; }
        double balance { get; set; }
        public Transaction(DateOnly date, double amount, double balance)
        {
            this.date = date;
            this.amount = amount;
            this.balance = balance;
        }
    }
}
