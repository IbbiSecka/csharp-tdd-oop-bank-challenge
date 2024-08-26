using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class User
    {
        CAccount currentAccount { get; set; }
        SAccount savingsAccount { get; set; }
        public User(CAccount currentAccount = null, SAccount savingsAccount = null)
        {

            this.currentAccount = currentAccount;
            this.savingsAccount = savingsAccount;
        }
        public void createCurrentAccount(double balance)
        {
            if (currentAccount == null)
            {
                this.currentAccount = new CAccount(balance);
            }

        }
        public void createSavingsAccount(double balance)
        {
            if (savingsAccount == null)
            {
                this.savingsAccount = new SAccount(balance);
            }
        }
    }
}
