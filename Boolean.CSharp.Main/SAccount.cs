using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class SAccount : Account
    {
    
        public SAccount(double balance) : base(balance) 
        {
            this.balance = balance;
        }


    }
}
