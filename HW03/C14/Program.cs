using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            // (a)
            Console.WriteLine("(a)");
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // (b)
            Console.WriteLine("(b)");
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write("");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // (c)
            Console.WriteLine("(c)");
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 10 - i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // (d)
            Console.WriteLine("(d)");
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
