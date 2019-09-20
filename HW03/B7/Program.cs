using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, remainder, reverseNum = 0;

            Console.WriteLine("Enter a positive integer: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                remainder = num % 10;
                reverseNum = (reverseNum * 10) + remainder;
                num = num / 10;
            }

            Console.WriteLine($"The number reversed is: {reverseNum}");
        }
    }
}
