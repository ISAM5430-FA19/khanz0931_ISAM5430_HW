using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a non-negative integer: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int num = 1; num <= i; num++)
                {
                    Console.Write(num + ", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
