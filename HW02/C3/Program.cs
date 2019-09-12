using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 start
            int i = 1, factorial = 0;

            while (i >= 1 && factorial <= 1000)
            {
                int product = i * factorial;
                Console.Write($"{product} ");
                i++;
            }
        }
    }
}
