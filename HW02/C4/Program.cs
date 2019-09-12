using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, count;
            double average, sum = 0, num = 0;

            Console.WriteLine("How many numbers would you like to input?");
            count = Convert.ToInt32(Console.ReadLine());

            while (i <= count)
            {
                Console.WriteLine($"Enter #{i}:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                i++;
            }

            Console.WriteLine(" ");

            average = sum / count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
