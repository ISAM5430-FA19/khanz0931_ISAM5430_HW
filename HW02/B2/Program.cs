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
            int num1, num2, num3;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine($"{num1} is the middle number.");
            }

            else if (num2 > num1 && num2 < num3)
            {
                Console.WriteLine($"{num2} is the middle number.");
            }

            else
            {
                Console.WriteLine($"{num3} is the middle number.");
            }
        }
    }
}
