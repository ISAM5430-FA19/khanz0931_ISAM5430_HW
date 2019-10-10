using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (Balance > withdrawAmount)
            {
                Balance = Balance - withdrawAmount;
            }

            else if (withdrawAmount > Balance)
            {
                Console.WriteLine("Unable to make a withdrawl, as it excedes the balance of this account");
            }
        }
    }
}
