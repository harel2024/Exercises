using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Account
    {
        private protected double balance;
        private protected double GetBalance()
            { return balance; }
    }
    internal class SavingsAccount: Account
    {
        public void SetBalance(double b)
        {
            balance = b;
        }

    }
}
