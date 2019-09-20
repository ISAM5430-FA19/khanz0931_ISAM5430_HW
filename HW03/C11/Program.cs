using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 x 9 Multiplication Table:");
            Console.WriteLine();

            for (int numOne = 1; numOne <= 9; numOne++)
            {
                for (int numTwo = 1; numTwo <= 9; numTwo++)
                {
                    Console.Write($"({numOne} * {numTwo} = {numOne * numTwo}) ");

                    if (numTwo == 9)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
