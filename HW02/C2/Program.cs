using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 start
            int product = 1, i = 0;

            while (i <= 5 && product <= 100)
            { 
                product = product * 2;
                Console.Write($"{product} ");
                i++;
            }
            // Task 1 end

            Console.WriteLine(" ");

            // Task 2 start
            int quotient = 200; i = 0;

            while (i <= 6 && quotient >= 1)
            {
                quotient = quotient / 2;
                Console.Write($"{quotient} ");
                i++;
            }
            // Task 2 end

            Console.WriteLine(" ");

            // Task 3 start

            double halved = 200, num = 0;

            while (num <= 6 && halved >= 1)
            {
                halved = halved / 2;
                Console.Write($"{halved} ");
                num++;
            }
            // Task 3 end

            Console.WriteLine(" ");
        }
    }
}
