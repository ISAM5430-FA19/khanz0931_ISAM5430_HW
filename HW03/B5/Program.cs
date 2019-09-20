using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, num, closestNum = 0;

            Console.WriteLine("Enter a number for 'item':");
            item = int.Parse(Console.ReadLine());

            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());

                if (item - num < item - closestNum && item - num > 0)
                {
                    closestNum = num;
                }

                if (item == num)
                {
                    Console.WriteLine("The number you have entered matches the item. App terminating.");
                    break;
                }

                Console.WriteLine($"The closest number to item ({item}) is: {closestNum}");
                Console.WriteLine(" ");
            }
        }
    }
}
