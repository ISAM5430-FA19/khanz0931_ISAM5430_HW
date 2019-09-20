using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, factor, count = 0;

            Console.WriteLine("Enter the number of prime numbers you would like to see: ");
            number = int.Parse(Console.ReadLine());

            for (int integer = 1; integer >= 0; integer++)
            {
                factor = 0;

                for (int i = 2; i <= integer / 2; i++)
                {
                    if (integer % i == 0)
                    {
                        factor++;
                        break;
                    }
                }

                if (factor == 0 && integer != 1)
                {
                    Console.Write($"{integer}, ");
                    count++;

                    if (count == number)
                    {
                        break;
                    }
                }
            }
        }
    }
}
