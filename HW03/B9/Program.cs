using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, remainder;
            string binary = string.Empty;

            Console.WriteLine("Enter a postive integer: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                binary = remainder + binary;
            }

            Console.WriteLine($"{num} in binary: {binary}");
        }
    }
}
