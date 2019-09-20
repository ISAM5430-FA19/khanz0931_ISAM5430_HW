using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, remainder, reverseSum = 0;

            Console.WriteLine("Enter the first sumber: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second sumber: ");
            b = int.Parse(Console.ReadLine());

            sum = a + b;

            while (sum > 0)
            {
                remainder = sum % 10;
                reverseSum = (reverseSum * 10) + remainder;
                sum = sum / 10;
            }

            Console.WriteLine($"The sum of {a} and {b} reversed is: {reverseSum}");
        }
    }
}
