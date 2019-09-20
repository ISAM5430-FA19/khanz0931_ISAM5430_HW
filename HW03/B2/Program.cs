using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum = 0, i = 0, prevNum = 0;

            while (i >= 0)
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());

                if (num == prevNum)
                {
                    Console.WriteLine("You have entered the same number twice. Displaying sum.");
                    break;
                }

                else
                {
                    prevNum = num;
                    sum = sum + num;
                    i++;
                }
            }

            Console.WriteLine($"The sum of the numbers entered is: {sum}");
        }
    }
}
