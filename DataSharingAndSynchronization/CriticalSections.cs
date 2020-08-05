using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataSharingAndSynchronization
{
    class CriticalSections
    {
        private class BankAccount
        {
            private readonly BankAccount _bankAccount = new BankAccount();
            public object padlock = new object();
            public int Balance { get; private set; }

            public void Deposit(int amount)
            {


                //lock (padlock)
                //{
                //    // += is really two operations
                //    // op1 is temp <- get_Balance() + amount
                //    // op2 is set_Balance(temp)
                //    // something can happen _between_ op1 and op2

                //    Balance += amount;
                //}
            }
        }

        class BankAccount
        {
        }

        public void Withdraw(int amount)
        {
            lock (padlock)
            {
                Balance -= amount;
            }
        }
    }
}
