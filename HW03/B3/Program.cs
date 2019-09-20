using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, bigNum = 0, i = 0, prevNum = 0;

            while (i >= 0)
            {
                Console.WriteLine("Enter a number in increasing order:");
                num = int.Parse(Console.ReadLine());

                if (num <= prevNum)
                {
                    Console.WriteLine("You have entered a number less than or equal to the previous number. Displaying largest number.");
                    break;
                }

                if (num > bigNum)
                {
                    bigNum = num;
                }

                prevNum = num;
                i++;
            }

            Console.WriteLine($"The largest number is: {bigNum}");
        }
    }
}
