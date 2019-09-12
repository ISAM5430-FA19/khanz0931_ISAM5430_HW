using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, num = 0, numZeros = 0, evenInt = 0, posInt = 0, count;

            Console.WriteLine("How many numbers would you like to input?");
            count = Convert.ToInt32(Console.ReadLine());

            while (i <= count)
            {
                Console.WriteLine($"Enter #{i}:");
                num = Convert.ToInt32(Console.ReadLine());
                i++;

                if (num == 0)
                {
                    numZeros++;
                }

                if (num > 0)
                {
                    posInt++;
                }

                if (num % 2 == 0)
                {
                    evenInt++;
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine($"Amount of positive integers: {posInt}");
            Console.WriteLine($"Amount of zeros: {numZeros}");
            Console.WriteLine($"Amount of even integers: {evenInt}");
        }
    }
}
