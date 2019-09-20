using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0, numSquared = 0, smallSquared = 1000;

            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("You have entered an invalid number. App terminating.");
                    break;
                }

                numSquared = num * num;

                if (numSquared < smallSquared)
                {
                    smallSquared = numSquared;
                }

                if (num >= smallSquared)
                {
                    count++;
                    Console.WriteLine(" ");
                    Console.WriteLine($"Integer set #{count} is complete.");
                    Console.WriteLine(" ");
                    numSquared = 0;
                    smallSquared = 1000;
                }
            }

            Console.WriteLine($"There are a total of {count} integer sets.");
        }
    }
}
