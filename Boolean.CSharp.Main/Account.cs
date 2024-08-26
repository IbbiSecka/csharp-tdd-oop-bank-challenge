using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class Account
    {
        public double balance { get; set; }
        public Account(double balance) { 
            this.balance = balance;
        }

    }
}
