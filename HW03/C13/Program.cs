using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 1000, rate = 0.05m;

            for (int year = 1; year <= 10; year++)
            {
                amount = amount * (1 + rate);
                Console.WriteLine($"Year{year,2} with {rate.ToString("P", CultureInfo.InvariantCulture)} rate: {amount.ToString("C", CultureInfo.CurrentCulture)}");

                if (year == 10)
                {
                    Console.WriteLine();
                    rate = rate + 0.01m;
                    year = 0;
                    amount = 1000;
                }

                if (rate > 0.1m)
                {
                    break;
                }
            }
        }
    }
}
