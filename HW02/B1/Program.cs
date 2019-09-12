using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2; //declare variables

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}.");
            }

            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} is greater than {num1}.");
            }

            else
            {
                Console.WriteLine($"{num1} and {num2} are the same.");
            }
        }
    }
}
