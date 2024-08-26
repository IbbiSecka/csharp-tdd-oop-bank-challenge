using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class CAccount : Account
        
    {
        Transaction transansaction {  get; set; }
        public CAccount(double balance): base(balance) {
            this.balance = balance;
        
        }
        
    }
}
