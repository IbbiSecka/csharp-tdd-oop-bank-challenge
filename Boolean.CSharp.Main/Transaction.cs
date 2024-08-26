using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transaction
    {
        public DateOnly date {  get; set; }
        double debit {  get; set; }
        double credit { get; set; }
        double balance { get; set; }
        public Transaction(DateOnly date, double debit, double credit, double balance )
        {
            this.date = date;
            this.credit = credit;
            this.debit = debit;
            this.balance = balance;
        }
        public override string ToString()
        {
            return $"{date:dd/MM/yyyy} || {(credit == 0 ? "        " : credit.ToString("F2"))} || {(debit == 0 ? "" : debit.ToString("F2"))} || {balance.ToString("F2")}";
        }
    }
}
