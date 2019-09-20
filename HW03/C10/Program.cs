using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lineCount = 0, lineTotal = 0, i = 0;

            Console.WriteLine("Enter the size of the square (n by n) using a positive integer: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            lineTotal = n;

            while (i <= n)
            {
                Console.Write('X');
                i++;

                if (i == n)
                {
                    Console.WriteLine();
                    i = 0;
                    lineCount++;

                    if (lineCount == lineTotal)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}
