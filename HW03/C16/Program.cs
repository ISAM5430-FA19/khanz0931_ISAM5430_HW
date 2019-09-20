using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, k, i, num = 0, prevNum = 0;

            Console.WriteLine("Enter a non-negative integer: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    num = 0;
                    Console.Write(num);
                }

                for (k = 1; k <= i; k++)
                {
                    num = num + 1;
                    Console.Write(num);
                    prevNum = num;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
