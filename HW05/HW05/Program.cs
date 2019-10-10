using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal withdrawalAmount;
            Account account = new Account("Zaid Khan", 1000.00m);

            Console.WriteLine($"{account.Name}'s balance: {account.Balance}");

            Console.WriteLine("Enter a withdrawal amount: ");
            withdrawalAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Making a withdrawl of: {withdrawalAmount}");

            account.Withdraw(withdrawalAmount);

            Console.WriteLine($"{account.Name}'s balance: {account.Balance}");
        }
    }
}
